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
    public partial class TestMatchQuestionPanel : UserControl
    {
        TestQuestionsCreating _testQuestionsCreating = new TestQuestionsCreating();
        TestRandomiser _testRandomiser = new TestRandomiser();
        private Question _question;

        public TestMatchQuestionPanel()
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
            foreach (var answer in _question.Answers)
            {
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };

                var customComboBox = new CustomComboBox()
                {
                    ComboItems = _testRandomiser.MixAnswers(_question.RightAnswers).ToArray()
                };

                customComboBox.Size = new Size(360, 23);

                _testQuestionsCreating.AddMatchAnswerRow(customLabel, customComboBox,
                    definitionsAndAlignmentsTableLayoutPanel);
            }
        }

        public List<string> GetUserAnswers()
        {
            List<string> answers = new List<string>();

            foreach (var customComboBox in definitionsAndAlignmentsTableLayoutPanel.Controls.OfType<CustomComboBox>())
            {
                answers.Add(customComboBox.TextValue);
            }

            return answers;
        }

        public void SetQuestionPanelForReview()
        {
            var curIndex = 0;

            foreach (var CB in definitionsAndAlignmentsTableLayoutPanel.Controls.OfType<CustomComboBox>())
            {
                if (CB.TextValue == _question.RightAnswers[curIndex])
                {
                    CB.BackColorValue = Color.PaleGreen;
                }
                else
                {
                    CB.BackColorValue = Color.Salmon;
                }
                curIndex++;

                CB.Enabled = false;
            }
        }
    }
}
