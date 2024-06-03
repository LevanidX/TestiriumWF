using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace TestiriumWF.CustomControls.CustomOverrideControls
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox() => InitializeComponent();

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get => textBox.Text = string.Empty;
            set => textBox.Text = value;
        }
    }
}
