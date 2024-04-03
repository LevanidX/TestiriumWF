using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class UserBoxPanel : UserControl
    {
        public UserBoxPanel()
        {
            InitializeComponent();
        }

        private void UserBoxPanel_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserConfig.PersonName;
        }
    }
}
