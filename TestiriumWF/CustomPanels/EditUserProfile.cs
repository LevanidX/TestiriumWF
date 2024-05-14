using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;

namespace TestiriumWF.CustomPanels
{
    public partial class EditUserProfile : UserControl
    {
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public EditUserProfile()
        {
            InitializeComponent();
        }

        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            if (UserConfig.IsTeacher)
            {
                CheckAndChangePassword("check_user_teacher_password", "change_user_teacher_password");
            }
            else
            {
                CheckAndChangePassword("check_user_student_password", "change_user_student_password");
            }
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
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Изначальный пароль неверный!");
            }
        }
    }
}
