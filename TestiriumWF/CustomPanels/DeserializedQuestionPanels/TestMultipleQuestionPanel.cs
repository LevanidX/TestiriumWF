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

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestMultipleQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestMultipleQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(string questionText)
        {
            lblTestTitle.Text = questionText;
        }

        public void SetAnswers(List<string> answers)
        {
            foreach (var answer in answers)
            {
                var checkBox = new CheckBox();
                checkBox.Padding = new Padding(2);
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };
                questionsCreating.AddTickAnswerRow(checkBox, customLabel,
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
    }
}
