using System;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.TestCompletingFunctions;
using TestStructure;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer;

        public TestCompletingControl(string xmlTestFile)
        {
            InitializeComponent();
            _testDeserializer = new TestDeserializer(questionsContainerPanel, 
                questionsFlowLayoutPanel, xmlTestFile);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            questionsFlowLayoutPanel.Enabled = true;
            testWelcomeScreen.Hide();
            btnEndTest.BringToFront();
        }

        private void TestCompletingControl_Load(object sender, EventArgs e)
        {
            _testDeserializer.CreateTest(testWelcomeScreen);
            questionsFlowLayoutPanel.Enabled = false;
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            _testDeserializer.EndTest();
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
