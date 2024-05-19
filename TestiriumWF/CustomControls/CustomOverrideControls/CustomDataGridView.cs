using System;
using System.Data;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        public Action DataGridDoubleClick = () => { };
        public Action DataGridRightClick = () => { };

        private int _selectedTest;
        public bool IsViewingResults;

        public CustomDataGridView() => InitializeComponent();

        public int GetSelectedId() => _selectedTest;

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
                _selectedTest = (int)customDataGrid.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void customDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && customDataGrid.SelectedRows.Count > 0) 
            {
                DataGridRightClick();
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) => customDataGrid.ClearSelection();

        private void customDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != - 1)
            {
                DataGridDoubleClick();
            }
        }
    }
}
