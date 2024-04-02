using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomMinuteTextBox : UserControl
    {
        CustomControlsFunctions functions = new CustomControlsFunctions();
        private string _returningValue;
        private int _minuteValue;

        public CustomMinuteTextBox()
        {
            InitializeComponent();
        }

        public int GetMinuteValue()
        {
            return _minuteValue;
        }

        private void minuteTextBox_Leave(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnLeave(minuteTextBox, _returningValue);
            if (minuteTextBox.Text != _returningValue)
            {
                _minuteValue = Convert.ToInt32(minuteTextBox.Text);
            }
        }

        private void minuteTextBox_Click(object sender, EventArgs e)
        {
            functions.ChangeTextBoxOnClick(minuteTextBox, _returningValue);
        }

        private void CustomMinuteTextBox_Load(object sender, EventArgs e)
        {
            _returningValue = ConfigurationManager.AppSettings.Get("DefaultMinuteValue");
            minuteTextBox.Text = _returningValue;
        }

        private void minuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            functions.RestrictSymbols(e);
        }
    }
}
