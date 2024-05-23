using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomPasswordTextBox : UserControl
    {
        public CustomPasswordTextBox() => InitializeComponent();

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }
    }
}
