using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestiriumWF.CustomControls
{
    public partial class CustomLinkLabel : UserControl
    {
        public CustomLinkLabel()
        {
            InitializeComponent();
        }

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return linkLabel.Text; }
            set 
            { 
                linkLabel.Text = value;
                SetLabelFitToText();
            }
        }

        [Description("Sets Tag"), Category("Data")]
        public string TagValue
        {
            get => linkLabel.Tag.ToString();
            set => linkLabel.Tag = value;
        }

        private void SetLabelFitToText()
        {
            linkLabel.AutoSize = true;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void AddEventClick(EventHandler<EventArgs> action)
        {
            linkLabel.Click += new EventHandler(action);
        }
    }
}
