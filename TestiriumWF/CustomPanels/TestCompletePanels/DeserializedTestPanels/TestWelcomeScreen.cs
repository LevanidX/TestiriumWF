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

        public void SetWelcomeScreenValues(Test studentsTest)
        {
            lblTestTitle.Text = studentsTest.Name;
            lblTestDescription.Text = studentsTest.Description.Text;
        }

        public string GetTime()
        {
            return lblTestTimeLimit.Text;
        }
    }
}
