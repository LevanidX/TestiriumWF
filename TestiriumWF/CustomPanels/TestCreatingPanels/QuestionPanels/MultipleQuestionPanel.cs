using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.TestCreatingFunctions;

namespace TestiriumWF
{
    public partial class MultipleQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        AnswersGetting xmlSerialization;

        public MultipleQuestionPanel()
        {
            InitializeComponent();

            xmlSerialization = new AnswersGetting(answersTableLayoutPanel);
        }

        public string GetQuestionText()
        {
            return customQuestionTextBox.GetQuestionTextValue();
        }

        public List<string> GetAnswers()
        {
            return xmlSerialization.GetAnswers();
        }

        public List<string> GetRightAnswers()
        {
            return xmlSerialization.GetRightAnswersCheckBox();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            CreateAnswerRow();
        }

        private void CreateAnswerRow()
        {
            CheckBox checkBox = new CheckBox();
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();
            CustomClearRowButton customClearRowButton = new CustomClearRowButton(answersTableLayoutPanel.RowCount, answersTableLayoutPanel);

            questionsCreating.AddTickAnswerRow(checkBox, customAnswerTextBox, customClearRowButton, answersTableLayoutPanel);
        }

        private void MultipleQuestionPanel_Load(object sender, EventArgs e)
        {
            answersTableLayoutPanel.RowCount = 0;

            CreateAnswerRow();
            CreateAnswerRow();
        }
    }
}
