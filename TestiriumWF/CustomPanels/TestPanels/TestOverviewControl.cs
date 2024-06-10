using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestiriumWF.SqlFunctions;
using TestStructure;
using MySql.Data.MySqlClient;
using System.Data;
using TestiriumWF.CustomPanels.TestPanels;

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
            UpdateValues();

            btnBeginTest.Enabled = _availableTries == 0 ? false : true;
        }

        private void SetAndGetTest()
        {
            _studentsTest = _testDeserializer.GetDeserializedTestById(_studentsTestNumber);
        }

        private void UpdateValues()
        {
            DataRow testValuesRow = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_test_values", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _studentsTestNumber)
            }).Rows[0];

            lblTestTitle.Text = _studentsTest.Name;

            _availableTries = _studentsTest.TestSettings.AllowedTriesQuantity - Convert.ToInt32(testValuesRow[0]);
            lblAvailableTries.Text = $"Доступно попыток - {_availableTries}";

            lblBestResult.Text = (testValuesRow[1] == null) ? 
                "Прохождений не было" : 
                "Лучший результат - " + testValuesRow[1] + "%";

            customDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable("get_completed_student_tests", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_id", _studentsTestNumber)
            }));
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            if (_studentsTest.TestSettings.TestPassword.Value)
            {
                UserConfig.MainMenu.Enabled = false;
                new PasswordChecker(AddTestCompletingControl, _studentsTest.TestSettings.TestPassword.Password).Show();
            }
            else
            {
                AddTestCompletingControl();
            }
        }

        private void AddTestCompletingControl()
        {
            var testCompletingControl = new TestCompletingControl(_studentsTestNumber, 
                (_studentsTest.TestSettings.AllowedTriesQuantity - _availableTries) + 1, UpdateValues);
            this.Parent.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }
    }
}
