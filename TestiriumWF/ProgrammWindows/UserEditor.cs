using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.ProgrammWindows
{
    public partial class UserEditor : Form
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public UserEditor()
        {
            InitializeComponent();
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            _mySqlFunctions.CallProcedure("create_new_teacher", new MySqlParameter[]
            {
                new MySqlParameter("u_name", userNameTextBox.TextValue),
                new MySqlParameter("u_surname", userSurnameTextBox.TextValue),
                new MySqlParameter("u_patronymic", userPatronymicTextBox.TextValue),
                new MySqlParameter("u_birthdate", userBirthdateTextBox.TextValue),
                new MySqlParameter("u_login", userLoginTextBox.TextValue),
                new MySqlParameter("u_password", userPasswordTextBox.TextValue),
                new MySqlParameter("u_is_admin", Convert.ToByte(isAdminCheckBox.Checked))
            });
        }
    }
}
