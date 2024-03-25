using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class CustomQuestionTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _textBoxValue;

        public CustomQuestionTextBox()
        {
            InitializeComponent();
        }

        private void questionTxtBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(questionTxtBox, _textBoxValue);
        }

        private void CustomQuestionTextBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(questionTxtBox, _textBoxValue);
        }

        private void CustomQuestionTextBox_Load(object sender, EventArgs e)
        {
            _textBoxValue = ConfigurationManager.AppSettings.Get("QuestionBoxText");
            questionTxtBox.Text = _textBoxValue;
        }
    }
}
