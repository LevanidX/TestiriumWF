using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;

namespace TestiriumWF
{
    internal class TestDeserializer
    {
        private Test _studentsTest = new Test();

        private string _xmlTestFile;
        private Panel _testQuestionPanels;
        private FlowLayoutPanel _questionButtonsPanel;

        private int _questionsCount = 1; //номер вопроса отображаемый на кнопке

        public TestDeserializer(Panel questionsPanel, 
            FlowLayoutPanel questionButtonsPanel, string xmlTestFile)
        {
            _testQuestionPanels = questionsPanel;
            _questionButtonsPanel = questionButtonsPanel;
            _xmlTestFile = xmlTestFile;
        }

        public void CreateTest(TestWelcomeScreen testWelcomeScreen)
        {
            DeserializeTest(); //десериализация теста
            testWelcomeScreen.SetWelcomeScreenValues(_studentsTest); //заполнение начального экрана
            CreateQuestions(); //создание вопросов
            MakeQuestionPanelsTagged(); //присвоение тега каждой панели с вопросом
        }

        public Test GetTest()
        {
            return _studentsTest;
        }

        /// <summary>
        /// Присваивает тег каждой панели с вопросом
        /// </summary>
        private void MakeQuestionPanelsTagged()
        {
            int counter = 0;

            foreach (var userControl in _testQuestionPanels.Controls.OfType<UserControl>()) //присвоение тегов каждой панели с вопросом
            {
                userControl.Tag = counter;
                counter++;
            }
        }

        //сохранять как ответил юзер в итоге (ну это прям в идеале, по факту можно ведь)

        private void DeserializeTest()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Test));

            using (var stringReader = new StringReader(_xmlTestFile))
            {
                _studentsTest = (Test)xmlSerializer.Deserialize(stringReader);
            }
        }

        private void CreateQuestions()
        {
            foreach (var question in _studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.OneAnswerQuestion)
                {
                    DeserializeAnswerQuestion<TestOneQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    DeserializeAnswerQuestion<TestMultipleQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.TextAnswerQuestion)
                {
                    DeserializeAnswerQuestion<TestTextQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.SequenceAnswerQuestion)
                {
                    DeserializeAnswerQuestion<TestSequenceQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.MatchAnswerQuestion)
                {
                    DeserializeAnswerQuestion<TestMatchQuestionPanel>(question);
                }
            }

            foreach (var questionPanel in _testQuestionPanels.Controls.OfType<UserControl>())
            {
                questionPanel.Location = new Point(16, 16);
            }
        }

        private void DeserializeAnswerQuestion<TestQuestionPanel>(Question question)
            where TestQuestionPanel : UserControl, new()
        {
            var questionPanel = (TestQuestionPanel)Activator.CreateInstance(typeof(TestQuestionPanel));

            var SetQuestionMethod = typeof(TestQuestionPanel).GetMethod("SetQuestion",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

            var SetQuestionTextMethod = typeof(TestQuestionPanel).GetMethod("SetQuestionText",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

            var SetAnswersMethod = typeof(TestQuestionPanel).GetMethod("SetAnswers",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

            SetQuestionMethod.Invoke(questionPanel, new object[] { question });
            SetQuestionTextMethod.Invoke(questionPanel, null);
            SetAnswersMethod.Invoke(questionPanel, null);

            AddButtonToPanel(questionPanel, question);
        }

        private void AddButtonToPanel(UserControl questionPanel, Question question)
        {
            _testQuestionPanels.Controls.Add(questionPanel);
            var customTestButtonControl = new CustomTestButtonControl(questionPanel, question)
            {
                TextValue = _questionsCount.ToString()
            };
            _questionButtonsPanel.Controls.Add(customTestButtonControl);

            _questionsCount++;
        }
    }
}
