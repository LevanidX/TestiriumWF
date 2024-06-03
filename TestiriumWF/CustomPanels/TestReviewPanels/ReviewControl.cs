using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;

namespace TestiriumWF.CustomPanels
{
    public partial class ReviewControl : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private TestDeserializer _testDeserializer = new TestDeserializer();
        TeacherTestReviewer _teacherTestReviewer = new TeacherTestReviewer();

        private string _classNumber;
        private int _testId;

        private string _currentClassId;

        public ReviewControl(string classNumber, int testId)
        {
            InitializeComponent();

            _classNumber = classNumber;
            _testId = testId;
        }

        private void ReviewControl_Load(object sender, EventArgs e)
        {
            FillClassesPanel(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_classes_by_number", new MySqlParameter[]
            {
                new MySqlParameter("class_number", _classNumber)
            }));

            resultsDataGridView.DoubleClickAction += ShowPersonResultPanel;
        }

        private void ShowPersonResultPanel()
        {
            var xmlFile = _testDeserializer.GetDeserializedTestByFile(resultsDataGridView.GetExactValue(1,
                resultsDataGridView.GetSelectedRow()));

            ReviewOverviewControl reviewOverviewControl = new ReviewOverviewControl(xmlFile, 
                resultsDataGridView.GetExactValue(2, resultsDataGridView.GetSelectedRow()));
            this.Parent.Controls.Add(reviewOverviewControl);
            reviewOverviewControl.BringToFront();
        }

        private void FillDataGridWithResults()
        {
            resultsDataGridView.FillData(GetResultDataTable());
            resultsDataGridView.HideColumns(new List<int> { 1 });
        }

        private DataTable GetResultDataTable()
        {
            return _mySqlFunctions.CallProcedureWithReturnedDataTable("get_test_results", new MySqlParameter[]
            {
                new MySqlParameter("class_id", _currentClassId),
                new MySqlParameter("test_id", _testId)
            });
        }

        private void FillClassesPanel(DataTable dataTable)
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

            customLinkLabel.LeftMouseClickAction = () => LinkLabelClick(customLinkLabel);

            classesFlowLayoutPanel.Controls.Add(customLinkLabel);
        }

        private void LinkLabelClick(CustomLinkLabel customLinkLabel)
        {
            _currentClassId = customLinkLabel.TagValue.ToString();
            FillDataGridWithResults();
            btnExportToXlsx.Enabled = true;
            lblCurrentClass.Text = customLinkLabel.TextValue;
        }

        private void btnExportToXlsx_Click(object sender, EventArgs e)
        {
            _teacherTestReviewer.ExportDataTableToXlsx(GetResultDataTable(), lblCurrentClass.Text.Replace('/', '-'),
                $"Отчет по тестированию от {DateTime.Today:dd.MM.yyyy}", 1, 2);
        }
    }
}
