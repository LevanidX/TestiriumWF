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
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestSequenceQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestSequenceQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(Question question)
        {
            lblTestTitle.Text = question.QuestionText;
        }

        public void SetAnswers(Question question)
        {
            foreach (var _ in question.Answers)
            {
                var customComboBox = new CustomComboBox()
                {
                    ComboItems = question.Answers.ToArray()
            };
                customComboBox.Size = new Size(717, 25);

                questionsCreating.AddSequenceAnswerRow(customComboBox, 
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
    }
}
