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

        private bool _isEditing;
        private bool _isTeacher;

        private int _personId;
        private int _catalogId;

        public UserEditor(bool isTeacher, int catalogId)
        {
            InitializeComponent();
            TopMost = true;

            _isEditing = false;

            _isTeacher = isTeacher;
            _catalogId = catalogId;
        }

        public UserEditor(bool isTeacher, int personId, int catalogId)
        {
            InitializeComponent();
            TopMost = true;

            _isEditing = true;

            _isTeacher = isTeacher;
            _personId = personId;
            _catalogId = catalogId;
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isTeacher)
                {
                    _mySqlFunctions.CallProcedure(_isEditing ? "update_teacher_data" : "create_new_teacher", new MySqlParameter[]
                    {
                        _isEditing ? new MySqlParameter("person_id", _personId) : new MySqlParameter(),
                        new MySqlParameter("u_name", userNameTextBox.TextValue),
                        new MySqlParameter("u_surname", userSurnameTextBox.TextValue),
                        new MySqlParameter("u_patronymic", userPatronymicTextBox.TextValue),
                        new MySqlParameter("u_birth_date", userBirthdateTextBox.Text),
                        new MySqlParameter("u_speciality", _catalogId),
                        new MySqlParameter("u_login", userLoginTextBox.TextValue),
                        new MySqlParameter("u_password", userPasswordTextBox.TextValue),
                        new MySqlParameter("u_is_admin", Convert.ToByte(isAdminCheckBox.Checked))
                    });
                }
                else
                {
                    _mySqlFunctions.CallProcedure(_isEditing ? "update_student_data" : "create_new_student", new MySqlParameter[]
                    {
                        _isEditing ? new MySqlParameter("person_id", _personId) : new MySqlParameter(),
                        new MySqlParameter("u_name", userNameTextBox.TextValue),
                        new MySqlParameter("u_surname", userSurnameTextBox.TextValue),
                        new MySqlParameter("u_patronymic", userPatronymicTextBox.TextValue),
                        new MySqlParameter("u_birth_date", userBirthdateTextBox.Text),
                        new MySqlParameter("u_class", _catalogId),
                        new MySqlParameter("u_login", userLoginTextBox.TextValue),
                        new MySqlParameter("u_password", userPasswordTextBox.TextValue)
                    });
                }

                MessageBox.Show(_isEditing ? "Данные были успешно обновлены" :
                    "Создание нового пользователя было успешно произведено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nТакой логин уже существует! Выберите другой.");
            }
        }

        private void UserEditor_Load(object sender, EventArgs e)
        {
            if(!_isTeacher)
            {
                isAdminPanel.Visible = false;
                this.Size = new Size(440, 424);
            }

            if (_isEditing)
            {
                var dataTable = _mySqlFunctions.CallProcedureWithReturnedDataTable(_isTeacher ? "get_teacher_data_for_edit" : "get_student_data_for_edit", new MySqlParameter[]
                {
                    new MySqlParameter("person_id", _personId),
                    new MySqlParameter("catalog_id", _catalogId)
                });

                userNameTextBox.TextValue = dataTable.Rows[0][0].ToString();
                userSurnameTextBox.TextValue = dataTable.Rows[0][1].ToString();
                userPatronymicTextBox.TextValue = dataTable.Rows[0][2].ToString();

                var dateTime = (DateTime)dataTable.Rows[0][3];
                userBirthdateTextBox.Text = dateTime.ToString("yyyy/MM/dd");

                userLoginTextBox.TextValue = dataTable.Rows[0][4].ToString();
                userPasswordTextBox.TextValue = dataTable.Rows[0][5].ToString();

                isAdminCheckBox.Checked = _isTeacher ? (bool)dataTable.Rows[0][6] : false;
            }
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }
    }
}
