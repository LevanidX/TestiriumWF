﻿using System;
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
    public partial class TestMatchQuestionPanel : UserControl
    {
        TestQuestionsCreating questionsCreating = new TestQuestionsCreating();

        public TestMatchQuestionPanel()
        {
            InitializeComponent();
        }

        public void SetQuestionText(string questionText)
        {
            lblTestTitle.Text = questionText;
        }

        public void SetAnswers(List<string> answers, List<string> rightAnswers)
        {
            string[] rightAnswersArray = rightAnswers.ToArray();

            foreach (var answer in answers)
            {
                var customLabel = new CustomLabel()
                {
                    TextValue = answer
                };

                var customComboBox = new CustomComboBox()
                {
                    ComboItems = rightAnswersArray
                };

                customComboBox.Size = new Size(360, 23);

                questionsCreating.AddMatchAnswerRow(customLabel, customComboBox,
                    definitionsAndAlignmentsTableLayoutPanel);
            }
        }
    }
}
