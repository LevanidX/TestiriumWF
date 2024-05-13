using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestiriumWF.TestCreatingFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TextQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        private AnswersGetting _answersGetting;

        public TextQuestionPanel()
        {
            InitializeComponent();

            _answersGetting = new AnswersGetting(answersTableLayoutPanel);
        }

        public string GetQuestionText()
        {
            return customQuestionTextBox.GetQuestionTextValue();
        }

        public List<string> GetRightAnswers()
        {
            if (!caseSensitivityCheckBox.Checked)
            {
                return _answersGetting.GetLowerAnswers();
            }

            return _answersGetting.GetAnswers();
        }

        public List<string> GetAnswers() //метод пустышка (необходимо избавиться, или использовать в своих целях)
        {
            return new List<string>();
        }

        public bool GetQuestionSettings()
        {
            return caseSensitivityCheckBox.Checked;
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
