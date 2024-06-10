using System;
using System.Linq;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class CustomClearRowButton : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();

        private TableLayoutPanel _answersPanel = new TableLayoutPanel();
        private int _currentRow;
        private bool _isTextAnswer;

        public CustomClearRowButton(int currentRow, TableLayoutPanel answersPanel)
        {
            InitializeComponent();

            _currentRow = currentRow;
            _answersPanel = answersPanel;
        }

        public CustomClearRowButton(int currentRow, TableLayoutPanel answersPanel, bool isTextAnswer)
        {
            InitializeComponent();

            _currentRow = currentRow;
            _answersPanel = answersPanel;
            _isTextAnswer = isTextAnswer;
        }

        public CustomClearRowButton()
        {
            InitializeComponent();
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            if ((_answersPanel.RowCount > 2 && !_isTextAnswer) || (_answersPanel.RowCount > 1 && _isTextAnswer))
            {
                RemoveExactRow(_answersPanel, _currentRow);
                UpdateRows();
            }
            else
            {
                TestCreatingMessages.ShowWarningDeleteAnswersMessage();
            }
        }

        private void UpdateRows()
        {
            int count = 0;

            foreach(CustomClearRowButton answer in _answersPanel.Controls.OfType<CustomClearRowButton>())
            {
                answer._currentRow = count;
                count++;
            }
        }

        private void RemoveExactRow(TableLayoutPanel answersPanel, int deletingRow)
        {
            if (deletingRow >= answersPanel.RowCount)
            {
                return;
            }

            for (int i = 0; i < answersPanel.ColumnCount; i++)
            {
                var control = answersPanel.GetControlFromPosition(i, deletingRow);
                answersPanel.Controls.Remove(control);
            }

            for (int i = deletingRow + 1; i < answersPanel.RowCount; i++)
            {
                for (int j = 0; j < answersPanel.ColumnCount; j++)
                {
                    var control = answersPanel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        answersPanel.SetRow(control, i - 1);
                    }
                }
            }

            var removeStyle = answersPanel.RowCount - 1;

            if (answersPanel.RowStyles.Count > removeStyle)
                answersPanel.RowStyles.RemoveAt(removeStyle);

            answersPanel.RowCount--;
        }
    }
}
