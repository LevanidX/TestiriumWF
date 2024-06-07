using MySql.Data.MySqlClient;
using System;
using System.Data;
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
                testsDataGridView.DoubleClickAction += () => CreateTestOverviewByID();
            }

            LoadForm();
            RefillPanels();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = false;
            new CourseAdding(LoadForm).Show();
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new TestCreatingControl(_currentCourseId));
            UserConfig.IsTestCreatingStarted = true;
        }

        private void TestsControl_ControlAdded(object sender, ControlEventArgs e)
        {
            new BackControl(e.Control, this).InitializeBackControlFromTestsControl();
            e.Control.BringToFront();
        }

        private void endOrOpenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mySqlFunctions.CallProcedure("set_test_opened_or_closed", new MySqlParameter[]
            {
                new MySqlParameter("is_open", teachersDataGridMenuStrip.Items[2].Tag),
                new MySqlParameter("test_num", testsDataGridView.GetSelectedId())
            });

            RefillPanels();
        }

        private void completeTestAsStudentToolStripMenuItem_Click(object sender, EventArgs e) =>
            this.Controls.Add(new TestCompletingControl(testsDataGridView.GetSelectedId()));

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

        private void teachersDataGridMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) =>
            ChangeMenuStripItemValue();

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

            this.Controls.Add(new ReviewControl(classNumber.ToString(), testsDataGridView.GetSelectedId()));
        }

        private void RefillPanels()
        {
            FillCoursesPanel();
            FillDataGridWithTests(_currentCourseId);
        }

        private void LoadForm()
        {
            btnCreateTest.Enabled = false;
            lblCurrentCourse.Text = "Не выбран";
            FillCoursesPanel();
            FillDataGridWithTests("0");
        }

        private void CreateTestOverviewByID() =>
            this.Controls.Add(new TestOverviewControl(testsDataGridView.GetSelectedId()));

        private void FillCoursesPanel() 
        {
            coursesFlowLayoutPanel.Controls.Clear();

            var coursesTable = _mySqlFunctions.CallProcedureWithReturnedDataTable(UserConfig.IsTeacher ?
               "get_teacher_available_courses" : "get_student_available_courses", new MySqlParameter[] {
                    new MySqlParameter("user_id", UserConfig.UserId) });

            foreach (DataRow course in coursesTable.Rows)
                CreateCustomLinkLabel(course[0].ToString(), course[1].ToString());
        }

        private void CreateCustomLinkLabel(string courseId, string courseName)
        {
            var customLinkLabel = new CustomLinkLabel
            {
                TagValue = courseId,
                TextValue = courseName
            };

            customLinkLabel.LeftMouseClickAction = () => LinkLabelClick(customLinkLabel);
            customLinkLabel.DeleteAction = () => DeleteCourse(customLinkLabel);
            customLinkLabel.EditAction = () => EditCourse(customLinkLabel);

            coursesFlowLayoutPanel.Controls.Add(customLinkLabel);
        }

        private void DeleteCourse(CustomLinkLabel customLinkLabel)
        {
            try
            {
                var dialogResult = MessageBox.Show(
                    "ВНИМАНИЕ: Удаление предмета приведёт к удалению всех тестировочных материалов и отчётов!" +
                    "\nВы хотите продолжить?",
                    "Тестириум",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    _mySqlFunctions.CallProcedure("delete_course",
                        new MySqlParameter[] { new MySqlParameter("c_id", customLinkLabel.TagValue) });

                    LoadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCourse(CustomLinkLabel customLinkLabel)
        {
            UserConfig.MainMenu.Enabled = false;
            new CourseAdding(customLinkLabel.TagValue, LoadForm).Show();
        }

        private void LinkLabelClick(CustomLinkLabel customLinkLabel)
        {
            _currentCourseId = customLinkLabel.TagValue.ToString();
            FillDataGridWithTests(_currentCourseId);
            btnCreateTest.Enabled = true;
            lblCurrentCourse.Text = customLinkLabel.TextValue;
        }

        private void FillDataGridWithTests(string courseId)
        {
            testsDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable(UserConfig.IsTeacher ? 
                "get_teacher_tests" : "get_student_tests", new MySqlParameter[] {
                    new MySqlParameter("course_id", Convert.ToInt32(courseId)) }));
        }
    }
}
