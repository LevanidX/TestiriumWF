using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestTextQuestionPanel : UserControl
    {
        public TestTextQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(string questionText)
        {
            lblTestTitle.Text = questionText;
        }

        public string GetTextAnswer()
        {
            return answerTextBox.Text;
        }
    }
}
