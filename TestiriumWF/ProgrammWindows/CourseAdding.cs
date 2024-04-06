using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;

namespace TestiriumWF.ProgrammWindows
{
    public partial class CourseAdding : Form
    {
        MySqlWriter _mySqlWriter = new MySqlWriter();
        FormsMessages messages = new FormsMessages();
        private TestsControl _testsControl;

        public CourseAdding(TestsControl testsControl)
        {
            InitializeComponent();
            _testsControl = testsControl;
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                _mySqlWriter.ExecuteInsertSqlCommand($"" +
                    $"INSERT INTO courses(course_name, course_user_teacher_number, class) " +
                    $"VALUES('{courseNameTextBox.Text}', " +
                    $"{UserConfig.UserId}, " +
                    $"{Convert.ToInt32(gradeComboBox.TextValue)})");

                if (messages.ShowOneMoreCourseAddingMessage() == DialogResult.Yes)
                {
                    courseNameTextBox.Text = string.Empty;
                    gradeComboBox.TextValue = string.Empty;
                }
                else
                {
                    ExitThisForm();
                }
            }
            catch (FormatException)
            {
                messages.ShowWarningNoNullAllowedMessage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitThisForm();
        }

        private void ExitThisForm()
        {
            this.Close();
            _testsControl.RefillCoursesPanel();
        }
    }
}
