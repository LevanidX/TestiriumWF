using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF
{
    public partial class LoginForm : Form
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public LoginForm() => InitializeComponent();

        private void LoginForm_Load(object sender, EventArgs e) => UserConfig.LoginForm = this;

        private void CheckLogin(string procedureName, bool isTeacher)
        {
            try
            {
                UserConfig.IsTeacher = isTeacher;
                var dataRow = _mySqlFunctions.CallProcedureWithReturnedDataTable(procedureName, new MySqlParameter[]
                {
                    new MySqlParameter("user_login", loginTextBox.Text),
                    new MySqlParameter("user_password", passwordTextBox.Text)
                }).Rows[0];

                UserConfig.UserId = (int)dataRow[0];
                UserConfig.IsAdmin = isTeacher ? (bool)dataRow[1] : false;

                new TestiriumMainMenu().Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(
                    "Логин или пароль были введены неверно!\nПовторите попытку.",
                    "Тестириум",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) => CheckLogin(isTeacherCheckBox.Checked 
            ? "check_teacher_login" : "check_student_login", isTeacherCheckBox.Checked);

        private void btnExitProgramm_Click(object sender, EventArgs e) => Application.Exit();
    }
}
