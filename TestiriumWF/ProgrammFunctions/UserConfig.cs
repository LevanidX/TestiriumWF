﻿using TestiriumWF.ProgrammWindows;

namespace TestiriumWF
{
    internal class UserConfig
    {
        private const int USER_DATA_SIZE = 4;

        public static int UserId;
        public static bool IsTeacher;
        public static bool IsAdmin;

        public static object[] UserData = new object[USER_DATA_SIZE];

        public static TestiriumMainMenu MainMenu;
        public static LoginForm LoginForm;
    }
}
