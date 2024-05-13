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

namespace TestiriumWF.CustomPanels
{
    public partial class SequenceQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        AnswersGetting xmlSerialization;

        public SequenceQuestionPanel()
        {
            InitializeComponent();
            xmlSerialization = new AnswersGetting(answersTableLayoutPanel);
        }

        public string GetQuestionText()
        {
            return customQuestionTextBox.GetQuestionTextValue();
        }

        public List<string> GetAnswers() //метод пустышка (необходимо избавиться, или использовать в своих целях)
        {
            return new List<string>();
        }

        public List<string> GetRightAnswers()
        {
            return xmlSerialization.GetAnswers();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            CreateAnswerRow();
        }

        private void CreateAnswerRow()
        {
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();
            CustomClearRowButton customClearRowButton = new CustomClearRowButton(answersTableLayoutPanel.RowCount, answersTableLayoutPanel, false);

            questionsCreating.AddTextAnswerRow(customAnswerTextBox, customClearRowButton, answersTableLayoutPanel);
        }

        private void SequencingQuestionPanel_Load(object sender, EventArgs e)
        {
            answersTableLayoutPanel.RowCount = 0;

            CreateAnswerRow();
            CreateAnswerRow();
        }
    }
}
