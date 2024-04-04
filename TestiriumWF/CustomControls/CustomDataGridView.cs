using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomDataGridView : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();

        public CustomDataGridView()
        {
            InitializeComponent();
        }

        private void CustomDataGridView_Load(object sender, EventArgs e)
        {
            customDataGrid.ClearSelection();
        }

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
            }
        }

        private void customDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            customDataGrid.ClearSelection();
        }
    }
}
