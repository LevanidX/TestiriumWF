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
using TestiriumWF.CustomPanels;

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
        private string _sequencingAnswerText;
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
            OneQuestionPanel oneQuestionPanel = new OneQuestionPanel();
            CustomTestCreatingButton oneQuestionButton = new CustomTestCreatingButton(oneQuestionPanel, _oneAnswerText);

            CreateQuestionPanel(oneQuestionPanel, oneQuestionButton);
        }

        private void btnMultipleAnswerQuestion_Click(object sender, EventArgs e)
        {
            MultipleQuestionPanel multipleQuestionPanel = new MultipleQuestionPanel();
            CustomTestCreatingButton customTestCreatingButton = new CustomTestCreatingButton(multipleQuestionPanel, _multipleAnswerText);
        
            CreateQuestionPanel(multipleQuestionPanel, customTestCreatingButton);
        }

        private void btnTextAnswerQuestion_Click(object sender, EventArgs e)
        {
            TextQuestionPanel textQuestionPanel = new TextQuestionPanel();
            CustomTestCreatingButton customTestCreatingButton = new CustomTestCreatingButton(textQuestionPanel, _textAnswerText);

            CreateQuestionPanel(textQuestionPanel, customTestCreatingButton);
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

        private void btnRightOrderAnswerQuestion_Click(object sender, EventArgs e)
        {
            SequencingQuestionPanel sequencingQuestionPanel = new SequencingQuestionPanel();
            CustomTestCreatingButton customTestCreatingButton = new CustomTestCreatingButton(sequencingQuestionPanel, _sequencingAnswerText);

            CreateQuestionPanel(sequencingQuestionPanel, customTestCreatingButton);
        }

        private void btnMatchAnswerQuestion_Click(object sender, EventArgs e)
        {
            MatchQuestionPanel matchQuestionPanel = new MatchQuestionPanel();
            CustomTestCreatingButton customTestCreatingButton = new CustomTestCreatingButton(matchQuestionPanel, _matchAnswerText);

            CreateQuestionPanel(matchQuestionPanel, customTestCreatingButton);
        }
    }
}
