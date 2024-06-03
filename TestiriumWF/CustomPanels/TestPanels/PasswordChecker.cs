using System;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels.TestPanels
{
    public partial class PasswordChecker : Form
    {
        private Action _addControl;
        private string _realPassword;

        public PasswordChecker(Action addControl, string realPassword)
        {
            InitializeComponent();

            _addControl = addControl;
            _realPassword = realPassword;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == _realPassword)
            {
                UserConfig.MainMenu.Enabled = true;
                _addControl?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный пароль!");
            }
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }
    }
}
