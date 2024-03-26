using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class ChooseQuestionType : Form
    {
        private Form _testCreatingForm = new Form();
        private Panel _questionsContainerPanel = new Panel();
        private Panel _buttonsContainerPanel = new Panel();

        private string _oneAnswerText;
        private string _multipleAnswerText;
        private string _textAnswerText;
        private string _rightOrderAnswerText;
        private string _matchAnswerText;

        public ChooseQuestionType(Form testCreatingForm, Panel questionsContainerPanel, Panel buttonsContainerPanel)
        {
            InitializeComponent();

            _testCreatingForm = testCreatingForm;
            _questionsContainerPanel = questionsContainerPanel;
            _buttonsContainerPanel = buttonsContainerPanel;
        }

        private void ChooseQuestionType_Load(object sender, EventArgs e)
        {
            _oneAnswerText = ConfigurationManager.AppSettings.Get("OneAnswerQuestionButtonText");
            _multipleAnswerText = ConfigurationManager.AppSettings.Get("MultipleAnswerQuestionButtonText");
            _textAnswerText = ConfigurationManager.AppSettings.Get("TextAnswerQuestionButtonText");
            _rightOrderAnswerText = ConfigurationManager.AppSettings.Get("RightOrderAnswerQuestionButtonText");
            _matchAnswerText = ConfigurationManager.AppSettings.Get("MatchAnswerQuestionButtonText");

            btnOneAnswerQuestion.Text = _oneAnswerText;
            btnMultipleAnswerQuestion.Text = _multipleAnswerText;
            btnTextAnswerQuestion.Text = _textAnswerText;
            btnRightOrderAnswerQuestion.Text = _rightOrderAnswerText;
            btnMatchAnswerQuestion.Text = _matchAnswerText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EndChoosing();
        }

        private void btnOneAnswerQuestion_Click(object sender, EventArgs e)
        {
            OneQuestionPanel oneQuestionPanel = new OneQuestionPanel();
            CustomTestCreatingButton oneQuestionButton = new CustomTestCreatingButton(oneQuestionPanel, _oneAnswerText);

            CreateQuestionPanel(oneQuestionPanel, oneQuestionButton);
        }

        private void CreateQuestionPanel(UserControl questionPanel, UserControl questionButton)
        {
            _questionsContainerPanel.Controls.Add(questionPanel);
            _buttonsContainerPanel.Controls.Add(questionButton);
            questionPanel.BringToFront();
            questionPanel.Location = new Point(18, 18);
            EndChoosing();
        }

        private void EndChoosing()
        {
            _testCreatingForm.Enabled = true;
            this.Close();
        }
    }
}
