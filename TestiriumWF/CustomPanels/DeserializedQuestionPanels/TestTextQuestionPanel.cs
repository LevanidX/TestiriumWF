using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestTextQuestionPanel : UserControl
    {
        public TestTextQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(Question question)
        {
            lblTestTitle.Text = question.QuestionText;
        }

        public void SetAnswers(Question question) { } //метод пустышка

        public List<string> GetUserAnswers()
        {
            List<string> userAnswers = new List<string>
            {
                answerTextBox.Text
            };

            return userAnswers;
        }
    }
}
