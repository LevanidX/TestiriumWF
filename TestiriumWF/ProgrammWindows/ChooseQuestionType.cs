using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using TestiriumWF.CustomPanels;

namespace TestiriumWF
{
    public partial class ChooseQuestionType : Form
    {
        private Panel _questionsContainerPanel = new Panel();
        private Panel _buttonsContainerPanel = new Panel();

        private string _oneAnswerText;
        private string _multipleAnswerText;
        private string _textAnswerText;
        private string _sequencingAnswerText;
        private string _matchAnswerText;

        public ChooseQuestionType(Panel questionsContainerPanel, Panel buttonsContainerPanel)
        {
            InitializeComponent();

            _questionsContainerPanel = questionsContainerPanel;
            _buttonsContainerPanel = buttonsContainerPanel;
        }

        private void ChooseQuestionType_Load(object sender, EventArgs e)
        {
            _oneAnswerText = ConfigurationManager.AppSettings.Get("OneAnswerQuestionButtonText");
            _multipleAnswerText = ConfigurationManager.AppSettings.Get("MultipleAnswerQuestionButtonText");
            _textAnswerText = ConfigurationManager.AppSettings.Get("TextAnswerQuestionButtonText");
            _sequencingAnswerText = ConfigurationManager.AppSettings.Get("SequencingAnswerQuestionButtonText");
            _matchAnswerText = ConfigurationManager.AppSettings.Get("MatchAnswerQuestionButtonText");

            btnOneAnswerQuestion.Text = _oneAnswerText;
            btnMultipleAnswerQuestion.Text = _multipleAnswerText;
            btnTextAnswerQuestion.Text = _textAnswerText;
            btnRightOrderAnswerQuestion.Text = _sequencingAnswerText;
            btnMatchAnswerQuestion.Text = _matchAnswerText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EndChoosing();
        }

        private void btnOneAnswerQuestion_Click(object sender, EventArgs e)
        {
            var oneQuestionPanel = new OneQuestionPanel();
            var oneQuestionButton = new CustomTestCreatingButton(oneQuestionPanel, _oneAnswerText);

            CreateQuestionPanel(oneQuestionPanel, oneQuestionButton);
        }

        private void btnMultipleAnswerQuestion_Click(object sender, EventArgs e)
        {
            var multipleQuestionPanel = new MultipleQuestionPanel();
            var customTestCreatingButton = new CustomTestCreatingButton(multipleQuestionPanel, _multipleAnswerText);
        
            CreateQuestionPanel(multipleQuestionPanel, customTestCreatingButton);
        }

        private void btnTextAnswerQuestion_Click(object sender, EventArgs e)
        {
            var textQuestionPanel = new TextQuestionPanel();
            var customTestCreatingButton = new CustomTestCreatingButton(textQuestionPanel, _textAnswerText);

            CreateQuestionPanel(textQuestionPanel, customTestCreatingButton);
        }

        private void CreateQuestionPanel(UserControl questionPanel, UserControl questionButton)
        {
            _questionsContainerPanel.Controls.Add(questionPanel);
            _buttonsContainerPanel.Controls.Add(questionButton);
            questionPanel.BringToFront();
            questionPanel.Location = new Point(16, 16);
            EndChoosing();
        }

        private void EndChoosing()
        {
            this.Close();
        }

        private void btnRightOrderAnswerQuestion_Click(object sender, EventArgs e)
        {
            var sequencingQuestionPanel = new SequencingQuestionPanel();
            var customTestCreatingButton = new CustomTestCreatingButton(sequencingQuestionPanel, _sequencingAnswerText);

            CreateQuestionPanel(sequencingQuestionPanel, customTestCreatingButton);
        }

        private void btnMatchAnswerQuestion_Click(object sender, EventArgs e)
        {
            var matchQuestionPanel = new MatchQuestionPanel();
            var customTestCreatingButton = new CustomTestCreatingButton(matchQuestionPanel, _matchAnswerText);

            CreateQuestionPanel(matchQuestionPanel, customTestCreatingButton);
        }
    }
}
