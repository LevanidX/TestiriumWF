using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls.MainMenuControls;
using TestiriumWF.CustomControls.TestCompleteingControls;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;
using ZstdSharp.Unsafe;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private int _selectedTest;
        private TestsControl _testsControl;
        public bool IsViewingResults;

        public CustomDataGridView(TestsControl testsControl)
        {
            InitializeComponent();

            _testsControl = testsControl;
        }

        public CustomDataGridView()
        {
            InitializeComponent();
        }

        public void FillData(DataTable dataTable)
        {
            customDataGrid.DataSource = dataTable;
            customDataGrid.Columns[0].Visible = false;
            customDataGrid.ClearSelection();
        }

        private void customDataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                customDataGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ChangeMenuStripItemValue()
        {
            var sqlCommand = 
                $"SELECT " +
                $"test_is_opened " +
                $"FROM tests " +
                $"WHERE test_id = {_selectedTest}";
            if (_mySqlWriter.ExecuteSelectScalarCommand(sqlCommand) == "0")
            {
                teachersDataGridMenuStrip.Items[2].Text = "Открыть для прохождения";
                teachersDataGridMenuStrip.Items[2].Tag = "1";
            }
            else
            {
                teachersDataGridMenuStrip.Items[2].Text = "Закрыть для прохождения";
                teachersDataGridMenuStrip.Items[2].Tag = "0";
            }
        }

        private void customDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && customDataGrid.SelectedRows.Count > 0)
            {
                _selectedTest = (int)customDataGrid.Rows[e.RowIndex].Cells[0].Value;

                if (UserConfig.IsTeacher)
                {
                    ChangeMenuStripItemValue();
                    teachersDataGridMenuStrip.Show(MousePosition);
                }
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            customDataGrid.ClearSelection();
        }

        private void completeTestAsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var testCompletingControl = new TestCompletingControl(Convert.ToInt32(_selectedTest));

            _testsControl.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }

        private void customDataGrid_LocationChanged(object sender, EventArgs e)
        {
            customDataGrid.ClearSelection();
        }

        private void dataGridMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void deleteTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlCommand =
                $"DELETE FROM tests " +
                $"WHERE test_id = {_selectedTest}";
                _mySqlWriter.ExecuteNotReadableSqlCommand(sqlCommand);
                _testsControl.RefillPanels();
                customDataGrid.ClearSelection();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Нельзя удалять тестирования, которые проходили учащиеся!" +
                    "\nСначала удалите все прохождения в разделе ОТЧЁТЫ.");
            }        
        }

        private void endOrOpenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlCommand = 
                $"UPDATE tests " +
                $"SET test_is_opened = {teachersDataGridMenuStrip.Items[2].Tag} " +
                $"WHERE test_id = {_selectedTest}";
            _mySqlWriter.ExecuteNotReadableSqlCommand(sqlCommand);
            _testsControl.RefillPanels();
        }

        private void customDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != - 1)
            {
                if (!UserConfig.IsTeacher && !IsViewingResults)
                {
                    _selectedTest = (int)customDataGrid.Rows[e.RowIndex].Cells[0].Value;

                    var testOverviewControl = new TestOverviewControl(_selectedTest);
                    _testsControl.Controls.Add(testOverviewControl);
                    testOverviewControl.BringToFront();
                }
            }
        }
    }
}
