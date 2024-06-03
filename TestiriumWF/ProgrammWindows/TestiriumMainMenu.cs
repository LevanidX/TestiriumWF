using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.CustomControls.MainMenuControls;

namespace TestiriumWF.ProgrammWindows
{
    public partial class TestiriumMainMenu : Form
    {
        private TestsControl _testsControl = new TestsControl();
        private UsersControl _usersControl = new UsersControl();

        public TestiriumMainMenu() => InitializeComponent();

        private void btnTests_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(_testsControl);
            _testsControl.BringToFront();
        }

        private void TestiriumMainMenu_Load(object sender, EventArgs e)
        {
            UserConfig.MainMenu = this;

            userBoxPanel.Instantiate();
            userBoxPanel.SetClickAction(UserBoxPanelClick);

            if (!UserConfig.IsAdmin)
            {
                btnUsers.Visible = false;
            }
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(_usersControl);
            _usersControl.BringToFront();
        }

        private void TestiriumMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserConfig.IsTestStarted)
            {
                UserConfig.SaveTestResultAction?.Invoke();
            }
        }
    }
}
