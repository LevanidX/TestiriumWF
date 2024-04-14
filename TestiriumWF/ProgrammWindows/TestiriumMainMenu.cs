using System;
using System.Windows.Forms;
using System.Drawing;
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
            testsControl.Location = new Point(64, 0);
            containerPanel.Controls.Add(testsControl);
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TestiriumMainMenu_Load(object sender, EventArgs e)
        {
            UserConfig.MainMenu = this;
            userBoxPanel.SetValues();
        }
    }
}
