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

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestOneQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();
        AnswersGetting answersGetting;

        public TestOneQuestionPanel()
        {
            InitializeComponent();
            answersGetting = new AnswersGetting(answersTableLayoutPanel);
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

        public string GetUserAnswer() //остановились на радиобаттонах, тут берутся ответы
        {
            string answer = string.Empty;

            foreach (var RB in answersTableLayoutPanel.Controls.OfType<RadioButton>())
            {
                if (RB.Checked)
                {
                    var row = answersTableLayoutPanel.GetRow(RB);
                    var customLabel = (CustomLabel)answersTableLayoutPanel.GetControlFromPosition(1, row);
                    answer = customLabel.TextValue;
                }
            }

            return answer;
        }

        //план такой, для перемешки ответов, будем это делать после десериализации и
        //запоминать нормальный порядок, а потом мешать, а потом возвращать
        //обратно и сравнивать с верными ответами
    }
}
