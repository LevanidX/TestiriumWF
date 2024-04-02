using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestiriumWF
{
    internal class CustomControlsFunctions
    {
        public void ChangeTextBoxOnClick(TextBox txtBox, string returningValue)
        {
            if (txtBox.Text == returningValue)
            {
                txtBox.Text = string.Empty;
                txtBox.ForeColor = Color.White;
            }
        }

        public void ChangeTextBoxOnLeave(TextBox txtBox, string returningValue)
        {
            if (txtBox.Text == string.Empty)
            {
                txtBox.Text = returningValue;
                txtBox.ForeColor = Color.FromArgb(159, 159, 159);
            }
        }

        public void ChangePasswordTextBoxOnClick(TextBox txtBox, string returningValue, string passwordChar, CheckBox passwordShowCheckBox)
        {
            if (txtBox.Text == returningValue)
            {
                txtBox.Text = string.Empty;
                txtBox.ForeColor = Color.White;
                txtBox.PasswordChar = Convert.ToChar(passwordChar);
                passwordShowCheckBox.Enabled = true;
            }
        }

        public void ChangePasswordTextBoxOnLeave(TextBox txtBox, string returningValue, CheckBox passwordShowCheckBox)
        {
            if (txtBox.Text == string.Empty)
            {
                txtBox.Text = returningValue;
                txtBox.ForeColor = Color.FromArgb(159, 159, 159);
                txtBox.PasswordChar = '\0';
                passwordShowCheckBox.Enabled = false;
            }
        }

        public void ShowPasswordInTextBox(TextBox txtBox, string passwordChar, CheckBox passwordShowCheckBox)
        {
            if (passwordShowCheckBox.Checked)
            {
                txtBox.PasswordChar = '\0';
            }
            else
            {
                txtBox.PasswordChar = Convert.ToChar(passwordChar);
            }
        }

        public void AddSymbolsOnLeave(TextBox txtBox, string symbols)
        {
            try
            {
                if (txtBox.Text.Substring(txtBox.Text.Length - symbols.Length) != symbols)
                {
                    txtBox.Text += ' ' + symbols;
                }
            }
            catch
            {
                txtBox.Text += ' ' + symbols;
            }
        }

        public void RestrictSymbols(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
