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

        private bool _isEdit;
        private string _courseId;

        private Action _updateAction;

        public CourseAdding(Action updateAction)
        {
            InitializeComponent();

            _updateAction = updateAction;
        }

        public CourseAdding(string courseId, Action updateAction)
        {
            InitializeComponent();

            _courseId = courseId;
            _updateAction = updateAction;

            _isEdit = true;
        }

        private void CourseAdding_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                var courseData = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_course_data", 
                    new MySqlParameter[] { new MySqlParameter("c_id", _courseId) }).Rows[0];

                btnSave.Text = "Сохранить изменения";
                courseNameTextBox.TextValue = courseData[0].ToString();
                classComboBox.TextValue = courseData[1].ToString();
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
                _mySqlFunctions.CallProcedure(_isEdit ? "update_course" : "push_new_course", new MySqlParameter[]
                {
                    _isEdit ? new MySqlParameter("c_id", _courseId) : new MySqlParameter(),
                    new MySqlParameter("c_name", courseNameTextBox.TextValue),
                    new MySqlParameter("c_user_id", UserConfig.UserId),
                    new MySqlParameter("c_class", classComboBox.TextValue)
                });

                _updateAction?.Invoke();

                if (_isEdit)
                {
                    MessageBox.Show("Редактирование курса было произведено успешно!");
                }
                else
                {
                    MessageBox.Show("Добавление нового курса было произведено успешно!");
                }
            }
            catch (FormatException)
            {
                messages.ShowWarningNoNullAllowedMessage();
            }
        }
    }
}
