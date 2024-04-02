using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomPasswordTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _returningValue;
        private string _passwordChar;
        private string _passwordValue;

        public CustomPasswordTextBox()
        {
            InitializeComponent();
        }

        public string GetPasswordValue()
        {
            return _passwordValue;
        }

        private void CustomPasswordTextBox_Load(object sender, EventArgs e)
        {
            _returningValue = ConfigurationManager.AppSettings.Get("DefaultPasswordText");
            _passwordChar = ConfigurationManager.AppSettings.Get("PasswordChar");
            
            passwordTextBox.Text = _returningValue;
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            functions.ChangePasswordTextBoxOnClick(passwordTextBox, _returningValue, _passwordChar, showPasswordCheckBox);
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            functions.ChangePasswordTextBoxOnLeave(passwordTextBox, _returningValue, showPasswordCheckBox);
            _passwordValue = passwordTextBox.Text;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            functions.ShowPasswordInTextBox(passwordTextBox, _passwordChar, showPasswordCheckBox);
        }
    }
}
