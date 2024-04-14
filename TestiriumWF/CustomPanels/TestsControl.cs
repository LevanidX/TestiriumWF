using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.ProgrammWindows;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TestiriumWF.CustomPanels
{
    public partial class TestsControl : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private string _currentCourseId;
        CustomDataGridView testsDataGridView;

        public TestsControl()
        {
            InitializeComponent();

            testsDataGridView = new CustomDataGridView(testsPanel, this);
        }

        private void TestsControl_Load(object sender, EventArgs e)
        {
            if (UserConfig.IsTeacher)
            {
                TeacherLoad();
            }
            else
            {
                StudentLoad();
            }

            RefillPanels();
            AddDataGrid();
        }

        private void TeacherLoad()
        {
            btnCreateTest.Enabled = false;
        }

        private void StudentLoad()
        {
            allCoursesPanel.Controls.Remove(btnAddCourse);
            availableTestsPanel.Controls.Remove(btnCreateTest);
        }

        private void AddDataGrid()
        {
            testsDataGridView.Location = new Point(16, 88);
            availableTestsPanel.Controls.Add(testsDataGridView);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CourseAdding courseAdding = new CourseAdding(this);
            courseAdding.Show();
        }

        public void RefillPanels()
        {
            string selectCoursesTeacherCommand = 
                $"SELECT course_id, " +
                $"CONCAT(course_name, ' - ', class, ' класс') " +
                $"FROM courses " +
                $"WHERE course_user_teacher_number = {UserConfig.UserId}";

            string selectCoursesStudentCommand = 
                $"SELECT course_id, CONCAT(course_name, ' - ', class, ' класс') " +
                $"FROM courses, users_students, students, classes " +
                $"WHERE user_student_id = {UserConfig.UserId} " +
                $"AND user_student_number = student_id " +
                $"AND student_class = class_id " +
                $"AND SUBSTRING(class_name, 1, 2) = class";

            ClearCoursesPanel();

            if (UserConfig.IsTeacher)
            {
                FillCoursesPanel(selectCoursesTeacherCommand);
            }
            else
            {
                FillCoursesPanel(selectCoursesStudentCommand);
            }
            
            FillDataGridWithTests(_currentCourseId);
        }

        private void FillCoursesPanel(string sqlCommand)
        {
            var courses = _mySqlWriter.ExecuteSelectCommand(sqlCommand, GetValue);

            foreach (var course in courses)
            {
                CreateCustomLinkLabel(course[0], course[1]);
            }
        }

        private void ClearCoursesPanel()
        {
            coursesFlowLayoutPanel.Controls.Clear();
        }

        private List<string> GetValue(MySqlDataReader dataReader)
        {
            List<string> items = new List<string>
            {
                dataReader.GetInt32(0).ToString(),
                dataReader.GetString(1)
            };

            return items;
        }

        private void CreateCustomLinkLabel(string courseId, string courseName)
        {
            var customLinkLabel = new CustomLinkLabel();

            customLinkLabel.TagValue = courseId;
            customLinkLabel.TextValue = courseName;
            customLinkLabel.AddEventClick(LinkLabelClick);

            coursesFlowLayoutPanel.Controls.Add(customLinkLabel);
        }

        private void LinkLabelClick(object sender, EventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            _currentCourseId = linkLabel.Tag.ToString();
            FillDataGridWithTests(_currentCourseId);
            btnCreateTest.Enabled = true;
            lblCurrentCourse.Text = linkLabel.Text;
        }

        private void FillDataGridWithTests(string courseId)
        {
            string sqlTeacherCommand = 
                "SELECT test_id," +
                "test_name AS 'Название', " +
                "CONCAT(teacher_surname, ' ', " +
                "SUBSTRING(teacher_name, 1, 1), '.', " +
                "SUBSTRING(teacher_patronymic, 1, 1), '.') AS 'Автор', " +
                "test_creation_date AS 'Дата создания', " +
                "CASE test_is_opened WHEN 1 THEN 'Да' WHEN 0 THEN 'Нет' END AS 'Открыт' " +
                "FROM tests, users_teachers, teachers " +
                "WHERE test_user_teacher_number = user_teacher_id " +
                "AND user_teacher_number = teacher_id " +
                $"AND test_course_number = {Convert.ToInt32(courseId)}";

            string sqlStudentCommand =
                $"SELECT test_id, test_name AS 'Название', " +
                $"CONCAT(teacher_surname, ' ', " +
                $"SUBSTRING(teacher_name, 1, 1), '.', " +
                $"SUBSTRING(teacher_patronymic, 1, 1), '.') AS 'Автор' " +
                $"FROM tests, users_teachers, teachers " +
                $"WHERE test_user_teacher_number = user_teacher_id " +
                $"AND user_teacher_number = teacher_id " +
                $"AND test_is_opened = 1 " +
                $"AND test_course_number = {Convert.ToInt32(courseId)}";

            if (UserConfig.IsTeacher)
            {
                testsDataGridView.SetFillData(sqlTeacherCommand);
            }
            else
            {
                testsDataGridView.SetFillData(sqlStudentCommand);
            }
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreatingControl = new TestCreatingControl(_currentCourseId);
            this.Controls.Add(testCreatingControl);
            testCreatingControl.BringToFront();
        }
    }
}
