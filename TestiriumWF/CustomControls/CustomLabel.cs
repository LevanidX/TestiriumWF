using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomControls
{
    public partial class CustomLabel : UserControl
    {
        public CustomLabel()
        {
            InitializeComponent();
        }

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
    }
}
