using System;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestEndScreen : UserControl
    {
        private Test _studentsTest;

        private Panel _allQuestionsPanel;

        public TestEndScreen(Test studentsTest, Panel allQuestionsPanel)
        {
            InitializeComponent();

            _studentsTest = studentsTest;
            _allQuestionsPanel = allQuestionsPanel;
        }

        private void TestEndScreen_Load(object sender, EventArgs e)
        {

            lblPercentageResult.Text = $"{_studentsTest.OverallResult.AnsweredCorrectlyQuestionsCounter} из {_studentsTest.Questions.Count} - {_studentsTest.OverallResult.OverallPercentageScore}%";
            lblMark.Text = $"Оценка - {_studentsTest.OverallResult.OverallMarkScore}";
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            _allQuestionsPanel.Enabled = true;
            this.Parent.Controls.Remove(this);
        }
    }
}
