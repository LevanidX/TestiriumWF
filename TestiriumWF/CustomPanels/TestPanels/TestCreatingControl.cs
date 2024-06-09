using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCreatingControl : UserControl
    {
        private EndScreenPanel _endScreenPanel;
        private string _currentCourse;

        public TestCreatingControl(string currentCourse)
        {
            InitializeComponent();
            _currentCourse = currentCourse;
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = false;
            new ChooseQuestionType(questionsContainerPanel, buttonsContainerPanel).Show();
        }

        private void btnWelcomeScreen_Click(object sender, EventArgs e) => welcomeScreenPanel.BringToFront();

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            buttonsContainerPanel.Controls.Remove(QuestionsCreating.CurrentButton);
            questionsContainerPanel.Controls.Remove(QuestionsCreating.CurrentPanel);
        }

        private bool AllValuesInserted()
        {
            if (welcomeScreenPanel.GetTitleValue() != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Отсутствует название тестирования!");
                return false;
            }
        }

        private void btnEndCreation_Click(object sender, EventArgs e)
        {
            if (AllValuesInserted())
            {
                if (btnEndCreation.Tag.ToString() == "0")
                {
                    ShowEndScreenPanel(true);
                    btnEndCreation.Text = "Продолжить создание";
                    btnEndCreation.Tag = "1";
                }
                else
                {
                    ShowEndScreenPanel(false);
                    btnEndCreation.Text = "Завершить создание";
                    btnEndCreation.Tag = "0";
                }
            }
        }

        private void ShowEndScreenPanel(bool isShow)
        {
            if (isShow)
            {
                _endScreenPanel = new EndScreenPanel(questionsContainerPanel, welcomeScreenPanel, _currentCourse);
                questionsContainerPanel.Controls.Add(_endScreenPanel);

                _endScreenPanel.Location = new Point(16, 16);
                _endScreenPanel.BringToFront();
            }
            else
            {
                questionsContainerPanel.Controls.Remove(_endScreenPanel);
            }

            btnCreateQuestion.Enabled = !isShow;
            btnDeleteQuestion.Enabled = !isShow;
            buttonsContainerPanel.Enabled = !isShow;
        }
    }
}
