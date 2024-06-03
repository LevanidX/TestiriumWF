using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class TestSequenceQuestionPanel : UserControl
    {
        TestRandomiser _testRandomiser = new TestRandomiser();
        TestQuestionsCreator _testQuestionsCreating = new TestQuestionsCreator();
        private Question _question;

        public TestSequenceQuestionPanel()
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
            foreach (var _ in _question.RightAnswers)
            {
                var customComboBox = new CustomComboBox()
                {
                    ComboItems = _testRandomiser.MixAnswers(_question.RightAnswers).ToArray()
                };
                customComboBox.Size = new Size(717, 25);

                _testQuestionsCreating.AddSequenceAnswerRow(customComboBox, 
                    answersTableLayoutPanel);
            }
        }

        public List<string> GetUserAnswers()
        {
            List<string> userAnswers = new List<string>();

            foreach (var customComboBox in answersTableLayoutPanel.Controls.OfType<CustomComboBox>())
            {
                userAnswers.Add(customComboBox.TextValue);
            }

            return userAnswers;
        }

        public void SetQuestionPanelForReview()
        {
            var curIndex = 0;

            foreach (var CB in answersTableLayoutPanel.Controls.OfType<CustomComboBox>())
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
