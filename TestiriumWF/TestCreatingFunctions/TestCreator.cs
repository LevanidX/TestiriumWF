using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomControls.CustomOverrideControls;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammFunctions;
using TestiriumWF.SqlFunctions;
using TestiriumWF.TestCreatingFunctions;
using TestStructure;

namespace TestiriumWF
{
    internal class TestCreator
    {
        private TestSerializer _testSerializer = new TestSerializer();
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        private Test _studentsTest = new Test();
        private List<Question> _questionsList = new List<Question>();

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
        public void CreateNewTest(int courseNumber, TestSettings testSettings)
        {
            SerializeWelcomeScreen();
            SerializeQuestions();

            _studentsTest.TestSettings = testSettings;
            _studentsTest.OverallResult = new OverallResult();

            _mySqlFunctions.CallProcedure("push_new_test", new MySqlParameter[]
            {
                new MySqlParameter("t_name", _studentsTest.Name),
                new MySqlParameter("course_id", courseNumber),
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("t_file", _testSerializer.SerializeTestIntoXml(_studentsTest))
            });
        }

        /// <summary>
        /// Сериализует экран приветствия
        /// </summary>
        private void SerializeWelcomeScreen()
        {
            if (_welcomeScreenPanel.GetTitleValue() != string.Empty || _welcomeScreenPanel.GetDescriptionValue() != string.Empty)
            {
                _studentsTest.Name = _welcomeScreenPanel.GetTitleValue();
                _studentsTest.Description = new Description(_welcomeScreenPanel.GetDescriptionValue());
            }
            else
            {
                MessageBox.Show("Не все поля на начальном экране были заполнены");
                throw new Exception();
            }
        }
        
        /// <summary>
        /// Сериализует вопросы
        /// </summary>
        private void SerializeQuestions()
        {
            SerializeQuestion<OneQuestionPanel>(TestTypes.OneAnswerQuestion);
            SerializeQuestion<MultipleQuestionPanel>(TestTypes.MultipleAnswerQuestion);
            SerializeQuestion<TextQuestionPanel>(TestTypes.TextAnswerQuestion);
            SerializeQuestion<SequenceQuestionPanel>(TestTypes.SequenceAnswerQuestion);
            SerializeQuestion<MatchQuestionPanel>(TestTypes.MatchAnswerQuestion);
            _studentsTest.Questions = _questionsList;
        }

        /// <summary>
        /// Сериализует заключительный экран
        /// </summary>
        public TestSettings SerializeEndScreen(RadioButton markRadioButton, Panel markPanel,
            CustomNumericTextBox nonMarkPercentageTextBox, RadioButton isTimeLimited,
            CustomNumericTextBox timeLimitTextBox, RadioButton isPasswordActive,
            CustomPasswordTextBox passwordTextBox, CustomComboBox comboTries)
        {
            var estimationMethods = GetMarkRBValue(markRadioButton, markPanel, nonMarkPercentageTextBox);
            var timeLimitedTest = GetTimeLimitRBValue(isTimeLimited, timeLimitTextBox);
            var testPassword = GetPasswordRBValue(isPasswordActive, passwordTextBox);
            var allowedTriesQuantity = GetAllowedTriesQuantity(comboTries);

            return new TestSettings(estimationMethods, timeLimitedTest, testPassword, allowedTriesQuantity);
        }

        private void SerializeQuestion<QuestionPanel>(string testType)
        {
            try
            {
                var GetQuestionTextMethod = typeof(QuestionPanel).GetMethod("GetQuestionText",
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                var GetAnswersMethod = typeof(QuestionPanel).GetMethod("GetAnswers",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                var GetRightAnswersMethod = typeof(QuestionPanel).GetMethod("GetRightAnswers",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                var GetQuestionSettingsMethod = typeof(QuestionPanel).GetMethod("GetQuestionSettings",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);


                foreach (var questionPanel in _questionsContainerPanel.Controls.OfType<QuestionPanel>())
                {
                    Question question = new Question();
                    question.QuestionType = testType;
                    question.QuestionText = GetQuestionTextMethod.Invoke(questionPanel, null).ToString();
                    question.Answers = (List<string>)GetAnswersMethod.Invoke(questionPanel, null);
                    question.RightAnswers = (List<string>)GetRightAnswersMethod.Invoke(questionPanel, null);

                    if (testType == TestTypes.TextAnswerQuestion)
                    {
                        question.QuestionSettings = new QuestionSettings((bool)GetQuestionSettingsMethod.Invoke(questionPanel, null));
                    }

                    _questionsList.Add(question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private EstimationMethods GetMarkRBValue(RadioButton markRadioButton, Panel markPanel, 
            CustomNumericTextBox nonMarkPercentageTextBox)
        {
            var percentageValues = new List<int>();

            if (markRadioButton.Checked) 
            {
                markPanel.Controls.OfType<CustomNumericTextBox>().ToList().ForEach(
                percentageTextBox => percentageValues.Add(Convert.ToInt32(percentageTextBox.TextValue)));
            }

            percentageValues.Reverse();

            return markRadioButton.Checked
                ? new EstimationMethods("MARK", new EstimationParametres(
                    percentageValues[0], percentageValues[1], percentageValues[2], percentageValues[3]))
                : new EstimationMethods("NON_MARK", new EstimationParametres(Convert.ToInt32(nonMarkPercentageTextBox.TextValue)));
        }

        private TimeLimitedTest GetTimeLimitRBValue(RadioButton isTimeLimited, CustomNumericTextBox timeLimitTextBox)
        {
            return isTimeLimited.Checked
                ? new TimeLimitedTest(true, Convert.ToInt32(timeLimitTextBox.TextValue))
                : new TimeLimitedTest(false, 0);
        }

        private TestPassword GetPasswordRBValue(RadioButton isPasswordActive, CustomPasswordTextBox passwordTextBox)
        {
            return isPasswordActive.Checked 
                ? new TestPassword(true, passwordTextBox.TextValue) 
                : new TestPassword(false, string.Empty);
        }

        private int GetAllowedTriesQuantity(CustomComboBox comboTries) => Convert.ToInt32(comboTries.TextValue);
    }
}
