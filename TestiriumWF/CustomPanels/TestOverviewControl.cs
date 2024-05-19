using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.SqlFunctions;
using TestStructure;
using MySql.Data.MySqlClient;
using System.Data;

namespace TestiriumWF.CustomControls.TestCompleteingControls
{
    public partial class TestOverviewControl : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private TestDeserializer _testDeserializer = new TestDeserializer();
        private Test _studentsTest;

        private int _studentsTestNumber;
        private int _availableTries;

        public TestOverviewControl(int studentsTestNumber)
        {
            InitializeComponent();

            _studentsTestNumber = studentsTestNumber;
        }

        private void TestOverviewControl_Load(object sender, EventArgs e)
        {
            SetAndGetTest();
            FillDataGrid();
            FillLabelValues();

            btnBeginTest.Enabled = _availableTries == 0 ? false : true;
        }

        private void SetAndGetTest()
        {
            _studentsTest = _testDeserializer.GetDeserializedTest(_studentsTestNumber);
        }

        private void FillDataGrid()
        {
            customDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_tests", new MySqlParameter[] 
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _studentsTestNumber)
            }));
            customDataGridView.IsViewingResults = true;
        }

        private void FillLabelValues()
        {
            DataRow testValuesRow = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_test_values", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _studentsTestNumber)
            }).Rows[0];

            lblTestTitle.Text = _studentsTest.Name;

            _availableTries = _studentsTest.TestSettings.AllowedTriesQuantity - Convert.ToInt32(testValuesRow[0]);
            lblAvailableTries.Text = $"Доступно попыток - {_availableTries}";

            lblBestResult.Text = (testValuesRow[1] == DBNull.Value) ? "Прохождений не было" : $"Лучший результат - {testValuesRow[1]}%";
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            var testCompletingControl = new TestCompletingControl(_studentsTestNumber, (_studentsTest.TestSettings.AllowedTriesQuantity - _availableTries) + 1);
            this.Parent.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }
    }
}
