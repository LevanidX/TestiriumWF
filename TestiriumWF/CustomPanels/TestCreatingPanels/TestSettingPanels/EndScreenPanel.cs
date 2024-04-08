using System;
using TestStructure;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Mysqlx.Crud;

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
            _testCreator.Create(Convert.ToInt32(_currentCourse), UserConfig.UserId, _testCreator.SerializeEndScreen(markRadioButton, markPanel, nonMarkPercentageTextBox,
                timeLimitedRadioButton, minuteTextBox, passwordRadioButton, passwordTextBox));
        }
    }
}
