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
            int countLinks = 0;

            foreach (var question in _test.Questions)
            {
                var customLinkLabel = new CustomLinkLabel();

                customLinkLabel.TextValue = question.QuestionText;
                customLinkLabel.TagValue = countLinks.ToString(); // вместо тэгов использовать ссылки на панели с вопросами
                questionsFlowLayoutPanel.Controls.Add(customLinkLabel);

                countLinks++;
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
