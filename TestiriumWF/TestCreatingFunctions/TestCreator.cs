using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;

namespace TestiriumWF
{
    internal class TestCreator
    {
        MySqlWriter mySqlWriter = new MySqlWriter();

        Test studentsTest = new Test();
        List<Question> questionsList = new List<Question>();

        private Panel _questionsContainerPanel;
        private WelcomeScreenPanel _welcomeScreenPanel;

        public TestCreator(Panel questionsContainerPanel, WelcomeScreenPanel welcomeScreenPanel)
        {
            _questionsContainerPanel = questionsContainerPanel;
            _welcomeScreenPanel = welcomeScreenPanel;
        }

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

            studentsTest.TestSettings = testSettings;

            mySqlWriter.ExecuteInsertSqlCommand($"INSERT INTO tests(test_name, test_course_number, " +
                $"test_user_teacher_number, test_file, test_password, test_creation_date) " +
                $"VALUES('{studentsTest.Name}', {courseNumber}, {userTeacherId}, " +
                $"'{SerializeTestIntoXml()}', " +
                $"'{studentsTest.TestSettings.TestPassword.Password}', " +
                $"'{DateTime.Now.ToString("yyyy-MM-dd")}')");
        }

        /// <summary>
        /// Создает XML файл тестирования
        /// </summary>
        /// <returns></returns>
        private string SerializeTestIntoXml()
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
            studentsTest.Name = _welcomeScreenPanel.GetTitleValue();
            studentsTest.Description = new Description(_welcomeScreenPanel.GetDescriptionValue());
        }
        
        /// <summary>
        /// Сериализует вопросы
        /// </summary>
        private void SerializeQuestions()
        {
            SerializeOneAnswerQuestion();
            SerializeMultipleAnswerQuestion();
            SerializeTextAnswerQuestion();
            SerializeSequenceAnswerQuestion();
            SerializeMatchAnswerQuestion();

            studentsTest.Questions = questionsList;
        }

        /// <summary>
        /// Сериализует заключительный экран
        /// </summary>
        public TestSettings SerializeEndScreen(RadioButton markRadioButton, Panel markPanel,
            CustomPercentageTextBox nonMarkPercentageTextBox, RadioButton isTimeLimited,
            CustomMinuteTextBox timeLimitTextBox, RadioButton isPasswordActive,
            CustomPasswordTextBox passwordTextBox)
        {
            var estimationMethods = GetMarkRBValue(markRadioButton, markPanel, nonMarkPercentageTextBox);
            var timeLimitedTest = GetTimeLimitRBValue(isTimeLimited, timeLimitTextBox);
            var testPassword = GetPasswordRBValue(isPasswordActive, passwordTextBox);

            return new TestSettings(estimationMethods, timeLimitedTest, testPassword);
        }

        private void SerializeOneAnswerQuestion()
        {
            foreach (var oneQuestionPanel in _questionsContainerPanel.Controls.OfType<OneQuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = TestTypes.OneAnswerQuestion;
                question.QuestionText = oneQuestionPanel.GetQuestionText();
                question.Answers = oneQuestionPanel.GetAnswers();
                question.RightAnswers = oneQuestionPanel.GetRightAnswers();
                questionsList.Add(question);
            }
        }

        private void SerializeMultipleAnswerQuestion()
        {
            foreach (var multipleQuestionPanel in _questionsContainerPanel.Controls.OfType<MultipleQuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = TestTypes.MultipleAnswerQuestion;
                question.QuestionText = multipleQuestionPanel.GetQuestionText();
                question.Answers = multipleQuestionPanel.GetAnswers();
                question.RightAnswers = multipleQuestionPanel.GetRightAnswers();
                questionsList.Add(question);
            }
        }

        private void SerializeTextAnswerQuestion()
        {
            foreach (var textQuestionPanel in _questionsContainerPanel.Controls.OfType<TextQuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = TestTypes.TextAnswerQuestion;
                question.QuestionText = textQuestionPanel.GetQuestionText();
                question.Answers = textQuestionPanel.GetAnswers();
                question.QuestionSettings = new QuestionSettings(textQuestionPanel.GetQuestionSettings().Checked);
                questionsList.Add(question);
            }
        }

        private void SerializeSequenceAnswerQuestion()
        {
            foreach (var sequenceQuestionPanel in _questionsContainerPanel.Controls.OfType<SequencingQuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = TestTypes.SequenceAnswerQuestion;
                question.QuestionText = sequenceQuestionPanel.GetQuestionText();
                question.Answers = sequenceQuestionPanel.GetAnswers();
                questionsList.Add(question);
            }
        }

        private void SerializeMatchAnswerQuestion()
        {
            foreach (var matchQuestionPanel in _questionsContainerPanel.Controls.OfType<MatchQuestionPanel>())
            {
                Question question = new Question();
                question.QuestionType = TestTypes.MatchAnswerQuestion;
                question.QuestionText = matchQuestionPanel.GetQuestionText();
                question.Answers = matchQuestionPanel.GetDefinitions();
                question.RightAnswers = matchQuestionPanel.GetAlignments();
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
    }
}
