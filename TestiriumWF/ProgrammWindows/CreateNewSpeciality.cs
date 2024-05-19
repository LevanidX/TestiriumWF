using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.ProgrammWindows
{
    public partial class CreateNewSpeciality : Form
    {
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public CreateNewSpeciality()
        {
            InitializeComponent();

            TopMost = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (specialityTextBox.TextValue != string.Empty)
                {
                    _mySqlFunctions.CallProcedure("push_new_speciality", new MySqlParameter[]
                    {
                        new MySqlParameter("s_name", specialityTextBox.TextValue)
                    });
                    MessageBox.Show("Добавление новой специальности было произведено успешно!");
                }
                else
                {
                    MessageBox.Show("Вы не ввели даннные!");
                }
            }
            catch
            {
                MessageBox.Show("Такая специальность уже существует!");
            }
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }
    }
}
