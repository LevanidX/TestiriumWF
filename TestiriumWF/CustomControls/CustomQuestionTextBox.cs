using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class CustomQuestionTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _returningValue;
        private string _questionTextValue;

        public CustomQuestionTextBox()
        {
            InitializeComponent();
        }

        public string GetQuestionTextValue()
        {
            return _questionTextValue;
        }

        private void questionTxtBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(questionTxtBox, _returningValue);
        }

        private void CustomQuestionTextBox_Load(object sender, EventArgs e)
        {
            _returningValue = ConfigurationManager.AppSettings.Get("QuestionBoxText");
            questionTxtBox.Text = _returningValue;
        }

        private void questionTxtBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(questionTxtBox, _returningValue);
            _questionTextValue = questionTxtBox.Text;
        }
    }
}
