using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;

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

        private int _tryNumber;

        public TestChecker(Test studentsTest, int tryNumber, Panel testQuestionPanels) 
        {
            _studentsTest = studentsTest;
            _testQuestionPanels = testQuestionPanels;

            _tryNumber = tryNumber;
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

        /// <summary>
        /// Завершает тестирование
        /// </summary>
        public void EndTest()
        {
            MakeQuestionPanelsSorted();
            CheckAndSaveTestAnswers();
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

        /// <summary>
        /// Проверяет и сохраняет ответы на тестирование
        /// </summary>
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

        /// <summary>
        /// Проверят ответы пользователя на вопросы
        /// </summary>
        /// <param name="question">Вопрос</param>
        /// <param name="currentAnswerNumber">Текущий номер вопроса</param>
        /// <param name="userQuestionAnswers">Ответы пользователя на вопросы</param>
        private void CheckUserQuestionAnswers(Question question, int currentAnswerNumber, List<List<string>> userQuestionAnswers)
        {
            try
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
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Делает текст невосприимчивым к регистру
        /// </summary>
        /// <param name="question">Вопрос</param>
        /// <param name="currentAnswerNumber">Текущий номер вопроса</param>
        /// <param name="userQuestionAnswers">Ответы пользователя на вопросы</param>
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

        /// <summary>
        /// Проверяет вопросы с одним, несколькими и текстовыми ответами
        /// </summary>
        /// <param name="question">Вопрос</param>
        /// <param name="currentAnswerNumber">Текущий номер вопроса</param>
        /// <param name="userQuestionAnswers">Ответы пользователя на вопросы</param>
        /// <returns>Количество правильных ответов</returns>
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

        /// <summary>
        /// Проверяет вопросы на последовательность и сопоставление
        /// </summary>
        /// <param name="question">Вопрос</param>
        /// <param name="currentListNumber">Текущий номер вопроса из списка</param>
        /// <param name="userQuestionAnswers">Ответы пользователя на вопросы</param>
        /// <returns>Количество правильных ответов</returns>
        private int DifficultQuestionCheckWithReturnedCounter(Question question, int currentListNumber, List<List<string>> userQuestionAnswers)
        {
            var currentAnswerNumber = 0; // Используется также в качестве счетчика правильных ответов

            foreach (var answer in question.RightAnswers)
            {
                if (question.RightAnswers.Count != userQuestionAnswers[currentListNumber].Count) return currentAnswerNumber; //нужно ли?

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

        /// <summary>
        /// Сравнивает количество правильных ответов
        /// </summary>
        /// <param name="question">Вопрос</param>
        /// <param name="rightAnswersCounter">Количество правильных ответов</param>
        private void CompareRightAnswers(Question question, int rightAnswersCounter)
        {
            if (rightAnswersCounter == question.RightAnswers.Count)
            {
                question.HasAnsweredCorrectly = true;
            }
        }
    }
}
