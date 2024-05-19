using System;
using System.Linq;
using System.Windows.Forms;
using TestiriumWF.CustomControls.CustomOverrideControls;

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
            if (CheckValues())
            {
                _testCreator.CreateNewTest(Convert.ToInt32(_currentCourse),
                _testCreator.SerializeEndScreen(markRadioButton, markPanel, nonMarkPercentageTextBox,
                timeLimitedRadioButton, minuteTextBox, passwordRadioButton, passwordTextBox, allowedTriesComboBox));

                MessageBox.Show("Тестирование было успешно создано!");
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private bool CheckValues()
        {
            if ((nonMarkRadioButton.Checked && nonMarkPercentageTextBox.TextValue == string.Empty) ||
                (markRadioButton.Checked && markPanel.Controls.OfType<CustomNumericTextBox>().Any(nTextBox => nTextBox.TextValue == string.Empty)) ||
                (timeLimitedRadioButton.Checked && minuteTextBox.TextValue == string.Empty) ||
                (passwordRadioButton.Checked && passwordTextBox.TextValue == string.Empty) ||
                (allowedTriesComboBox.TextValue == string.Empty))
            {
                return false;
            }

            return true;
        }
    }
}
