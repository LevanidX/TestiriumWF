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

        private Action _updateAction;
        private string _classId;

        private bool _isEditing;


        public CreateNewClass(Action updateAction)
        {
            InitializeComponent();

            _updateAction = updateAction;
        }

        public CreateNewClass(string classId, Action updateAction)
        {
            InitializeComponent();

            _updateAction = updateAction;
            _classId = classId;

            _isEditing = true;
        }

        private void CreateNewClass_Load(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                var classData = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_class_data",
                    new MySqlParameter[] { new MySqlParameter("c_id", _classId) }).Rows[0];

                btnSave.Text = "Сохранить изменения";
                classNameTextBox.TextValue = classData[0].ToString();
                classYearTextBox.Text = classData[1].ToString();
            }
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
                if (_isEditing) throw new IndexOutOfRangeException();

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
                    _mySqlFunctions.CallProcedure(_isEditing ? "update_class" : "push_new_class", new MySqlParameter[]
                    {
                        _isEditing ? new MySqlParameter("c_id", _classId) : new MySqlParameter(),
                        new MySqlParameter("c_name", classNameTextBox.TextValue),
                        new MySqlParameter("c_year", classYearTextBox.Text)
                    });

                    _updateAction?.Invoke();

                    MessageBox.Show(_isEditing ?
                        "Редактирование класса было произведено успешно!" :
                        "Добавление нового класса было произведено успешно!");
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены!");
                }
            }
        }
    }
}
