using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.ProgrammFunctions
{
    internal class UserFunctions
    {
        private SHA256Hash _sha256Hash = new SHA256Hash();
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public bool UserLogin(string procedureName, string login, string password)
        {
            try
            {
                var dataRow = _mySqlFunctions.CallProcedureWithReturnedDataTable(procedureName, new MySqlParameter[]
                {
                    new MySqlParameter("user_login", login),
                    new MySqlParameter("user_password", _sha256Hash.HashPassword(login, password))
                }).Rows[0];

                UserConfig.UserId = (int)dataRow[0];
                UserConfig.IsAdmin = UserConfig.IsTeacher ? (bool)dataRow[1] : false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void UserRegistration()
        {

        }

        public void UserUpdateFileds()
        {

        }

        public void UserUpdatePassword()
        {

        }
    }
}
