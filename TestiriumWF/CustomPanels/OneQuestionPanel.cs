using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TestiriumWF.TestCreatingFunctions;

namespace TestiriumWF
{
    public partial class OneQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        AnswersGetting xmlSerialization;

        public OneQuestionPanel()
        {
            InitializeComponent();

            xmlSerialization = new AnswersGetting(answersTableLayoutPanel);
        }

        public string GetQuestionText()
        {
            return questionTextBox.GetQuestionTextValue();
        }

        public List<string> GetAnswers()
        {
            return xmlSerialization.GetAnswers();
        }

        public List<string> GetRightAnswers()
        {
            return xmlSerialization.GetRightAnswersRadioButtons();
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            CreateAnswerRow();
        }

        private void CreateAnswerRow()
        {
            RadioButton radioButton = new RadioButton();
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();
            CustomClearRowButton customClearRowButton = new CustomClearRowButton(answersTableLayoutPanel.RowCount, answersTableLayoutPanel);

            questionsCreating.AddTickAnswerRow(radioButton, customAnswerTextBox, customClearRowButton, answersTableLayoutPanel);
        }

        private void OneQuestionPanel_Load(object sender, EventArgs e)
        {
            answersTableLayoutPanel.RowCount = 0;

            CreateAnswerRow();
            CreateAnswerRow();
        }
    }
}
