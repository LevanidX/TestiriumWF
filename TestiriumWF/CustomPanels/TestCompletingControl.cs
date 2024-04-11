using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestStructure;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer;
        private Test _test;

        public TestCompletingControl(string xmlTestFile)
        {
            InitializeComponent();
            _testDeserializer = new TestDeserializer(_test, xmlTestFile);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            CreateTest();
        }

        private void CreateTest() //здесь нужно продолжить создание теста для прохождения
        {
            
        }

        private void TestCompletingControl_Load(object sender, EventArgs e)
        {
            _test = _testDeserializer.DeserializeTest();
            testWelcomeScreen.SetWelcomeScreenValues(_test);

            CreateQuestions();
        }

        private void CreateQuestions()
        {
            int countQuestions = 1;

            foreach (var question in _test.Questions)
            {
                if (question.QuestionType == "ONE_ANSWER_QUESTION")
                {
                    var oneQuestionPanel = new TestOneQuestionPanel();
                    oneQuestionPanel.Location = new Point(16, 16);
                    oneQuestionPanel.SetQuestionText(question.QuestionText);
                    oneQuestionPanel.SetAnswers(question.Answers);
                    questionsContainerPanel.Controls.Add(oneQuestionPanel);
                    var customTestButtonControl = new CustomTestButtonControl(oneQuestionPanel)
                    {
                        TextValue = countQuestions.ToString()
                    };
                    questionsFlowLayoutPanel.Controls.Add(customTestButtonControl);
                    countQuestions++;
                }
            }
        }

        //сделали создание вопросов в флоу лайоут панел
        //сделали заполнение начального экрана
        
        //надо сделать
        //создать 5 панелей для вопросов
        //заполнить их
        //запустить тест для учащегося
        //результат тестирования
        //как то по красоте результат и запомнить как он отвечал на вопросы для отчета
    }
}
