using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;
using System.Globalization;
using TestiriumWF.ProgrammFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class EditUserProfile : UserControl
    {
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        ImageFunctions _imageFunctions = new ImageFunctions();

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

            lblBirthDate.Text = UserConfig.UserData[3].ToString();
            lblBirthDate.Text = lblBirthDate.Text.Substring(0, 10);

            if (UserConfig.UserData[4] == DBNull.Value)
            {
                userPictureBox.Image = Properties.Resources.user_default_img;
            }
            else
            {
                userPictureBox.Image = _imageFunctions.ConvertBytesIntoImage((byte[])UserConfig.UserData[4]);
            }
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                var bytes = _imageFunctions.ConvertImageIntoBytes(_imageFunctions.GetImageStream());

                _mySqlFunctions.CallProcedureWithReturnedDataTable(UserConfig.IsTeacher ? "update_teacher_image" : "update_student_image",
                    new MySqlParameter[]
                    {
                    new MySqlParameter("u_id", UserConfig.UserId),
                    new MySqlParameter("image_file", bytes)
                    });

                userPictureBox.Image = _imageFunctions.ConvertBytesIntoImage(bytes);

                UserConfig.UserBoxPanel.Instantiate();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
