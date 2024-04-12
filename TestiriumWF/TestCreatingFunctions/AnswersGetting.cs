using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.TestCreatingFunctions
{
    internal class AnswersGetting
    {
        private List<string> _answers = new List<string>();
        private List<string> _rightAnswers = new List<string>();
        private TableLayoutPanel _answersPanel;

        public AnswersGetting(TableLayoutPanel answersPanel)
        {
            _answersPanel = answersPanel;
        }

        public List<string> GetAnswers()
        {
            foreach (var answerBox in _answersPanel.Controls.OfType<CustomAnswerTextBox>())
            {
                _answers.Add(answerBox.GetAnswerText());
            }

            return _answers;
        }

        public List<string> GetLowerAnswers()
        {
            foreach (var answerBox in _answersPanel.Controls.OfType<CustomAnswerTextBox>())
            {
                _answers.Add(answerBox.GetAnswerText().ToLower());
            }

            return _answers;
        }

        public List<string> GetMatchAnswers()
        {
            foreach (var textBox in _answersPanel.Controls.OfType<CustomAnswerTextBox>())
            {
                if (textBox.Tag.ToString() == "DefinitionBox")
                {
                    _answers.Add(textBox.GetAnswerText());
                }
            }

            return _answers;
        }

        public List<string> GetMatchRightAnswers()
        {
            foreach (var textBox in _answersPanel.Controls.OfType<CustomAnswerTextBox>())
            {
                if (textBox.Tag.ToString() == "AlignmentBox")
                {
                    _rightAnswers.Add(textBox.GetAnswerText());
                }
            }

            return _rightAnswers;
        }

        public List<string> GetRightAnswersRadioButtons()
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

        public List<string> GetRightAnswersCheckBox()
        {
            foreach (var checkBox in _answersPanel.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    var row = _answersPanel.GetRow(checkBox);
                    CustomAnswerTextBox rightAnswer = (CustomAnswerTextBox)_answersPanel.GetControlFromPosition(1, row);
                    _rightAnswers.Add(rightAnswer.GetAnswerText());
                }
            }

            return _rightAnswers;
        }
    }
}
