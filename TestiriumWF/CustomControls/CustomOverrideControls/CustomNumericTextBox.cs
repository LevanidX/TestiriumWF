using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestiriumWF.CustomControls.CustomOverrideControls
{
    public partial class CustomNumericTextBox : UserControl
    {
        public CustomNumericTextBox() => InitializeComponent();

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return numericTextBox.Text; }
            set { numericTextBox.Text = value; }
        }

        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
    }
}
