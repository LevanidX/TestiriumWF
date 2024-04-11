using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestStructure;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestCompletor
    {
        private float overallResult;
        private Test _studentsTest;
        private Panel _questionsPanel;

        private List<List<string>> _userAnswers;

        public TestCompletor(Test studentsTest, Panel questionsPanel) 
        {
            _studentsTest = studentsTest;
            _questionsPanel = questionsPanel;
        }

        public void EndTest()
        {
            foreach (var questionPanel in _questionsPanel.Controls.OfType<TestOneQuestionPanel>())
            {
                _userAnswers.Add(questionPanel.GetUserAnswer());
            }

            var questions = _studentsTest.Questions;

            for (int i = 0; i < _userAnswers.Count; i++)
            {
                if (questions[i].RightAnswers == _userAnswers[i])
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }

        private string GetRightAnswersRadioButtons()
        {
            foreach (var radioButton in _answersPanel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    var row = _answersPanel.GetRow(radioButton);
                    CustomAnswerTextBox rightAnswer = (CustomAnswerTextBox)_answersPanel.GetControlFromPosition(1, row);
                    _rightAnswers.Add(rightAnswer.GetAnswerText());
                }
            }

            return _rightAnswers;
        }

        //public List<string> GetMatchRightAnswers()
        //{
        //    foreach (var textBox in _answersPanel.Controls.OfType<CustomAnswerTextBox>())
        //    {
        //        if (textBox.Tag.ToString() == "AlignmentBox")
        //        {
        //            _rightAnswers.Add(textBox.GetAnswerText());
        //        }
        //    }

        //    return _rightAnswers;
        //}



        //public List<string> GetRightAnswersCheckBox()
        //{
        //    foreach (var checkBox in _answersPanel.Controls.OfType<CheckBox>())
        //    {
        //        if (checkBox.Checked)
        //        {
        //            var row = _answersPanel.GetRow(checkBox);
        //            CustomAnswerTextBox rightAnswer = (CustomAnswerTextBox)_answersPanel.GetControlFromPosition(1, row);
        //            _rightAnswers.Add(rightAnswer.GetAnswerText());
        //        }
        //    }

        //    return _rightAnswers;
        //}
    }
}
