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
        private int _count;

        public OneQuestionPanel()
        {
            InitializeComponent();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            AddAnswerRow();
        }

        private void AddAnswerRow()
        {
            RadioButton radioButton = new RadioButton();
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();
            CustomClearRowButton clearRowButton = new CustomClearRowButton(answersTableLayoutPanel);

            radioButton.Text = String.Empty;
            radioButton.Size = new Size(14, 14);

            answersTableLayoutPanel.RowCount++;

            answersTableLayoutPanel.Controls.Add(radioButton, 0, _count);
            answersTableLayoutPanel.Controls.Add(customAnswerTextBox, 1, _count);
            answersTableLayoutPanel.Controls.Add(clearRowButton, 2, _count);

            _count++;
        }

        private void OneQuestionPanel_Load(object sender, EventArgs e)
        {
            AddAnswerRow();
            AddAnswerRow();

            //Займись добавлением datagrid вмето table layout, а то не работает ни черта
            //Надо как-то заменить радиобаттонами, это делается картинками
            //Сделать другие виды вопросов
            //запоминание в xml (хотя-бы частично)
        }
    }
}
