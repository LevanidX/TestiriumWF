using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace TestiriumWF.CustomPanels
{
    public partial class EditUserProfile : UserControl
    {
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public EditUserProfile() => InitializeComponent();

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            CheckAndChangePassword(UserConfig.IsTeacher ? "check_user_teacher_password" : "check_user_student_password",
                UserConfig.IsTeacher ? "change_user_teacher_password" : "change_user_student_password");
        }

        private void CheckAndChangePassword(string checkProcedureName, string changeProcedureName)
        {
            try
            {
                var value = _mySqlFunctions.CallProcedureWithReturnedDataTable(checkProcedureName, new MySqlParameter[]
                {
                    new MySqlParameter("initial_password", initialPasswordTextBox.TextValue),
                    new MySqlParameter("user_id", UserConfig.UserId)
                }).Rows[0][0];

                _mySqlFunctions.CallProcedure(changeProcedureName, new MySqlParameter[]
                {
                        new MySqlParameter("new_password", newPasswordTextBox.TextValue),
                        new MySqlParameter("user_id", UserConfig.UserId)
                });

                MessageBox.Show("Пароль был успешно изменён.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Изначальный пароль неверный!");
            }
        }

        private void EditUserProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = UserConfig.UserData[0].ToString();
            lblSurname.Text = UserConfig.UserData[1].ToString();
            lblPatronymic.Text = UserConfig.UserData[2].ToString();

            lblBirthDate.Text = UserConfig.UserData[3].ToString(); //формат даты не тот, сейчас (мм.дд.гггг), а надо (дд.мм.гггг)
            lblBirthDate.Text = lblBirthDate.Text.Substring(0, 10);
        }
    }
}
