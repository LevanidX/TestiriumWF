using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class OneQuestionPanel : UserControl
    {
        private int _count = 2;

        public OneQuestionPanel()
        {
            InitializeComponent();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = new RadioButton();
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();

            radioButton.Text = String.Empty;
            radioButton.Size = new Size(14, 14);

            answersTableLayoutPanel.RowCount++;

            answersTableLayoutPanel.Controls.Add(radioButton, 0, _count);
            answersTableLayoutPanel.Controls.Add(customAnswerTextBox, 1, _count);

            _count++;
        }

        private void OneQuestionPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
