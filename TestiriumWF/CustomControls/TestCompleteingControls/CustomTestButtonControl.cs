using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF.CustomControls
{
    public partial class CustomTestButtonControl : UserControl
    {
        private UserControl _questionPanel;
        private Question _question;

        public CustomTestButtonControl(UserControl questionPanel, Question question)
        {
            InitializeComponent();
            _questionPanel = questionPanel;
            _question = question;
        }

        public void SetColor()
        {
            if (_question.HasAnsweredCorrectly)
            {
                btnQuestionNumber.BackColor = Color.FromArgb(91, 203, 129);
            }
            else
            {
                btnQuestionNumber.BackColor = Color.Red;
            }
        }

        private void btnQuestionNumber_Click(object sender, EventArgs e)
        {
            _questionPanel.BringToFront();
        }

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return btnQuestionNumber.Text; }
            set { btnQuestionNumber.Text = value; }
        }
    }
}
