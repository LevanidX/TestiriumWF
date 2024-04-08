using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private int _selectedRow;
        private Panel _container;

        public CustomDataGridView(Panel container)
        {
            InitializeComponent();
            _container = container;
        }

        private void CustomDataGridView_Load(object sender, EventArgs e) => customDataGrid.ClearSelection();

        public void SetFillData(string sqlCommand)
        {
            customDataGrid.DataSource = _mySqlWriter.ExecuteFillData(sqlCommand);
            customDataGrid.Columns[0].Visible = false;
        }

        private void customDataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                customDataGrid.Rows[e.RowIndex].Selected = true;
            }
        }

        private void customDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && customDataGrid.SelectedRows.Count > 0)
            {
                dataGridMenuStrip.Show(MousePosition);
                _selectedRow = e.RowIndex;
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            customDataGrid.ClearSelection();
        }

        private void completeTestAsStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTest = customDataGrid.Rows[_selectedRow].Cells[0].Value;

            var sqlCommand = $"SELECT test_file FROM tests WHERE test_id = {selectedTest}";

            var xmlTestFile = _mySqlWriter.ExecuteSelectScalarCommand(sqlCommand);

            var testCompletingControl = new TestCompletingControl(xmlTestFile);

            _container.Controls.Add(testCompletingControl);
            testCompletingControl.BringToFront();
        }
    }
}
