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
    public partial class TestMatchQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestMatchQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(Question question)
        {
            lblTestTitle.Text = question.QuestionText;
        }

        public void SetAnswers(Question question)
        {
            foreach (var answer in question.Answers)
            {
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };

                var customComboBox = new CustomComboBox()
                {
                    ComboItems = question.RightAnswers.ToArray()
                };

                customComboBox.Size = new Size(360, 23);

                questionsCreating.AddMatchAnswerRow(customLabel, customComboBox,
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
    }
}
