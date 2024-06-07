using System;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammWindows;

namespace TestiriumWF
{
    internal class UserConfig
    {
        private const int USER_DATA_SIZE = 5;

        public static int UserId;
        public static bool IsTeacher;
        public static bool IsAdmin;

        public static bool IsTestCreatingStarted;

        public static bool IsTestStarted;
        public static Action SaveTestResultAction;

        public static object[] UserData = new object[USER_DATA_SIZE];

        public static TestiriumMainMenu MainMenu;
        public static LoginForm LoginForm;
        public static UserBoxPanel UserBoxPanel;
    }
}
