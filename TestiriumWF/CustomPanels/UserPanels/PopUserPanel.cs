using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class PopUserPanel : UserControl
    {
        public PopUserPanel()
        {
            InitializeComponent();
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var editUserProfile = new EditUserProfile();
            this.Parent.Controls.Add(editUserProfile);
            editUserProfile.BringToFront();
        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Close();
            UserConfig.LoginForm.Show();
        }
    }
}
