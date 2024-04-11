using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestiriumWF.TestCompletingFunctions;
using TestStructure;

namespace TestiriumWF
{
    internal class TestDeserializer
    {
        MySqlWriter mySqlWriter = new MySqlWriter();
        private TestCompletor _testCompletor;

        private Test _studentsTest = new Test();

        private string _xmlTestFile;
        private Panel _questionsPanel;
        private FlowLayoutPanel _questionButtonsPanel;

        private int _questionsCount = 1; //номер вопроса отображаемый на кнопке


        private List<string> _userRadioButtonAnswers = new List<string>();
        private List<List<string>> _userCheckBoxAnswers = new List<List<string>>();
        private float _overallScore = 0; //итоговый результат (по хорошему бы это все зарефакторить)
        private float _scoreSummer; //изменяемое значение получаемое путем деления 100 на кол во вопросов

        public TestDeserializer(Panel questionsPanel, 
            FlowLayoutPanel questionButtonsPanel, string xmlTestFile)
        {
            _questionsPanel = questionsPanel;
            _questionButtonsPanel = questionButtonsPanel;
            _xmlTestFile = xmlTestFile;
            _testCompletor = new TestCompletor(_studentsTest, _questionsPanel);
        }

        public void CreateTest(TestWelcomeScreen testWelcomeScreen)
        {
            DeserializeTest();
            testWelcomeScreen.SetWelcomeScreenValues(_studentsTest);
            CreateQuestions();
        }

        public void EndTest()
        {
            _scoreSummer = 100 / (float)_studentsTest.Questions.Count; //это тоже надо запихнуть куда-то в норм место

            CheckRBAnswers();
            CheckCBAnswers();

            Console.WriteLine(_overallScore);
            _overallScore = 0;
            _userCheckBoxAnswers.Clear();
            _userRadioButtonAnswers.Clear();
        }

        private void CheckRBAnswers()
        {
            foreach (var oneQuestionPanel in _questionsPanel.Controls.OfType<TestOneQuestionPanel>()) //получение ответов RADIO
            {
                _userRadioButtonAnswers.Add(oneQuestionPanel.GetUserAnswer());
            }
            _userRadioButtonAnswers.Reverse();

            int currentAnswerNumber = 0; //начало чекинга этих ответов

            foreach (var question in _studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.OneAnswerQuestion)
                {
                    if (question.RightAnswers[0] == _userRadioButtonAnswers[currentAnswerNumber])
                    {
                        _overallScore += _scoreSummer;
                        currentAnswerNumber++;
                    }
                }
            }
        }

        private void CheckCBAnswers() //это работает, но надо рефакторить (займись этим в конце, не парься завтра плиз)
        {
            foreach (var multipleQuestionPanel in _questionsPanel.Controls.OfType<TestMultipleQuestionPanel>())
            {
                _userCheckBoxAnswers.Add(multipleQuestionPanel.GetUserAnswers());
            }
            _userCheckBoxAnswers.Reverse();

            int currentListNum = 0; //начало чекинга этих ответов

            foreach (var question in _studentsTest.Questions)
            {
                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    int currentAnswerNum = 0;
                    int countRightAnswers = 0;

                    foreach (var answer in question.RightAnswers)
                    {
                        if (answer == _userCheckBoxAnswers[currentListNum][currentAnswerNum])
                        {
                            countRightAnswers++;
                        }
                        currentAnswerNum++;
                    }

                    if (countRightAnswers == question.RightAnswers.Count && 
                        question.RightAnswers.Count == _userCheckBoxAnswers[currentListNum].Count)
                    {
                        _overallScore += _scoreSummer;
                        currentListNum++;
                    }
                }
            }
        }

        //остались текстовый чек, матч чек, сиквенс чек
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
                    DeserializeOneAnswerQuestion(question);
                }

                if (question.QuestionType == TestTypes.MultipleAnswerQuestion)
                {
                    DeserializeMultipleAnswerQuestion(question);
                }

                if (question.QuestionType == TestTypes.TextAnswerQuestion)
                {
                    DeserializeTextAnswerQuestion(question);
                }

                if (question.QuestionType == TestTypes.SequenceAnswerQuestion)
                {
                    DeserializeSequenceAnswerQuestion(question);
                }

                if (question.QuestionType == TestTypes.MatchAnswerQuestion)
                {
                    DeserializeMatchAnswerQuestion(question);
                }
            }

            foreach (var questionPanel in _questionsPanel.Controls.OfType<UserControl>())
            {
                questionPanel.Location = new Point(16, 16);
            }
        }

        private void DeserializeOneAnswerQuestion(Question question)
        {
            var oneQuestionPanel = new TestOneQuestionPanel();
            oneQuestionPanel.SetQuestionText(question.QuestionText);
            oneQuestionPanel.SetAnswers(question.Answers);

            AddButtonToPanel(oneQuestionPanel);
        }

        private void DeserializeMultipleAnswerQuestion(Question question)
        {
            var multipleQuestionPanel = new TestMultipleQuestionPanel();
            multipleQuestionPanel.SetQuestionText(question.QuestionText);
            multipleQuestionPanel.SetAnswers(question.Answers);

            AddButtonToPanel(multipleQuestionPanel);
        }

        private void DeserializeTextAnswerQuestion(Question question)
        {
            var textQuestionPanel = new TestTextQuestionPanel();
            textQuestionPanel.SetQuestionText(question.QuestionText);

            AddButtonToPanel(textQuestionPanel);
        }

        private void DeserializeSequenceAnswerQuestion(Question question)
        {
            var sequenceQuestionPanel = new TestSequenceQuestionPanel();
            sequenceQuestionPanel.SetQuestionText(question.QuestionText);
            sequenceQuestionPanel.SetAnswers(question.Answers);

            AddButtonToPanel(sequenceQuestionPanel);
        }

        private void DeserializeMatchAnswerQuestion(Question question)
        {
            var matchQuestionPanel = new TestMatchQuestionPanel();
            matchQuestionPanel.SetQuestionText(question.QuestionText);
            matchQuestionPanel.SetAnswers(question.Answers, question.RightAnswers);

            AddButtonToPanel(matchQuestionPanel);
        }

        private void AddButtonToPanel(UserControl questionPanel)
        {
            _questionsPanel.Controls.Add(questionPanel);
            var customTestButtonControl = new CustomTestButtonControl(questionPanel)
            {
                TextValue = _questionsCount.ToString()
            };
            _questionButtonsPanel.Controls.Add(customTestButtonControl);

            _questionsCount++;
        }
    }
}
