using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class WelcomeScreenPanel : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _titleReturningValue;
        private string _descriptionReturningValue;

        public WelcomeScreenPanel()
        {
            InitializeComponent();
        }

        private void testTitleTxtBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(testTitleTxtBox, _titleReturningValue);
        }

        private void WelcomeScreenPanel_Load(object sender, EventArgs e)
        {
            _titleReturningValue = ConfigurationManager.AppSettings.Get("TitleBoxText");
            _descriptionReturningValue = ConfigurationManager.AppSettings.Get("DescriptionBoxText");

            testTitleTxtBox.Text = _titleReturningValue;
            descriptionTestTxtBox.Text = _descriptionReturningValue;
        }

        private void testTitleTxtBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(testTitleTxtBox, _titleReturningValue);
        }

        private void descriptionTestTxtBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(descriptionTestTxtBox, _descriptionReturningValue);
        }

        private void descriptionTestTxtBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(descriptionTestTxtBox, _descriptionReturningValue);
        }
    }
}
