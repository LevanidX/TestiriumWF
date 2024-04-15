using System;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;
using TestStructure;

namespace TestiriumWF.CustomControls.TestCompleteingControls
{
    public partial class TestOverviewControl : UserControl
    {
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
            SetTest();
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

        private void SetTest() //крч это не нужно, не будем показывать оценку лучшую, ток попытки оставшиеся
        {
            _studentsTest = _testDeserializer.GetDeserializedTest(_mySqlWriter.ExecuteSelectScalarCommand(
                $"SELECT completed_test_file " +
                $"FROM completed_tests " +
                $"WHERE completed_test_number = {_selectedTest} " +
                $"AND completed_test_user_student_number = {UserConfig.UserId} " +
                $"AND ")); //
        }

        private void FillDataGrid()
        {
            var sqlCommand =
                    $"SELECT completed_test_id, " +
                    $"completed_test_try_number AS 'Номер попытки', " +
                    $"completed_test_date_of_completion AS 'Дата и время прохождения', " +
                    $"completed_test_mark_value AS 'Оценка' " +
                    $"FROM completed_tests " +
                    $"WHERE completed_test_user_student_number = {UserConfig.UserId} " +
                    $"AND completed_test_number = {_selectedTest}";

            customDataGridView.FillData(sqlCommand);
            customDataGridView.IsViewingResults = true;
        }

        private void FillLabelValues()
        {
            lblTestTitle.Text = _studentsTest.Name;

            int triesCount = Convert.ToInt32(_mySqlWriter.ExecuteSelectScalarCommand(
                $"SELECT COUNT(*) " +
                $"FROM completed_tests " +
                $"WHERE completed_test_user_student_number = {UserConfig.UserId} " +
                $"AND completed_test_number = {_selectedTest}"));

            _availableTries = _studentsTest.TestSettings.AllowedTriesQuantity - triesCount;
            lblAvailableTries.Text = $"Доступно попыток - {_availableTries}";

            var bestResult = _studentsTest.FinalMark.MarkPercentageResult;

            lblBestResult.Text = $"Лучший результат - {bestResult}%";
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
