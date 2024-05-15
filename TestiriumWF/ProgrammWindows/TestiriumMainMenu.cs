using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.CustomControls.MainMenuControls;

namespace TestiriumWF.ProgrammWindows
{
    public partial class TestiriumMainMenu : Form
    {
        TestsControl testsControl = new TestsControl();

        public TestiriumMainMenu() => InitializeComponent();

        private void btnTests_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(testsControl);
            testsControl.BringToFront();
        }

        private void TestiriumMainMenu_Load(object sender, EventArgs e)
        {
            UserConfig.MainMenu = this;
            userBoxPanel.Instantiate();
            userBoxPanel.SetClickAction(UserBoxPanelClick);
        }

        private void UserBoxPanelClick()
        {
            popUserPanel.Visible = true;
            popUserPanel.BringToFront();
        }

        private void containerPanel_Click(object sender, EventArgs e) => popUserPanel.Visible = false;

        private void topPanel_Click(object sender, EventArgs e) => popUserPanel.Visible = false;

        private void containerPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            var backControl = new BackControl(e.Control, this);
            backControl.InitializeBackControlFromMainMenu();
        }
    }
}
