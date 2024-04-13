using System;
using System.Windows.Forms;
using TestiriumWF.TestCompletingFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer;
        private TestCompletor _testCompletor;

        public TestCompletingControl(string xmlTestFile)
        {
            InitializeComponent();
            _testDeserializer = new TestDeserializer(questionsContainerPanel, 
                questionsFlowLayoutPanel, xmlTestFile);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            questionsFlowLayoutPanel.Enabled = true;
            questionsContainerPanel.Controls.Remove(testWelcomeScreen);
            btnEndTest.BringToFront();
        }

        private void TestCompletingControl_Load(object sender, EventArgs e)
        {
            _testDeserializer.CreateTest(testWelcomeScreen);
            questionsFlowLayoutPanel.Enabled = false;

            _testCompletor = new TestCompletor(_testDeserializer.GetTest(), questionsContainerPanel);
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            _testCompletor.EndTest();
        }

        //результат тестирования
        //как то по красоте результат и запомнить как он отвечал на вопросы для отчета
    }
}
