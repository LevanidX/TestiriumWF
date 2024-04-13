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
    public partial class TestOneQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestOneQuestionPanel()
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

        public List<string> GetUserAnswers() //остановились на радиобаттонах, тут берутся ответы
        {
            List<string> userAnswers = new List<string>();

            foreach (var RB in answersTableLayoutPanel.Controls.OfType<RadioButton>())
            {
                if (RB.Checked)
                {
                    var row = answersTableLayoutPanel.GetRow(RB);
                    var customLabel = (CustomLabel)answersTableLayoutPanel.GetControlFromPosition(1, row);
                    userAnswers.Add(customLabel.TextValue);
                }
            }

            return userAnswers;
        }

        //план такой, для перемешки ответов, будем это делать после десериализации и
        //запоминать нормальный порядок, а потом мешать, а потом возвращать
        //обратно и сравнивать с верными ответами
    }
}
