using System;
using System.Windows.Forms;
using TestiriumWF.TestCompletingFunctions;
using System.Drawing;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.CustomControls.MainMenuControls;
using System.Linq;
using TestiriumWF.CustomControls;
using System.Reflection;
using TestStructure;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer = new TestDeserializer();
        private TestCompleteSaver _testCompleteSaver = new TestCompleteSaver();

        private TestCompleteStarter _testCompleteStarter;
        private TestChecker _testCheckerAndSaver;
        private TestReviewer _testReviewer;
        private TestResulter _testResulter;

        //private TimeControl _timeControl;

        private Test _studentsTest;

        private int _studentsTestNumber;
        private int _tryNumber;

        public TestCompletingControl(int studentsTestNumber, int tryNumber)
        {
            InitializeComponent();

            _studentsTestNumber = studentsTestNumber;
            _tryNumber = tryNumber;
        }
        
        public TestCompletingControl(int studentsTestNumber)
        {
            InitializeComponent();

            _studentsTestNumber = studentsTestNumber;
        }

        private void TestCompletingControl_Load(object sender, EventArgs e)
        {
            _studentsTest = _testDeserializer.GetDeserializedTestById(_studentsTestNumber);

            _testCompleteStarter = new TestCompleteStarter(questionsContainerPanel, questionButtonsPanel);
            _testCheckerAndSaver = new TestChecker(_studentsTest, _tryNumber, questionsContainerPanel);
            _testReviewer = new TestReviewer(questionsContainerPanel);
            _testResulter = new TestResulter(_studentsTest);

            testWelcomeScreen.SetWelcomeScreenValues(_studentsTest);
            _testCompleteStarter.CreateTest(_studentsTest);

            questionButtonsPanel.Enabled = false;

            //_timeControl = new TimeControl(testWelcomeScreen.GetTime());
            //AddTimer();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            var dialogResut = MessageBox.Show(
                "Вы уверены, что хотите начать тестирование?",
                "Тестириум",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResut == DialogResult.Yes)
            {
                questionButtonsPanel.Enabled = true;
                questionsContainerPanel.Controls.Remove(testWelcomeScreen);
                testControllerPanel.Controls.Remove(btnStartTest);
                UserConfig.IsTestStarted = true;
                UserConfig.SaveTestResultAction += () => EndTest();
            }
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Вы действительно хотите завершить тестирование?",
                "Тестириум",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                EndTest();
            }
        }

        private void EndTest()
        {
            _testCheckerAndSaver.EndTest();

            testControllerPanel.Enabled = false;
            testControllerPanel.Controls.Remove(btnEndTest);

            questionButtonsPanel.Controls.OfType<CustomTestButtonControl>().ToList().ForEach(button => button.SetColor());

            _testReviewer.ReviewPanels();
            _studentsTest.OverallResult = _testResulter.GetResult();

            if (!UserConfig.IsTeacher)
            {
                _testCompleteSaver.SaveTestInDatabase(_studentsTestNumber, _studentsTest, _tryNumber);
            }

            CreateTestEndScreen();

            UserConfig.IsTestStarted = false;
        }

        private void CreateTestEndScreen()
        {
            var testEndScreen = new TestEndScreen(_studentsTest, testControllerPanel);
            questionsContainerPanel.Controls.Add(testEndScreen);
            testEndScreen.Location = new Point(16, 16);
            testEndScreen.BringToFront();
        }

        //private void AddTimer()
        //{
        //    if (_studentsTest.TestSettings.TimeLimitedTest.Value)
        //    {
        //        testControllerPanel.Controls.Add(_timeControl);
        //        _timeControl.Location = new Point(8, 312);
        //    }
        //    else
        //    {
        //        questionButtonsPanel.Size = new Size(168, 424);
        //    }
        //}
    }
}