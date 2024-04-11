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

        public void AddSequenceAnswerRow(UserControl comboBox, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(comboBox, 0, answersPanel.RowCount);

            answersPanel.RowCount++;
        }

        public void AddMatchAnswerRow(UserControl definitionLabel, UserControl allignmentComboBox, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(definitionLabel, 1, answersPanel.RowCount);
            answersPanel.Controls.Add(allignmentComboBox, 2, answersPanel.RowCount);

            answersPanel.RowCount++;
        }
    }
}
