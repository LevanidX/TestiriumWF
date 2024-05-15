using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammWindows;

namespace TestiriumWF
{
    internal class UserConfig
    {
        private const int USER_DATA_SIZE = 4;

        public static int UserId;
        public static bool IsTeacher;
        public static TestiriumMainMenu MainMenu;
        public static LoginForm LoginForm;
        public static object[] UserData = new object[USER_DATA_SIZE];
    }
}
