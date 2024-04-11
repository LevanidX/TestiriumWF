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
    public partial class CustomTestButtonControl : UserControl
    {
        private UserControl _question;

        public CustomTestButtonControl(UserControl question)
        {
            InitializeComponent();
            _question = question;
        }

        private void btnQuestionNumber_Click(object sender, EventArgs e)
        {
            _question.BringToFront();
        }

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return btnQuestionNumber.Text; }
            set { btnQuestionNumber.Text = value; }
        }
    }
}
