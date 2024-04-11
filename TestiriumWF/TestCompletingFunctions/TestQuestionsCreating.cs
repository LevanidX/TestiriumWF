using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    internal class TestQuestionsCreating
    {
        public void AddTickAnswerRow(Control tickControl, UserControl label, TableLayoutPanel answersPanel)
        {
            tickControl.Text = string.Empty;
            tickControl.Size = new Size(14, 14);

            answersPanel.Controls.Add(tickControl, 0, answersPanel.RowCount);
            answersPanel.Controls.Add(label, 1, answersPanel.RowCount);

            answersPanel.RowCount++;
        }

        public void AddTextAnswerRow(UserControl textBox, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(textBox, 1, answersPanel.RowCount);

            answersPanel.RowCount++;
        }

        public void AddMatchAnswerRow(UserControl definitionTextBox, UserControl alignmentTextBox, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(definitionTextBox, 1, answersPanel.RowCount);
            answersPanel.Controls.Add(alignmentTextBox, 2, answersPanel.RowCount);

            answersPanel.RowCount++;
        }
    }
}
