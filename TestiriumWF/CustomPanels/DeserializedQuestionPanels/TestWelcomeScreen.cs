using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestWelcomeScreen : UserControl
    {
        public TestWelcomeScreen()
        {
            InitializeComponent();
        }

        public void SetWelcomeScreenValues(Test test)
        {
            lblTestTitle.Text = test.Name;
            lblTestDescription.Text = test.Description.Text;

            if (test.TestSettings.TimeLimitedTest.Value)
            {
                lblTestTimeLimit.Text = test.TestSettings.TimeLimitedTest.TimeLimit.ToString();
            }
            else
            {
                lblTestTimeLimit.Text = "∞";
            }
        }
    }
}
