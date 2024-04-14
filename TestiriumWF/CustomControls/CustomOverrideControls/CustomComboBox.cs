using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestiriumWF.CustomControls
{
    public partial class CustomComboBox : UserControl
    {
        public CustomComboBox()
        {
            InitializeComponent();
        }

        public void SetDataSource(BindingSource bindingSource)
        {
            comboBox.DataSource = bindingSource;
        }

        [Description("Sets collection"), Category("Data")]
        public string[] ComboItems
        {
            get { return comboBox.Items.Cast<object>().Select(x => x.ToString()).ToArray(); }
            set { comboBox.Items.AddRange(value); }
        }

        [Description("Sets text"), Category("Data")]
        public string TextValue
        {
            get { return comboBox.Text; }
            set { comboBox.Text = value; }
        }

        [Description("Sets back color"), Category("Data")]
        public Color BackColorValue
        {
            get { return comboBox.BackColor; }
            set { comboBox.BackColor = value; }
        }

        private void CustomComboBox_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox.Enabled = false;
            comboBox.Enabled = true;
        }
    }
}
