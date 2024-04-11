using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomPercentageTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _returningValue;
        private int _percentageValue;

        public CustomPercentageTextBox()
        {
            InitializeComponent();
        }

        public int GetPercentageValue()
        {
            return _percentageValue;
        }

        private void percentageTextBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(percentageTextBox, _returningValue);
        }

        private void percentageTextBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(percentageTextBox, _returningValue);
            if (percentageTextBox.Text !=  _returningValue)
            {
                _percentageValue = Convert.ToInt32(percentageTextBox.Text);
            }
        }

        private void CustomPercentageTextBox_Load(object sender, EventArgs e)
        {
            _returningValue = ConfigurationManager.AppSettings.Get("DefaultPercentageValue");
            percentageTextBox.Text = _returningValue;
        }

        private void percentageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            functions.RestrictSymbols(e);
        }
    }
}
