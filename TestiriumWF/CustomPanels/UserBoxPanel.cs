using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;

namespace TestiriumWF.CustomPanels
{
    public partial class UserBoxPanel : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private Action _clickAction;

        public UserBoxPanel() => InitializeComponent();

        public void Instantiate() => SetData(UserConfig.IsTeacher ? "get_teacher_data" : "get_student_data");

        private void SetData(string procedureName)
        {
            _mySqlFunctions.CallProcedureWithReturnedDataTable(procedureName, new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId)
            }).Rows[0].ItemArray.CopyTo(UserConfig.UserData, 0);

            lblUserName.Text = $"{UserConfig.UserData[1]} {UserConfig.UserData[0]} {UserConfig.UserData[2]}";
        }

        public void SetClickAction(Action clickAction) => _clickAction = clickAction;

        private void userBoxTableLayoutPanel_Click(object sender, EventArgs e) => _clickAction?.Invoke();
    }
}
