using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestiriumWF.TestCreatingFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TextQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        AnswersGetting xmlSerialization;

        public TextQuestionPanel()
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

        public CheckBox GetQuestionSettings()
        {
            return caseSensitivityCheckBox;
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            CreateAnswerRow();
        }

        private void CreateAnswerRow()
        {
            CustomAnswerTextBox customAnswerTextBox = new CustomAnswerTextBox();
            CustomClearRowButton customClearRowButton = new CustomClearRowButton(answersTableLayoutPanel.RowCount, answersTableLayoutPanel, true);

            questionsCreating.AddTextAnswerRow(customAnswerTextBox, customClearRowButton, answersTableLayoutPanel);
        }

        private void TextQuestionPanel_Load(object sender, EventArgs e)
        {
            answersTableLayoutPanel.RowCount = 0;

            CreateAnswerRow();
        }
    }
}
