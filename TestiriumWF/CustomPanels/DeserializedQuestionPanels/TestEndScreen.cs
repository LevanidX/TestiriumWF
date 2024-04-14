using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls.MainMenuControls;
using TestStructure;

namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    public partial class TestEndScreen : UserControl
    {
        private TestCreator _testCreator = new TestCreator();
        private Test _studentsTest;
        private int _testId;
        private double _overallScore;
        private Panel _allQuestionsPanel;
        private BackControl _backControl;

        public TestEndScreen(Test studentsTest, int testId, double overallScore, Panel allQuestionsPanel, BackControl backControl)
        {
            InitializeComponent();
            _studentsTest = studentsTest;
            _testId = testId;
            _overallScore = overallScore;
            _allQuestionsPanel = allQuestionsPanel;
            _backControl = backControl;
        }

        private void TestEndScreen_Load(object sender, EventArgs e)
        {
            lblPercentageResult.Text = $"{CountRightAnsweredQuestions()} из {_studentsTest.Questions.Count} - {Math.Round(_overallScore, 2)}%";
            lblMark.Text = $"Оценка - {GetMarkForTest()}";

            _testCreator.CreateCompletedTestResult(_testId, UserConfig.UserId, _studentsTest, GetMarkForTest());
        }

        private int CountRightAnsweredQuestions()
        {
            var counter = 0;
            foreach (var question in _studentsTest.Questions)
            {
                if (question.HasAnsweredCorrectly)
                {
                    counter++;
                }
            }
            return counter;
        }

        private string GetMarkForTest()
        {
            if (_studentsTest.TestSettings.EstimationMethod.Type == "NON_MARK")
            {
                if (_overallScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.PassMarkPercentage)
                {
                    return "Зачёт";
                }
                else
                {
                    return "Не зачёт";
                }
            }
            else
            {
                if (_overallScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.BadMarkPercentage &&
                _overallScore < _studentsTest.TestSettings.EstimationMethod.EstimationParametres.SatisfactoryMarkPercentage)
                {
                    return "2";
                }
                else if (_overallScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.SatisfactoryMarkPercentage &&
                    _overallScore < _studentsTest.TestSettings.EstimationMethod.EstimationParametres.NormalMarkPercentage)
                {
                    return "3";
                }
                else if (_overallScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.NormalMarkPercentage &&
                    _overallScore < _studentsTest.TestSettings.EstimationMethod.EstimationParametres.ExcellentMarkPercentage)
                {
                    return "4";
                }
                else if (_overallScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.ExcellentMarkPercentage)
                {
                    return "5";
                }
            }

            return "2";
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            _allQuestionsPanel.Enabled = true;
            this.Parent.Controls.Remove(this);
            _backControl.ShowButton(true);
        }


        //продолжим работу с заключительного экрана

        //планы
        //сделать перелет результата в бд
        //просмотр результата и ошибок (возможно выделение)
        //тестирование
        //создание пользователей
        //создание отчетов (класс - тестирование)
        //создание отчетов (учащийся - тестирование)
    }
}
