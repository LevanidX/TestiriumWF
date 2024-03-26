using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class CustomClearRowButton : UserControl
    {
        private int _currentRow;
        private TableLayoutPanel _answersPanel = new TableLayoutPanel();

        public CustomClearRowButton(TableLayoutPanel answersPanel)
        {
            InitializeComponent();

            _answersPanel = answersPanel;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            _currentRow = _answersPanel.GetPositionFromControl(btnCross).Row;
            Console.WriteLine(_currentRow);
        }
    }
}
