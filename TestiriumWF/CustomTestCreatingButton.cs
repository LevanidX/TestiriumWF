using System;
using System.Configuration;
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
    public partial class CustomTestCreatingButton : UserControl
    {
        private UserControl _questionPanel = new UserControl();
        private string _configButtonName;

        public CustomTestCreatingButton(UserControl questionPanel, string configButtonName)
        {
            InitializeComponent();
            _questionPanel = questionPanel;
            _configButtonName = configButtonName;
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            _questionPanel.BringToFront();
        }

        private void CustomTestCreatingButton_Load(object sender, EventArgs e)
        {
            btnQuestion.Text = _configButtonName;
        }
    }
}
