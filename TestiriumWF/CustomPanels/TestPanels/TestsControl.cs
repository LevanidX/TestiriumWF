using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.CustomControls.MainMenuControls;
using TestiriumWF.CustomControls.TestCompleteingControls;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TestsControl : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        private string _currentCourseId;

        public TestsControl() => InitializeComponent();

        private void TestsControl_Load(object sender, EventArgs e)
        {
            if (UserConfig.IsTeacher)
            {
                testsDataGridView.RightClickAction += () => teachersDataGridMenuStrip.Show(MousePosition);
            }
            else
            {
                allCoursesPanel.Controls.Remove(btnAddCourse);
                availableTestsPanel.Controls.Remove(btnCreateTest);
                testsDataGridView.DoubleClickAction += CreateTestOverviewByID;
            }

            RefillPanels();
        }

        private void CreateTestOverviewByID()
        {
            var testOverviewControl = new TestOverviewControl(testsDataGridView.GetSelectedId());
            this.Controls.Add(testOverviewControl);
            testOverviewControl.BringToFront();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = false;
            new CourseAdding().Show();
        }

        public void RefillPanels()
        {
            coursesFlowLayoutPanel.Controls.Clear();

            FillCoursesPanel(_mySqlFunctions.CallProcedureWithReturnedDataTable(UserConfig.IsTeacher ? 
               "get_teacher_available_courses" : "get_student_available_courses", new MySqlParameter[] { 
                    new MySqlParameter("user_id", UserConfig.UserId) }));

            FillDataGridWithTests(_currentCourseId);
        }

        private void FillCoursesPanel(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                CreateCustomLinkLabel(row[0].ToString(), row[1].ToString());
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
            testsDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable(UserConfig.IsTeacher ? 
                "get_teacher_tests" : "get_student_tests", new MySqlParameter[] 
                {
                    new MySqlParameter("course_id", Convert.ToInt32(courseId)) 
                }));
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            var testCreatingControl = new TestCreatingControl(_currentCourseId);
            this.Controls.Add(testCreatingControl);
            testCreatingControl.BringToFront();
        }

        private void TestsControl_ControlAdded(object sender, ControlEventArgs e) =>
            new BackControl(e.Control, this).InitializeBackControlFromTestsControl();

        private void endOrOpenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mySqlFunctions.CallProcedure("set_test_opened_or_closed", new MySqlParameter[]
            {
                new MySqlParameter("is_open", teachersDataGridMenuStrip.Items[2].Tag),
                new MySqlParameter("test_num", testsDataGridView.GetSelectedId())
            });
            
            RefillPanels();
        }  

        private void completeTestAsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var testCompletingControl = new TestCompletingControl(testsDataGridView.GetSelectedId());

            this.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }

        private void deleteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "ВНИМАНИЕ: При удалении тестирования, прохождения учащихся удалятся! Вы хотите продолжить?",
                "Тестириум",
                MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                _mySqlFunctions.CallProcedure("delete_test", new MySqlParameter[]
                {
                        new MySqlParameter("test_num", testsDataGridView.GetSelectedId())
                });
                RefillPanels();
            }
        }

        private void teachersDataGridMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) => ChangeMenuStripItemValue();

        private void ChangeMenuStripItemValue()
        {
            var isOpened = Convert.ToBoolean(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_test_opened_or_closed", new MySqlParameter[]
            {
                new MySqlParameter("test_num", testsDataGridView.GetSelectedId())
            }).Rows[0][0]);

            teachersDataGridMenuStrip.Items[2].Text = isOpened ? "Закрыть для прохождения" : "Открыть для прохождения";
            teachersDataGridMenuStrip.Items[2].Tag = isOpened ? "0" : "1";
        }

        private void createReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var classNumber = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_class_number", new MySqlParameter[]
            {
                new MySqlParameter("test_id", testsDataGridView.GetSelectedId())
            }).Rows[0][0];

            var reviewControl = new ReviewControl(classNumber.ToString(), testsDataGridView.GetSelectedId());
            this.Controls.Add(reviewControl);
            reviewControl.BringToFront();
        }
    }
}
