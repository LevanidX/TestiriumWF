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
    internal class TestCompletor
    {
        private TestCreator _testCreator = new TestCreator();
        private Test _studentsTest;
        private Panel _testQuestionPanels;

        private List<List<string>> _userOneQuestionAnswers = new List<List<string>>();
        private List<List<string>> _userMultipleAnswers = new List<List<string>>();
        private List<List<string>> _userTextAnswers = new List<List<string>>();
        private List<List<string>> _userSequenceAnswers = new List<List<string>>();
        private List<List<string>> _userMatchAnswers = new List<List<string>>();

        private double _overallScore = 0;
        private double _scoreSummer; //изменяемое значение получаемое путем деления 100 на кол во вопросов

        public TestCompletor(Test studentsTest, Panel testQuestionPanels) 
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
            CheckAnswers();
        }

        public double GetOverallScore()
        { 
            return _overallScore;
        }

        /// <summary>
        /// Получает ответы с панелей
        /// </summary>
        /// <typeparam name="TestQuestionPanel">Тип вопроса (UserControl)</typeparam>
        /// <param name="userAnswers">Хранилище ответов пользователя</param>
        private void SaveUserAnswers<TestQuestionPanel>(List<List<string>> userAnswers)
        {
            foreach (var testQuestionPanel in _testQuestionPanels.Controls.OfType<TestQuestionPanel>())
            {
                var GetAnswersMethod = typeof(TestQuestionPanel).GetMethod("GetUserAnswers",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                userAnswers.Add((List<string>)GetAnswersMethod.Invoke(testQuestionPanel, null));
            }
        }

        private void CheckAnswers()
        {
            SaveUserAnswers<TestOneQuestionPanel>(_userOneQuestionAnswers);
            SaveUserAnswers<TestMultipleQuestionPanel>(_userMultipleAnswers);
            SaveUserAnswers<TestTextQuestionPanel>(_userTextAnswers);
            SaveUserAnswers<TestSequenceQuestionPanel>(_userSequenceAnswers);
            SaveUserAnswers<TestMatchQuestionPanel>(_userMatchAnswers);

            int currentOneAnswerNumber = 0;
            int currentMultipleListNumber = 0;
            int currentTextAnswerNumber = 0;
            int currentSequenceListNumber = 0;
            int currentMatchListNumber = 0;

            foreach (var question in _studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.OneAnswerQuestion)
                {
                    CheckOneQuestionAnswers(question, currentOneAnswerNumber);
                    currentOneAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    CheckMultipleAnswers(question, currentMultipleListNumber);
                    currentMultipleListNumber++;
                }

                if (question.QuestionType == TestTypes.TextAnswerQuestion)
                {
                    CheckTextAnswers(question, currentTextAnswerNumber);
                    currentTextAnswerNumber++;
                }

                if (question.QuestionType == TestTypes.SequenceAnswerQuestion)
                {
                    CheckSequenceAnswers(question, currentSequenceListNumber);
                    currentSequenceListNumber++;
                }

                if (question.QuestionType == TestTypes.MatchAnswerQuestion)
                {
                    CheckMatchAnswers(question, currentMatchListNumber);
                    currentMatchListNumber++;
                }
            }
        }

        private void CheckOneQuestionAnswers(Question question, int currentAnswerNumber)
        {
            question.UserAnswers = _userOneQuestionAnswers[currentAnswerNumber];

            if (question.RightAnswers.Count != _userOneQuestionAnswers[currentAnswerNumber].Count) return;

            if (question.RightAnswers.Contains(_userOneQuestionAnswers[currentAnswerNumber][0]))
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }
        }

        //частично правильный ответ (да/нет)
        private void CheckMultipleAnswers(Question question, int currentListNumber)
        {
            question.UserAnswers = _userMultipleAnswers[currentListNumber];

            int currentMultipleAnswerNumber = 0;
            int countRightAnswers = 0;

            foreach (var answerRow in _userMultipleAnswers[currentListNumber])
            {
                if (question.RightAnswers.Count != _userMultipleAnswers[currentListNumber].Count) return;

                if (question.RightAnswers.Contains(answerRow))
                {
                    countRightAnswers++;
                }
                currentMultipleAnswerNumber++;
            }

            if (countRightAnswers == question.RightAnswers.Count)
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }

        }

        private void CheckTextAnswers(Question question, int currentAnswerNumber)
        {
            question.UserAnswers = _userTextAnswers[currentAnswerNumber];

            if (!question.QuestionSettings.IsCaseSensitivityOn)
            {
                _userTextAnswers[currentAnswerNumber][0] = _userTextAnswers[currentAnswerNumber][0].ToLower(); //отменяем чувствительность к регистру
            }

            if (question.Answers.Contains(_userTextAnswers[currentAnswerNumber][0]))
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }
        }

        private void CheckSequenceAnswers(Question question, int currentListNumber) //все окей, но нужно добавить перемешку ответов для пользователя
        {
            question.UserAnswers = _userSequenceAnswers[currentListNumber];

            int currentAnswerNumber = 0;

            foreach (var answer in question.RightAnswers)
            {
                if (question.RightAnswers.Count != _userSequenceAnswers[currentListNumber].Count) return;

                if (answer == _userSequenceAnswers[currentListNumber][currentAnswerNumber])
                {
                    currentAnswerNumber++;
                }
                else
                {
                    return;
                }
            }

            if (question.RightAnswers.Count == currentAnswerNumber)
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }
        }

        //частично правильный ответ (да/нет)
        private void CheckMatchAnswers(Question question, int currentListNumber)
        {
            question.UserAnswers = _userMatchAnswers[currentListNumber];

            int currentAnswerNumber = 0;

            foreach (var answer in question.RightAnswers)
            {
                if (question.RightAnswers.Count != _userMatchAnswers[currentListNumber].Count) return;

                if (answer == _userMatchAnswers[currentListNumber][currentAnswerNumber])
                {
                    currentAnswerNumber++;
                }
                else
                {
                    return;
                }
            }

            if (question.RightAnswers.Count == currentAnswerNumber)
            {
                _overallScore += _scoreSummer;
                question.HasAnsweredCorrectly = true;
            }
        }
    }
}
