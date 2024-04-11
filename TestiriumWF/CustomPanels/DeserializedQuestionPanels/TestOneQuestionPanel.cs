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
    public partial class TestOneQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestOneQuestionPanel()
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
                var radioButton = new RadioButton();
                radioButton.Padding = new Padding(2);
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };
                questionsCreating.AddTickAnswerRow(radioButton, customLabel, 
                    answersTableLayoutPanel);
            }
        }
    }
}
