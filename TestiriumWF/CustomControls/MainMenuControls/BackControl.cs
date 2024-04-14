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
        public Action GoBack;

        public BackControl()
        {
            InitializeComponent();
        }

        public void ShowButton(bool isShow)
        {
            btnGoBack.Enabled = isShow;
            btnGoBack.Visible = isShow;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke();
        }
    }
}
