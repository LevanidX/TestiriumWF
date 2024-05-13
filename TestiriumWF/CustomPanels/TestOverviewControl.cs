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

        private int _selectedTest;
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private Test _studentsTest;
        TestDeserializer _testDeserializer = new TestDeserializer();
        private int _availableTries;

        public TestOverviewControl(int selectedTest)
        {
            InitializeComponent();

            _selectedTest = selectedTest;
        }

        private void TestOverviewControl_Load(object sender, EventArgs e)
        {
            GetTest();
            FillDataGrid();
            FillLabelValues();

            if (_availableTries == 0)
            {
                btnBeginTest.Enabled = false;
            }
        }

        //итак, осталось сделать норм навигацию
        //проверить, что все сохраняется нормально и работает без ошибок
        //отчеты и создание пользователей на потом

        private void GetTest()
        {
            _studentsTest = _testDeserializer.GetDeserializedTest(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_test_file", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_num", _selectedTest)
            }).Rows[0][0].ToString());
        }

        private void FillDataGrid()
        {
            customDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_tests", new MySqlParameter[] 
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _selectedTest)
            }));
            customDataGridView.IsViewingResults = true;
        }

        private void FillLabelValues()
        {
            DataRow testValuesRow = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_test_values", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _selectedTest)
            }).Rows[0];

            lblTestTitle.Text = _studentsTest.Name;

            _availableTries = _studentsTest.TestSettings.AllowedTriesQuantity - Convert.ToInt32(testValuesRow[0]);
            lblAvailableTries.Text = $"Доступно попыток - {_availableTries}";

            if (testValuesRow[1] == DBNull.Value)
            {
                lblBestResult.Text = $"Прохождений не было";
            }
            else
            {
                lblBestResult.Text = $"Лучший результат - {testValuesRow[1]}%";
            }
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            string xmlFile = _mySqlWriter.ExecuteSelectScalarCommand(
                $"SELECT test_file " +
                $"FROM tests " +
                $"WHERE test_id = {_selectedTest}");

            var testCompletingControl = new TestCompletingControl(xmlFile, _selectedTest);
            this.Parent.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }
    }
}
