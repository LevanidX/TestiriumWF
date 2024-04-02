using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammWindows;

namespace TestiriumWF
{
    public partial class LoginForm : Form
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckLogin()
        {
            var sCommand = $"SELECT user_teacher_password " +
                $"FROM users_teachers " +
                $"WHERE user_teacher_login='{loginTextBox.Text}' AND " +
                $"user_teacher_password='{passwordTextBox.Text}'";

            return _mySqlWriter.ExecuteCheckSqlCommand(sCommand);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                TestiriumMainMenu testiriumMainMenu = new TestiriumMainMenu(1);
                testiriumMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введены неправильно логин или пароль!");
            }
        }
    }
}
