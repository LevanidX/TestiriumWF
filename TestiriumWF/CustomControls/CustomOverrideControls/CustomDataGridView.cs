using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        public Action DoubleClickAction = () => { };
        public Action RightClickAction = () => { };

        private int _selectedTest;

        private int _selectedRow;

        public CustomDataGridView() => InitializeComponent();

        public int GetSelectedId() => _selectedTest;
        public string GetExactValue(int column, int row) => customDataGrid[column, row].Value.ToString();

        public void HideColumns(List<int> columns) =>
            columns.ForEach(column => customDataGrid.Columns[column].Visible = false);

        public void ShowColumns(List<int> columns) =>
            columns.ForEach(column => customDataGrid.Columns[column].Visible = true);

        public int GetSelectedRow() => _selectedRow;

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
                _selectedRow = e.RowIndex;
                customDataGrid.Rows[e.RowIndex].Selected = true;
                _selectedTest = (int)customDataGrid.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void customDataGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && customDataGrid.SelectedRows.Count > 0) 
            {
                RightClickAction();
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) => 
            customDataGrid.ClearSelection();

        private void customDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != - 1)
            {
                DoubleClickAction();
            }
        }
    }
}
