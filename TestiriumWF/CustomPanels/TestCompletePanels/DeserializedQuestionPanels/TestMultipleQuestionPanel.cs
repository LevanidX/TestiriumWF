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
using TestiriumWF.TestCreatingFunctions;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestMultipleQuestionPanel : UserControl
    {
        TestRandomiser _testRandomiser = new TestRandomiser();
        TestQuestionsCreator _testQuestionsCreating = new TestQuestionsCreator();
        private Question _question;

        public TestMultipleQuestionPanel()
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

        public void SetAnswers()
        {
            foreach (var answer in _testRandomiser.MixAnswers(_question.Answers))
            {
                var checkBox = new CheckBox();
                checkBox.Padding = new Padding(2);
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };
                _testQuestionsCreating.AddTickAnswerRow(checkBox, customLabel,
                    answersTableLayoutPanel);
            }
        }

        public List<string> GetUserAnswers()
        {
            List<string> answers = new List<string>();

            foreach (var CB in answersTableLayoutPanel.Controls.OfType<CheckBox>())
            {
                if (CB.Checked)
                {
                    var row = answersTableLayoutPanel.GetRow(CB);
                    var customLabel = (CustomLabel)answersTableLayoutPanel.GetControlFromPosition(1, row);
                    answers.Add(customLabel.TextValue);
                }
            }

            return answers;
        }

        public void SetQuestionPanelForReview()
        {
            foreach (var CB in answersTableLayoutPanel.Controls.OfType<CheckBox>())
            {
                if (CB.Checked)
                {
                    var row = answersTableLayoutPanel.GetRow(CB);
                    var customLabel = (CustomLabel)answersTableLayoutPanel.GetControlFromPosition(1, row);

                    if (_question.RightAnswers.Contains(customLabel.TextValue))
                    {
                        customLabel.ForeColorValue = Color.Green;
                    }
                    else
                    {
                        customLabel.ForeColorValue = Color.Red;
                    }
                }
            }

            foreach (var checkBox in answersTableLayoutPanel.Controls.OfType<CheckBox>())
            {
                checkBox.Enabled = false;
            }
        }
    }
}
