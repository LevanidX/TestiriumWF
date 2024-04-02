using System;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;

namespace TestiriumWF
{
    public partial class TestCreating : Form
    {
        public TestCreating()
        {
            InitializeComponent();
        }

        private void TestCreating_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            ChooseQuestionType chooseQuestionType = new ChooseQuestionType(this, 
                questionsContainerPanel, buttonsContainerPanel);

            chooseQuestionType.Show();
            this.Enabled = false;
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
            EndScreenPanel endScreenPanel = new EndScreenPanel(questionsContainerPanel, welcomeScreenPanel);
            questionsContainerPanel.Controls.Add(endScreenPanel);
            endScreenPanel.Location = new Point(18, 18);
            endScreenPanel.BringToFront();
            btnCreateQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;
            buttonsContainerPanel.Enabled = false;
        }
    }
}
