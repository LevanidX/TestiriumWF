using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.ProgrammFunctions;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.ProgrammWindows
{
    public partial class UserEditor : Form
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private ImageFunctions _imageFunctions = new ImageFunctions();
        private SHA256Hash _sha256Hash = new SHA256Hash();

        private byte[] _imageBytes;

        private bool _isEditing;
        private bool _isTeacher;

        private DataTable _userDataTable;

        private string _personId;
        private string _catalogId;

        private string _hashedPassword;
        private bool _isPasswordEmpty;

        public UserEditor(bool isTeacher, string catalogId)
        {
            InitializeComponent();

            _isEditing = false;

            _isTeacher = isTeacher;
            _catalogId = catalogId;
        }

        public UserEditor(bool isTeacher, string personId, string catalogId)
        {
            InitializeComponent();

            _isEditing = true;

            _isTeacher = isTeacher;
            _personId = personId;
            _catalogId = catalogId;
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_imageBytes == null && _isEditing && (byte[])_userDataTable.Rows[0][4] != null)
                {
                    _imageBytes = (byte[])_userDataTable.Rows[0][4];
                }

                if (userPasswordTextBox.TextValue == string.Empty && _isEditing)
                {
                    _isPasswordEmpty = true;
                }
                else if (userPasswordTextBox.TextValue == string.Empty)
                {
                    throw new Exception();
                }

                if (_isTeacher)
                {
                    _mySqlFunctions.CallProcedure(_isEditing ? "update_teacher_data" : "create_new_teacher", new MySqlParameter[]
                    {
                        _isEditing ? new MySqlParameter("person_id", _personId) : new MySqlParameter(),
                        new MySqlParameter("u_name", userNameTextBox.TextValue),
                        new MySqlParameter("u_surname", userSurnameTextBox.TextValue),
                        new MySqlParameter("u_patronymic", userPatronymicTextBox.TextValue),
                        new MySqlParameter("u_birth_date", userBirthdateTextBox.Text),
                        new MySqlParameter("u_image_file", _imageBytes),
                        new MySqlParameter("u_speciality", _catalogId),
                        new MySqlParameter("u_login", userLoginTextBox.TextValue),
                        new MySqlParameter("u_password", _isPasswordEmpty ?
                            _hashedPassword :
                            _sha256Hash.HashPassword(userLoginTextBox.TextValue, userPasswordTextBox.TextValue)),
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
                        new MySqlParameter("u_image_file", _imageBytes),
                        new MySqlParameter("u_class", _catalogId),
                        new MySqlParameter("u_login", userLoginTextBox.TextValue),
                        new MySqlParameter("u_password", _isPasswordEmpty ?
                            _hashedPassword :
                            _sha256Hash.HashPassword(userLoginTextBox.TextValue, userPasswordTextBox.TextValue))
                    });
                }

                if (_isEditing)
                    UserMessages.ShowSuccessEditUserMessage();
                else
                    UserMessages.ShowSuccessAddNewUserMessage();

                UserConfig.UserBoxPanel.Instantiate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SetEditValues();
            }
        }

        private void SetEditValues()
        {
            _userDataTable = _mySqlFunctions.CallProcedureWithReturnedDataTable(_isTeacher ?
                    "get_teacher_data_for_edit" :
                    "get_student_data_for_edit",
                    new MySqlParameter[]
                    {
                        new MySqlParameter("person_id", _personId),
                        new MySqlParameter("catalog_id", _catalogId)
                    });

            userNameTextBox.TextValue = _userDataTable.Rows[0][0].ToString();
            userSurnameTextBox.TextValue = _userDataTable.Rows[0][1].ToString();
            userPatronymicTextBox.TextValue = _userDataTable.Rows[0][2].ToString();

            var dateTime = (DateTime)_userDataTable.Rows[0][3];
            userBirthdateTextBox.Text = dateTime.ToString("yyyy/MM/dd");

            if (_userDataTable.Rows[0][4] == DBNull.Value)
            {
                userPictureBox.Image = Properties.Resources.user_default_img;
            }
            else
            {
                userPictureBox.Image = _imageFunctions.ConvertBytesIntoImage((byte[])_userDataTable.Rows[0][4]);
            }

            userLoginTextBox.TextValue = _userDataTable.Rows[0][5].ToString();

            _hashedPassword = _userDataTable.Rows[0][6].ToString();

            isAdminCheckBox.Checked = _isTeacher ? (bool)_userDataTable.Rows[0][7] : false;
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                _imageBytes = _imageFunctions.ConvertImageIntoBytes(_imageFunctions.GetImageStream());
                userPictureBox.Image = _imageFunctions.ConvertBytesIntoImage(_imageBytes);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
