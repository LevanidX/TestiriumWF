using System.ComponentModel;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls.CustomOverrideControls
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox() => InitializeComponent();

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
    }
}
