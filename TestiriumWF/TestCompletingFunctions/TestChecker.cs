using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;
using ZstdSharp.Unsafe;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestChecker
    {
        private Test _studentsTest;
        private Panel _testQuestionPanels;

        private List<List<string>> _userOneQuestionAnswers = new List<List<string>>();
        private List<List<string>> _userMultipleAnswers = new List<List<string>>();
        private List<List<string>> _userTextAnswers = new List<List<string>>();
        private List<List<string>> _userSequenceAnswers = new List<List<string>>();
        private List<List<string>> _userMatchAnswers = new List<List<string>>();

        private double _overallScore = 0;
        private double _scoreSummer; //изменяемое значение получаемое путем деления 100 на кол во вопросов

        public TestChecker(Test studentsTest, Panel testQuestionPanels) 
        {
            _studentsTest = studentsTest;
            _testQuestionPanels = testQuestionPanels;
        }

        /// <summary>
        /// Сортирует панели по присвоенным тегам
        /// </summary>
        private void MakeQuestionPanelsSorted()
        {
            var newQuestionPanel = _testQuestionPanels.Controls.OfType<UserControl>().OrderBy(x => Convert.ToInt32(x.Tag)).ToArray(); //сортировка панелей по порядку, чтобы получить сопоставление как в файле
            _testQuestionPanels.Controls.Clear();
            _testQuestionPanels.Controls.AddRange(newQuestionPanel);
        }

        private void DefineScoreSummer()
        {
            _scoreSummer = 100 / (double)_studentsTest.Questions.Count;
        }

        public void EndTest()
        {
            MakeQuestionPanelsSorted();
            DefineScoreSummer();
            CheckAndSaveTestAnswers();
        }

        public double GetOverallScore()
        { 
            return _overallScore;
        }

        /// <summary>
        /// Получает ответы пользователя со всего тестирования
        /// </summary>
        /// <typeparam name="TestQuestionPanel">Тип вопроса (UserControl)</typeparam>
        /// <param name="userAnswers">Хранилище ответов пользователя</param>
        private void SaveUserTestAnswers<TestQuestionPanel>(List<List<string>> userAnswers)
        {
            foreach (var testQuestionPanel in _testQuestionPanels.Controls.OfType<TestQuestionPanel>())
            {
                var GetAnswersMethod = typeof(TestQuestionPanel).GetMethod("GetUserAnswers",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                userAnswers.Add((List<string>)GetAnswersMethod.Invoke(testQuestionPanel, null));
            }
        }

        private void CheckAndSaveTestAnswers()
        {
            SaveUserTestAnswers<TestOneQuestionPanel>(_userOneQuestionAnswers);
            SaveUserTestAnswers<TestMultipleQuestionPanel>(_userMultipleAnswers);
            SaveUserTestAnswers<TestTextQuestionPanel>(_userTextAnswers);
            SaveUserTestAnswers<TestSequenceQuestionPanel>(_userSequenceAnswers);
            SaveUserTestAnswers<TestMatchQuestionPanel>(_userMatchAnswers);

            int currentOneAnswerNumber = 0;
            int currentMultipleAnswerNumber = 0;
            int currentTextAnswerNumber = 0;
            int currentSequenceAnswerNumber = 0;
            int currentMatchAnswerNumber = 0;

            foreach (var question in _studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.OneAnswerQuestion)
                {
                    CheckUserQuestionAnswers(question, currentOneAnswerNumber, _userOneQuestionAnswers);
                    currentOneAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    CheckUserQuestionAnswers(question, currentMultipleAnswerNumber, _userMultipleAnswers);
                    currentMultipleAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.TextAnswerQuestion)
                {
                    CheckUserQuestionAnswers(question, currentTextAnswerNumber, _userTextAnswers);
                    currentTextAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.SequenceAnswerQuestion)
                {
                    CheckUserQuestionAnswers(question, currentSequenceAnswerNumber, _userSequenceAnswers);
                    currentSequenceAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.MatchAnswerQuestion)
                {
                    CheckUserQuestionAnswers(question, currentMatchAnswerNumber, _userMatchAnswers);
                    currentMatchAnswerNumber++;
                }
            }
        }

        private void CheckUserQuestionAnswers(Question question, int currentAnswerNumber, List<List<string>> userQuestionAnswers)
        {
            question.UserAnswers = userQuestionAnswers[currentAnswerNumber];
            if (question.RightAnswers.Count != userQuestionAnswers[currentAnswerNumber].Count) return;

            MakeTextAnswerLower(question, currentAnswerNumber, userQuestionAnswers);

            if (question.QuestionType != TestTypes.SequenceAnswerQuestion && question.QuestionType != TestTypes.MatchAnswerQuestion)
            {
                CompareRightAnswers(question, SimpleQuestionCheckWithReturnedCounter(question, currentAnswerNumber, userQuestionAnswers));
            }
            else
            {
                CompareRightAnswers(question, DifficultQuestionCheckWithReturnedCounter(question, currentAnswerNumber, userQuestionAnswers));
            }
        }

        private void MakeTextAnswerLower(Question question, int currentAnswerNumber, List<List<string>> userQuestionAnswers)
        {
            if (question.QuestionType == TestTypes.TextAnswerQuestion)
            {
                if (!question.QuestionSettings.IsCaseSensitivityOn)
                {
                    userQuestionAnswers[currentAnswerNumber][0] = userQuestionAnswers[currentAnswerNumber][0].ToLower(); //отменяем чувствительность к регистру
                }
            }
        }

        private int SimpleQuestionCheckWithReturnedCounter(Question question, int currentAnswerNumber, List<List<string>> userQuestionAnswers)
        {
            var rightAnswersCounter = 0;

            foreach (var userAnswer in userQuestionAnswers[currentAnswerNumber])
            {
                if (question.RightAnswers.Contains(userAnswer))
                {
                    rightAnswersCounter++;
                }
            }

            return rightAnswersCounter;
        }

        private int DifficultQuestionCheckWithReturnedCounter(Question question, int currentListNumber, List<List<string>> userQuestionAnswers)
        {
            var currentAnswerNumber = 0; // Используется также в качестве счетчика правильных ответов

            foreach (var answer in question.RightAnswers)
            {
                if (question.RightAnswers.Count != userQuestionAnswers[currentListNumber].Count) return currentAnswerNumber;

                if (answer == userQuestionAnswers[currentListNumber][currentAnswerNumber])
                {
                    currentAnswerNumber++;
                }
                else
                {
                    return currentAnswerNumber;
                }
            }

            return currentAnswerNumber;
        }

        private void CompareRightAnswers(Question question, int rightAnswersCounter)
        {
            if (rightAnswersCounter == question.RightAnswers.Count)
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }
        }
    }
}
