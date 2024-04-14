using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls.MainMenuControls;
using TestiriumWF.CustomPanels;
using TestiriumWF.ProgrammWindows;
using ZstdSharp.Unsafe;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private int _selectedRow;
        private int _selectedTest;
        private Panel _container;
        private TestsControl _testsControl;

        public CustomDataGridView(Panel container, TestsControl testsControl)
        {
            InitializeComponent();

            _container = container;
            _testsControl = testsControl;
        }

        public void SetFillData(string sqlCommand)
        {
            customDataGrid.DataSource = _mySqlWriter.ExecuteFillData(sqlCommand);
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
                dataGridMenuStrip.Items[2].Text = "Открыть для прохождения";
                dataGridMenuStrip.Items[2].Tag = "1";
            }
            else
            {
                dataGridMenuStrip.Items[2].Text = "Закрыть для прохождения";
                dataGridMenuStrip.Items[2].Tag = "0";
            }
        }

        private void customDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && customDataGrid.SelectedRows.Count > 0)
            {
                _selectedRow = e.RowIndex;
                _selectedTest = (int)customDataGrid.Rows[_selectedRow].Cells[0].Value;

                ChangeMenuStripItemValue();

                dataGridMenuStrip.Show(MousePosition);
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            customDataGrid.ClearSelection();
        }

        private void completeTestAsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlCommand = 
                $"SELECT test_file " +
                $"FROM tests " +
                $"WHERE test_id = {_selectedTest}";

            var xmlTestFile = _mySqlWriter.ExecuteSelectScalarCommand(sqlCommand);

            var testCompletingControl = new TestCompletingControl(xmlTestFile, Convert.ToInt32(_selectedTest));

            _container.Parent.Parent.Controls.Add(testCompletingControl);
            testCompletingControl.Location = new Point(64, 0);
            testCompletingControl.BringToFront();

            CreateBackControl(testCompletingControl);
        }

        private void CreateBackControl(TestCompletingControl control)
        {
            var backControl = new BackControl();
            this.Parent.Parent.Parent.Parent.Controls.Add(backControl);
            backControl.GoBack += () => BackAction(control, backControl);
            backControl.BringToFront();
            control.SetBackControl(backControl);
        }

        private void BackAction(UserControl control, BackControl backControl)
        {
            control.Parent.Controls.Remove(control);
            backControl.Parent.Controls.Remove(backControl);
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
            var selectedTest = customDataGrid.Rows[_selectedRow].Cells[0].Value;
            var sqlCommand = 
                $"DELETE FROM tests " +
                $"WHERE test_id = {selectedTest}";
            _mySqlWriter.ExecuteNotReadableSqlCommand(sqlCommand);
            _testsControl.RefillPanels();
            customDataGrid.ClearSelection();
        }

        private void endOrOpenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlCommand = 
                $"UPDATE tests " +
                $"SET test_is_opened = {dataGridMenuStrip.Items[2].Tag} " +
                $"WHERE test_id = {_selectedTest}";
            _mySqlWriter.ExecuteNotReadableSqlCommand(sqlCommand);
            _testsControl.RefillPanels();
        }
    }
}
