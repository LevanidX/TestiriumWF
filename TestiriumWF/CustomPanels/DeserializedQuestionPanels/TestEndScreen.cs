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
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private TestCreator _testCreator = new TestCreator();
        private Test _studentsTest;
        private int _testId;
        private double _overallScore;
        private Panel _allQuestionsPanel;

        public TestEndScreen(Test studentsTest, int testId, double overallScore, Panel allQuestionsPanel)
        {
            InitializeComponent();
            _studentsTest = studentsTest;
            _testId = testId;
            _overallScore = overallScore;
            _allQuestionsPanel = allQuestionsPanel;
        }

        private void TestEndScreen_Load(object sender, EventArgs e)
        {
            if (GetMarkForTest() == "Зачёт")
            {
                _studentsTest.FinalMark.MarkNumberResult = 5;
            }
            else if (GetMarkForTest() == "Не зачёт")
            {
                _studentsTest.FinalMark.MarkNumberResult = 2;
            }
            else
            {
                Console.WriteLine(GetMarkForTest());
                _studentsTest.FinalMark.MarkNumberResult = Convert.ToInt32(GetMarkForTest());
            }

            _studentsTest.FinalMark.MarkPercentageResult = _overallScore;

            lblPercentageResult.Text = $"{CountRightAnsweredQuestions()} из {_studentsTest.Questions.Count} - {Math.Round(_overallScore, 2)}%";
            lblMark.Text = $"Оценка - {GetMarkForTest()}";

            if (!UserConfig.IsTeacher)
            {
                int triesCount = Convert.ToInt32(_mySqlWriter.ExecuteSelectScalarCommand(
                $"SELECT COUNT(*) " +
                $"FROM completed_tests " +
                $"WHERE completed_test_user_student_number = {UserConfig.UserId} " +
                $"AND completed_test_number = {_testId}"));


                _testCreator.CreateCompletedTestResult(_testId, UserConfig.UserId, _studentsTest, GetMarkForTest(), triesCount + 1);
            }
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
        }

        //создание пользователей
        //создание отчетов (класс - тестирование)
        //создание отчетов (учащийся - тестирование)
    }
}
