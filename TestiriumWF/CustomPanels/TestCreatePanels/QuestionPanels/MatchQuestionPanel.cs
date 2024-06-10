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
    public partial class MatchQuestionPanel : UserControl
    {
        QuestionsCreating questionsCreating = new QuestionsCreating();
        private AnswersGetting _answersGetting;

        public MatchQuestionPanel()
        {
            InitializeComponent();

            _answersGetting = new AnswersGetting(definitionsAndAlignmentsTableLayoutPanel);
        }

        public string GetQuestionText()
        {
            return customQuestionTextBox.GetQuestionTextValue();
        }

        public List<string> GetAnswers()
        {
            return _answersGetting.GetMatchAnswers();
        }

        public List<string> GetRightAnswers()
        {
            return _answersGetting.GetMatchRightAnswers();
        }

        private void CreateRow(TableLayoutPanel answersPanel)
        {
            CustomAnswerTextBox customDefinitionTextBox = new CustomAnswerTextBox();
            CustomAnswerTextBox customAlignmentTextBox = new CustomAnswerTextBox();
            CustomClearRowButton customClearRowButton = new CustomClearRowButton(answersPanel.RowCount, answersPanel, false);

            customDefinitionTextBox.Tag = "DefinitionBox";
            customAlignmentTextBox.Tag = "AlignmentBox";

            customDefinitionTextBox.Size = new Size(350, 23);
            customAlignmentTextBox.Size = new Size(350, 23);

            questionsCreating.AddMatchAnswerRow(customDefinitionTextBox, customAlignmentTextBox, customClearRowButton, definitionsAndAlignmentsTableLayoutPanel);
        }

        private void MatchQuestionPanel_Load(object sender, EventArgs e)
        {
            definitionsAndAlignmentsTableLayoutPanel.RowCount = 0;

            CreateRow(definitionsAndAlignmentsTableLayoutPanel);
            CreateRow(definitionsAndAlignmentsTableLayoutPanel);
        }

        private void btnAddDefinitionAndAlignments_Click(object sender, EventArgs e)
        {
            CreateRow(definitionsAndAlignmentsTableLayoutPanel);
        }

        private void btnAddPhotoVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestCreatingMessages.ShowFutureUpdateMessage();
        }
    }
}
