using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls.MainMenuControls
{
    public partial class BackControl : UserControl
    {
        private Control _removableControl;
        private Control _parentControl;

        public BackControl(Control removableControl, Control parentControl)
        {
            InitializeComponent();

            _removableControl = removableControl;
            _parentControl = parentControl;
        }

        public void InitializeBackControlFromTestsControl()
        {
            _parentControl.Parent.Parent.Controls.Add(this);
            this.Location = new Point(0, 72); //хард код
            this.BringToFront();
        }

        public void InitializeBackControlFromMainMenu()
        {
            _parentControl.Controls.Add(this);
            this.Location = new Point(0, 72); //хард код
            this.BringToFront();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _removableControl.Parent.Controls.Remove(_removableControl);
            this.Parent.Controls.Remove(this);
        }
    }
}
