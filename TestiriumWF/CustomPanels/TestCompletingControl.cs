using System;
using System.Windows.Forms;
using TestiriumWF.TestCompletingFunctions;
using System.Drawing;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.CustomControls.MainMenuControls;
using System.Linq;
using TestiriumWF.CustomControls;
using System.Reflection;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer;
        private TestChecker _testCompletor;
        private TimeControl _timeControl;

        private int _testId;

        public TestCompletingControl(string xmlTestFile, int testId)
        {
            InitializeComponent();

            _testDeserializer = new TestDeserializer(questionsContainerPanel, 
                questionsFlowLayoutPanel, xmlTestFile);
            _testId = testId;
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            questionsFlowLayoutPanel.Enabled = true;
            questionsContainerPanel.Controls.Remove(testWelcomeScreen);
            allQuestionsPanel.Controls.Remove(btnStartTest);
        }

        private void TestCompletingControl_Load(object sender, EventArgs e)
        {
            _testDeserializer.CreateTest(testWelcomeScreen);
            questionsFlowLayoutPanel.Enabled = false;

            _testCompletor = new TestChecker(_testDeserializer.GetTest(), questionsContainerPanel);
            _timeControl = new TimeControl(testWelcomeScreen.GetTime());

            AddTimer();
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            _testCompletor.EndTest();

            CreateTestEndScreen();

            allQuestionsPanel.Enabled = false;
            allQuestionsPanel.Controls.Remove(btnEndTest);

            foreach(var button in questionsFlowLayoutPanel.Controls.OfType<CustomTestButtonControl>())
            {
                button.SetColor();
            }

            SetQuestionPanelsForReview<TestOneQuestionPanel>();
            SetQuestionPanelsForReview<TestMultipleQuestionPanel>();
            SetQuestionPanelsForReview<TestTextQuestionPanel>();
            SetQuestionPanelsForReview<TestSequenceQuestionPanel>();
            SetQuestionPanelsForReview<TestMatchQuestionPanel>();
        }

        private void SetQuestionPanelsForReview<TestQuestionPanel>()
        {
            var SetQuestionPanelForReviewMethod = typeof(TestQuestionPanel).GetMethod("SetQuestionPanelForReview",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

            foreach (var questionPanel in questionsContainerPanel.Controls.OfType<TestQuestionPanel>())
            {
                SetQuestionPanelForReviewMethod.Invoke(questionPanel, null);
            }
        }

        private void AddTimer()
        {
            if (_testDeserializer.GetTest().TestSettings.TimeLimitedTest.Value)
            {
                allQuestionsPanel.Controls.Add(_timeControl);
                _timeControl.Location = new Point(8, 312);
            }
            else
            {
                questionsFlowLayoutPanel.Size = new Size(168, 424);
            }
        }

        private void CreateTestEndScreen()
        {
            var testEndScreen = new TestEndScreen(_testDeserializer.GetTest(), _testId, _testCompletor.GetOverallScore(), allQuestionsPanel);
            questionsContainerPanel.Controls.Add(testEndScreen);
            testEndScreen.Location = new Point(16, 16);
            testEndScreen.BringToFront();
        }
    }
}
