using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class CustomAnswerTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _returningValue;

        public CustomAnswerTextBox()
        {
            InitializeComponent();
        }

        private void answerTextBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(answerTextBox, _returningValue);
        }

        private void answerTextBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(answerTextBox, _returningValue);
        }

        private void CustomAnswerTextBox_Load(object sender, EventArgs e)
        {
            _returningValue = ConfigurationManager.AppSettings.Get("AnswerBoxText");
            answerTextBox.Text = _returningValue;
        }
    }
}
