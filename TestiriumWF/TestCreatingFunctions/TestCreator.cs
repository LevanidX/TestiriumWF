using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TestiriumWF
{
    internal class TestCreator
    {
        MySqlWriter mySqlWriter = new MySqlWriter();

        Test _studentsTest = new Test();
        List<Question> questionsList = new List<Question>();

        private Panel _questionsContainerPanel;
        private WelcomeScreenPanel _welcomeScreenPanel;

        public TestCreator(Panel questionsContainerPanel, WelcomeScreenPanel welcomeScreenPanel)
        {
            _questionsContainerPanel = questionsContainerPanel;
            _welcomeScreenPanel = welcomeScreenPanel;
        }

        public TestCreator() { }

        /// <summary>
        /// Создает тестирование и записывает в базу данных
        /// </summary>
        /// <param name="courseNumber">Номер предмета (курса)</param>
        /// <param name="userTeacherId">Номер пользователя (учителя)</param>
        /// <param name="testSettings">Настройки тестирования</param>
        public void Create(int courseNumber, int userTeacherId, TestSettings testSettings)
        {
            SerializeWelcomeScreen();
            SerializeQuestions();

            _studentsTest.TestSettings = testSettings;
            _studentsTest.FinalMark = new FinalMark();

            mySqlWriter.ExecuteNotReadableSqlCommand(
                $"INSERT INTO tests(test_name, test_course_number, " +
                $"test_user_teacher_number, test_file, test_creation_date) " +
                $"VALUES('{_studentsTest.Name}', {courseNumber}, {userTeacherId}, " +
                $"'{SerializeTestIntoXml(_studentsTest)}', " +
                $"CURDATE())");
        }

        public void CreateCompletedTestResult(int testDBId, int userStudentId, 
            Test completedStudentsTest, string markResult, int tryNumber)
        {
            mySqlWriter.ExecuteNotReadableSqlCommand(
                $"INSERT INTO completed_tests" +
                $"(" +
                    $"completed_test_number, " +
                    $"completed_test_user_student_number, " +
                    $"completed_test_file, " +
                    $"completed_test_date_of_completion, " +
                    $"completed_test_mark_value, " +
                    $"completed_test_try_number" +
                $") " +
                $"VALUES" +
                $"(" +
                    $"{testDBId}, " +
                    $"{userStudentId}, " +
                    $"'{SerializeTestIntoXml(completedStudentsTest)}', " +
                    $"NOW(), " +
                    $"'{markResult}', " +
                    $"'{tryNumber}'" +
                $")");
        }

        /// <summary>
        /// Создает XML-файл тестирования
        /// </summary>
        /// <returns></returns>
        private string SerializeTestIntoXml(Test studentsTest)
        {
            var xmlSerializer = new XmlSerializer(typeof(Test));
            var testWriter = new StringWriter();

            xmlSerializer.Serialize(testWriter, studentsTest, ClearNamespaces());

            return testWriter.ToString();
        }

        /// <summary>
        /// Удаление пространства имен в начале файла XML
        /// </summary>
        /// <returns></returns>
        private XmlSerializerNamespaces ClearNamespaces()
        {
            var xmlNamespace = new XmlSerializerNamespaces();
            xmlNamespace.Add(string.Empty, string.Empty);
            return xmlNamespace;
        }

        /// <summary>
        /// Сериализует экран приветствия
        /// </summary>
        private void SerializeWelcomeScreen()
        {
            _studentsTest.Name = _welcomeScreenPanel.GetTitleValue();
            _studentsTest.Description = new Description(_welcomeScreenPanel.GetDescriptionValue());
        }
        
        /// <summary>
        /// Сериализует вопросы
        /// </summary>
        private void SerializeQuestions()
        {
            SerializeQuestions<OneQuestionPanel>(TestTypes.OneAnswerQuestion);
            SerializeQuestions<MultipleQuestionPanel>(TestTypes.MultipleAnswerQuestion);
            SerializeQuestions<TextQuestionPanel>(TestTypes.TextAnswerQuestion);
            SerializeQuestions<SequenceQuestionPanel>(TestTypes.SequenceAnswerQuestion);
            SerializeQuestions<MatchQuestionPanel>(TestTypes.MatchAnswerQuestion);
            _studentsTest.Questions = questionsList;
        }

        /// <summary>
        /// Сериализует заключительный экран
        /// </summary>
        public TestSettings SerializeEndScreen(RadioButton markRadioButton, Panel markPanel,
            CustomPercentageTextBox nonMarkPercentageTextBox, RadioButton isTimeLimited,
            CustomMinuteTextBox timeLimitTextBox, RadioButton isPasswordActive,
            CustomPasswordTextBox passwordTextBox, CustomComboBox comboTries)
        {
            var estimationMethods = GetMarkRBValue(markRadioButton, markPanel, nonMarkPercentageTextBox);
            var timeLimitedTest = GetTimeLimitRBValue(isTimeLimited, timeLimitTextBox);
            var testPassword = GetPasswordRBValue(isPasswordActive, passwordTextBox);
            var allowedTriesQuantity = GetAllowedTriesQuantity(comboTries);

            return new TestSettings(estimationMethods, timeLimitedTest, testPassword, allowedTriesQuantity);
        }

        private void SerializeQuestions<QuestionPanel>(string testType)
        {
            var GetQuestionTextMethod = typeof(QuestionPanel).GetMethod("GetQuestionText",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            var GetAnswersMethod = typeof(QuestionPanel).GetMethod("GetAnswers",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            var GetRightAnswersMethod = typeof(QuestionPanel).GetMethod("GetRightAnswers",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            var GetQuestionSettingsMethod = typeof(QuestionPanel).GetMethod("GetQuestionSettings",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);


            foreach (var qPanel in _questionsContainerPanel.Controls.OfType<QuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = testType;
                question.QuestionText = GetQuestionTextMethod.Invoke(qPanel, null).ToString();
                question.Answers = (List<string>)GetAnswersMethod.Invoke(qPanel, null);
                question.RightAnswers = (List<string>)GetRightAnswersMethod.Invoke(qPanel, null);
                if (testType == TestTypes.TextAnswerQuestion)
                {
                    question.QuestionSettings = new QuestionSettings((bool)GetQuestionSettingsMethod.Invoke(qPanel, null));
                }
                questionsList.Add(question);
            }
        }

        private EstimationMethods GetMarkRBValue(RadioButton markRadioButton, Panel markPanel, 
            CustomPercentageTextBox nonMarkPercentageTextBox)
        {
            var percentageValues = new List<int>();

            foreach (var percentageTextBox in markPanel.Controls.OfType<CustomPercentageTextBox>())
            {
                percentageValues.Add(percentageTextBox.GetPercentageValue());
            }
            percentageValues.Reverse();

            var estimationParametres = new EstimationParametres();

            estimationParametres.BadMarkPercentage = percentageValues[0];
            estimationParametres.SatisfactoryMarkPercentage = percentageValues[1];
            estimationParametres.NormalMarkPercentage = percentageValues[2];
            estimationParametres.ExcellentMarkPercentage = percentageValues[3];

            if (markRadioButton.Checked)
            {
                return new EstimationMethods("MARK", estimationParametres);
            }
            else
            { 
                estimationParametres.PassMarkPercentage = nonMarkPercentageTextBox.GetPercentageValue();
                return new EstimationMethods("NON_MARK", estimationParametres);
            }
        }

        private TimeLimitedTest GetTimeLimitRBValue(RadioButton isTimeLimited, CustomMinuteTextBox timeLimitTextBox)
        {
            if (isTimeLimited.Checked)
            {
                return new TimeLimitedTest(true, timeLimitTextBox.GetMinuteValue());
            }
            else
            {
                return new TimeLimitedTest(false, 0);
            }
        }

        private TestPassword GetPasswordRBValue(RadioButton isPasswordActive, CustomPasswordTextBox passwordTextBox)
        {
            if (isPasswordActive.Checked)
            {
                return new TestPassword(true, passwordTextBox.GetPasswordValue());
            }
            else
            {
                return new TestPassword(false, string.Empty);
            }
        }

        private int GetAllowedTriesQuantity(CustomComboBox comboTries)
        {
            return Convert.ToInt32(comboTries.TextValue);
        }
    }
}
