using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestCompleteStarter
    {
        private Panel _questionsContainerPanel;
        private FlowLayoutPanel _questionButtonsPanel;

        private int _questionsCounter;

        public TestCompleteStarter(Panel questionsContainerPanel, FlowLayoutPanel questionButtonsPanel)
        {
            _questionsContainerPanel = questionsContainerPanel;
            _questionButtonsPanel = questionButtonsPanel;
        }

        public void CreateTest(Test studentsTest)
        {
            CreateQuestions(studentsTest);
            MakeQuestionPanelsTagged();

            //RandomiseQuestionPanels(); //проблема в том, что после прохождения вопросы встанут в первоначальный порядок (надо как-то запомнить расположение панелей с вопросами после рандомизации и вернуть в это положение после проверки)
        }

        private void CreateQuestions(Test studentsTest)
        {
            foreach (var question in studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.OneAnswerQuestion)
                {
                    InstantiateAnswerQuestion<TestOneQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    InstantiateAnswerQuestion<TestMultipleQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.TextAnswerQuestion)
                {
                    InstantiateAnswerQuestion<TestTextQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.SequenceAnswerQuestion)
                {
                    InstantiateAnswerQuestion<TestSequenceQuestionPanel>(question);
                }

                if (question.QuestionType == TestTypes.MatchAnswerQuestion)
                {
                    InstantiateAnswerQuestion<TestMatchQuestionPanel>(question);
                }
            }

            foreach (var questionPanel in _questionsContainerPanel.Controls.OfType<UserControl>())
            {
                questionPanel.Location = new Point(16, 16);
            }
        }

        private void InstantiateAnswerQuestion<TestQuestionPanel>(Question question)
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

            AddQuestionButtonToPanel(questionPanel, question);
        }

        private void AddQuestionButtonToPanel(UserControl questionPanel, Question question)
        {
            _questionsContainerPanel.Controls.Add(questionPanel);
            _questionsCounter++;

            var customTestButtonControl = new CustomTestButtonControl(questionPanel, question)
            {
                TextValue = _questionsCounter.ToString()
            };
            _questionButtonsPanel.Controls.Add(customTestButtonControl);
        }

        /// <summary>
        /// Присваивает тег каждой панели с вопросом
        /// </summary>
        private void MakeQuestionPanelsTagged()
        {
            int counter = 0;

            foreach (var userControl in _questionsContainerPanel.Controls.OfType<UserControl>()) //присвоение тегов каждой панели с вопросом
            {
                userControl.Tag = counter;
                counter++;
            }
        }

        private void RandomiseQuestionPanels() //на потом сделать рандомизацию вопросов
        {

        }
    }
}
