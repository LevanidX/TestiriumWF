using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;

namespace TestiriumWF.ProgrammWindows
{
    public partial class TestiriumMainMenu : Form
    {
        public TestiriumMainMenu()
        {
            InitializeComponent();
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            var testsControl = new TestsControl();
            containerPanel.Controls.Add(testsControl);
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
