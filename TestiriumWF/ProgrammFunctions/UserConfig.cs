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
        public static int UserId = 0;
        public static string Username = "user";
        public static bool IsTeacher = false;
        public static TestiriumMainMenu MainMenu;
        public static LoginForm LoginForm;
    }
}
