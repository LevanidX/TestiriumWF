using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;

namespace TestiriumWF.ProgrammWindows
{
    public partial class CourseAdding : Form
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        FormsMessages messages = new FormsMessages();

        public CourseAdding()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _mySqlFunctions.CallProcedure("push_new_course", new MySqlParameter[]
                {
                    new MySqlParameter("c_name", courseNameTextBox.TextValue),
                    new MySqlParameter("c_user_id", UserConfig.UserId),
                    new MySqlParameter("c_class", classComboBox.TextValue)
                });

                MessageBox.Show("Добавление нового курса было произведено успешно!");
            }
            catch (FormatException)
            {
                messages.ShowWarningNoNullAllowedMessage();
            }
        }
    }
}
