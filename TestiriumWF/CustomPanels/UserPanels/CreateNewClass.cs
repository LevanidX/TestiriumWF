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
using MySql.Data.MySqlClient;

namespace TestiriumWF.ProgrammWindows
{
    public partial class CreateNewClass : Form
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public CreateNewClass() => InitializeComponent();

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dataTable = (object)_mySqlFunctions.CallProcedureWithReturnedDataTable("check_class_exists", new MySqlParameter[]
                {
                    new MySqlParameter("c_name", classNameTextBox.TextValue),
                    new MySqlParameter("c_year", classYearTextBox.Text)
                }).Rows[0];

                MessageBox.Show("Такой класс уже существует!");
            }
            catch (IndexOutOfRangeException)
            {
                if (classNameTextBox.TextValue != string.Empty || classYearTextBox.Text != string.Empty)
                {
                    _mySqlFunctions.CallProcedure("push_new_class", new MySqlParameter[]
                    {
                        new MySqlParameter("c_name", classNameTextBox.TextValue),
                        new MySqlParameter("c_year", classYearTextBox.Text)
                    });

                    MessageBox.Show("Добавление нового класса было произведено успешно!");
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                }
            }
        }
    }
}
