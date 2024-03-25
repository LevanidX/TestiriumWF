using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
