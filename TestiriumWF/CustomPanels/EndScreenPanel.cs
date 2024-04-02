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

        public EndScreenPanel(Panel questionsContainerPanel, WelcomeScreenPanel welcomeScreenPanel)
        {
            InitializeComponent();

            _testCreator = new TestCreator(questionsContainerPanel, welcomeScreenPanel);
        }

        private void btnEndTestCreation_Click(object sender, EventArgs e)
        {
            _testCreator.Create(1, 1, _testCreator.SerializeEndScreen(markRadioButton, markPanel, nonMarkPercentageTextBox,
                timeLimitedRadioButton, minuteTextBox, passwordRadioButton, passwordTextBox));
        }
    }
}
