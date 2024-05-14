using System;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class EndScreenPanel : UserControl
    {
        private TestCreator _testCreator;
        private string _currentCourse;

        public EndScreenPanel(Panel questionsContainerPanel, WelcomeScreenPanel welcomeScreenPanel, string currentCourse)
        {
            InitializeComponent();

            _testCreator = new TestCreator(questionsContainerPanel, welcomeScreenPanel);
            _currentCourse = currentCourse;
        }

        private void btnEndTestCreation_Click(object sender, EventArgs e)
        {


            _testCreator.CreateNewTest(Convert.ToInt32(_currentCourse), 
                _testCreator.SerializeEndScreen(markRadioButton, markPanel, nonMarkPercentageTextBox, 
                timeLimitedRadioButton, minuteTextBox, passwordRadioButton, passwordTextBox, allowedTriesComboBox));
        }

        //private void CheckValues()
        //{
        //    if (nonMarkRadioButton.Checked && nonMarkPercentageTextBox == string.Empty)
        //    {
                
        //    }
        //}
    }
}
