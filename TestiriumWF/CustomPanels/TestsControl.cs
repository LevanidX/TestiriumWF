using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.ProgrammWindows;

namespace TestiriumWF.CustomPanels
{
    public partial class TestsControl : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private string _currentCourse;
        CustomDataGridView testsDataGridView;

        public TestsControl()
        {
            InitializeComponent();
            testsDataGridView = new CustomDataGridView(testsPanel);
        }

        private void TestsControl_Load(object sender, EventArgs e)
        {
            RefillCoursesPanel();
            btnCreateTest.Enabled = false;

            testsDataGridView.Location = new Point(16, 88);
            availableTestsPanel.Controls.Add(testsDataGridView);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CourseAdding courseAdding = new CourseAdding(this);
            courseAdding.Show();
        }

        public void RefillCoursesPanel()
        {
            ClearCoursesPanel();
            FillCoursesPanel();
        }

        private void ClearCoursesPanel()
        {
            coursesFlowLayoutPanel.Controls.Clear();
        }

        private void FillCoursesPanel()
        {
            string selectCoursesCommand = $"SELECT course_id, " +
               $"CONCAT(course_name, ' - ', class, ' класс') " +
               $"FROM courses " +
               $"WHERE course_user_teacher_number = {UserConfig.UserId}";

            var courses = _mySqlWriter.ExecuteSelectCommand(selectCoursesCommand, GetValue);

            foreach (var course in courses)
            {
                CreateCustomLinkLabel(course[0], course[1]);
            }
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
            FillDataGridWithTests(linkLabel.Tag.ToString());
            _currentCourse = linkLabel.Tag.ToString();
            btnCreateTest.Enabled = true;
            lblCurrentCourse.Text = linkLabel.Text;
        }

        private void FillDataGridWithTests(string courseId)
        {
            string sqlCommand = "SELECT test_id," +
                "test_name AS 'Название', " +
                "CONCAT(teacher_surname, ' ', " +
                "SUBSTRING(teacher_name, 1, 1), '.', " +
                "SUBSTRING(teacher_patronymic, 1, 1), '.') AS 'Автор'," +
                "test_creation_date AS 'Дата создания'" +
                "FROM tests, users_teachers, teachers " +
                "WHERE test_user_teacher_number = user_teacher_id " +
                "AND user_teacher_number = teacher_id " +
                $"AND test_course_number = {Convert.ToInt32(courseId)}";

            testsDataGridView.SetFillData(sqlCommand);
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreatingControl = new TestCreatingControl(_currentCourse);
            this.Controls.Add(testCreatingControl);
            testCreatingControl.BringToFront();
        }
    }
}
