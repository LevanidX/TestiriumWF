using System.Drawing;
using System.Windows.Forms;

namespace TestiriumWF
{
    internal class QuestionsCreating
    {
        public static UserControl CurrentPanel = new UserControl();
        public static UserControl CurrentButton = new UserControl();

        public void AddTickAnswerRow(Control tickControl, UserControl textBox, UserControl clearRowButton, TableLayoutPanel answersPanel)
        {
            tickControl.Text = string.Empty;
            tickControl.Size = new Size(14, 14);

            answersPanel.Controls.Add(tickControl, 0, answersPanel.RowCount);
            answersPanel.Controls.Add(textBox, 1, answersPanel.RowCount);
            answersPanel.Controls.Add(clearRowButton, 2, answersPanel.RowCount);

            answersPanel.RowCount++;
        }

        public void AddTextAnswerRow(UserControl textBox, UserControl clearRowButton, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(textBox, 1, answersPanel.RowCount);
            answersPanel.Controls.Add(clearRowButton, 2, answersPanel.RowCount);

            answersPanel.RowCount++;
        }

        public void AddMatchAnswerRow(UserControl definitionTextBox, UserControl alignmentTextBox, UserControl clearRowButton, TableLayoutPanel answersPanel)
        {
            answersPanel.Controls.Add(definitionTextBox, 1, answersPanel.RowCount);
            answersPanel.Controls.Add(alignmentTextBox, 2, answersPanel.RowCount);
            answersPanel.Controls.Add(clearRowButton, 3, answersPanel.RowCount);

            answersPanel.RowCount++;
        }
    }
}
