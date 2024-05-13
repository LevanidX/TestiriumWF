using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomControls.MainMenuControls;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TestsControl : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private string _currentCourseId;
        CustomDataGridView testsDataGridView;

        public TestsControl()
        {
            InitializeComponent();

            testsDataGridView = new CustomDataGridView(this);
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
            coursesFlowLayoutPanel.Controls.Clear();

            if (UserConfig.IsTeacher)
            {
                FillCoursesPanel(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_teacher_available_courses", new MySqlParameter[] { 
                    new MySqlParameter("user_id", UserConfig.UserId) }));
            }
            else
            {
                FillCoursesPanel(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_student_available_courses", new MySqlParameter[] {
                    new MySqlParameter("user_id", UserConfig.UserId) }));
            }

            FillDataGridWithTests(_currentCourseId);
        }

        private void FillCoursesPanel(DataTable dataTable)
        {
            foreach (DataRow dt in dataTable.Rows)
            {
                CreateCustomLinkLabel(dt[0].ToString(), dt[1].ToString());
            }
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
            if (UserConfig.IsTeacher)
            {
                testsDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_teacher_tests", new MySqlParameter[] {
                    new MySqlParameter("course_id", Convert.ToInt32(courseId)) }));
            }
            else
            {
                testsDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_student_tests", new MySqlParameter[] {
                    new MySqlParameter("course_id", Convert.ToInt32(courseId)) }));
            }
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreatingControl = new TestCreatingControl(_currentCourseId);
            this.Controls.Add(testCreatingControl);
            testCreatingControl.BringToFront();
        }

        private void TestsControl_ControlAdded(object sender, ControlEventArgs e)
        {
            var backControl = new BackControl(e.Control, this);
            backControl.InitializeBackControlFromTestsControl();
        }
    }
}
