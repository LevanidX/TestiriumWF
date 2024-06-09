using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TestiriumWF.ProgrammFunctions;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF
{
    public partial class LoginForm : Form
    {
        private UserFunctions _userFunctions = new UserFunctions();

        public LoginForm() => InitializeComponent();

        private void LoginForm_Load(object sender, EventArgs e) => UserConfig.LoginForm = this;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserConfig.IsTeacher = isTeacherCheckBox.Checked;

            var hasConfirmedLogin = _userFunctions.UserLogin(UserConfig.IsTeacher ?
                "check_teacher_login" :
                "check_student_login",
                loginTextBox.Text, passwordTextBox.Text);

            if (hasConfirmedLogin)
            {
                this.Hide();
                new TestiriumMainMenu().Show();
            }
            else
            {
                UserMessages.ShowWrongLoginOrPasswordMessage();
            }
        }

        private void btnExitProgramm_Click(object sender, EventArgs e) => Application.Exit();
    }
}
