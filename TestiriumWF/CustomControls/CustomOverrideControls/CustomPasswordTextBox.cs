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

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            functions.ShowPasswordInTextBox(passwordTextBox, _passwordChar, showPasswordCheckBox);
        }
    }
}
