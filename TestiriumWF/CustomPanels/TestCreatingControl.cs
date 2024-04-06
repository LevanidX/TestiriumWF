using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCreatingControl : UserControl
    {
        private string _currentCourse;

        public TestCreatingControl(string currentCourse)
        {
            InitializeComponent();
            _currentCourse = currentCourse;
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            var chooseQuestionType = new ChooseQuestionType(questionsContainerPanel, buttonsContainerPanel);

            chooseQuestionType.Show();
        }

        private void btnWelcomeScreen_Click(object sender, EventArgs e)
        {
            welcomeScreenPanel.BringToFront();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            buttonsContainerPanel.Controls.Remove(QuestionsCreating.CurrentButton);
            questionsContainerPanel.Controls.Remove(QuestionsCreating.CurrentPanel);
        }

        private void btnEndCreation_Click(object sender, EventArgs e)
        {
            EndScreenPanel endScreenPanel = new EndScreenPanel(questionsContainerPanel, welcomeScreenPanel, _currentCourse);
            questionsContainerPanel.Controls.Add(endScreenPanel);
            endScreenPanel.Location = new Point(16, 16);
            endScreenPanel.BringToFront();
            btnCreateQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;
            buttonsContainerPanel.Enabled = false;
        }
    }
}
