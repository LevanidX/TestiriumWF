using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestTextQuestionPanel : UserControl
    {
        private Question _question;

        public TestTextQuestionPanel()
        {
            InitializeComponent();
        }
        public void SetQuestion(Question question)
        {
            _question = question;
        }

        public void SetQuestionText()
        {
            lblTestTitle.Text = _question.QuestionText;
        }

        public void SetAnswers() { } //метод пустышка

        public List<string> GetUserAnswers()
        {
            List<string> userAnswers = new List<string>
            {
                answerTextBox.Text
            };

            return userAnswers;
        }

        public void SetQuestionPanelForReview()
        {
            answerTextBox.Enabled = false;

            if (!_question.QuestionSettings.IsCaseSensitivityOn)
            {
                answerTextBox.Text = answerTextBox.Text.ToLower();
            }

            if (_question.RightAnswers.Contains(answerTextBox.Text))
            {
                answerTextBox.BackColor = Color.PaleGreen;
                answerTextBox.ForeColor = Color.ForestGreen;
            }
            else
            {
                answerTextBox.BackColor = Color.Salmon;
                answerTextBox.ForeColor = Color.Red;
            }
        }
    }
}
