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

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestSequenceQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestSequenceQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(string questionText)
        {
            lblTestTitle.Text = questionText;
        }

        public void SetAnswers(List<string> answers)
        {
            string[] answersArray = answers.ToArray();

            foreach (var _ in answers)
            {
                var customComboBox = new CustomComboBox()
                {
                    ComboItems = answersArray
                };
                customComboBox.Size = new Size(717, 25);

                questionsCreating.AddSequenceAnswerRow(customComboBox, 
                    answersTableLayoutPanel);
            }
        }
    }
}
