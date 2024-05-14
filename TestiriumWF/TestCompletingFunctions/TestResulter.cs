using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStructure;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestResulter
    {
        private Test _studentsTest;

        private int _answeredCorrectlyQuestionsCounter;

        private double _overallPercentageScore = 0;
        private string _overallMarkScore;

        private double _scoreSummer; //изменяемое значение получаемое путем деления 100 на кол во вопросов

        public TestResulter(Test studentsTest)
        {
            _studentsTest = studentsTest;
        }

        public OverallResult GetResult()
        {
            SetResult();
            return new OverallResult(_overallMarkScore, _overallPercentageScore, _answeredCorrectlyQuestionsCounter); ;
        }

        private void SetResult()
        {
            DefineScoreSummer();
            CountOverallScore();
            SetMarkForTest();
        }

        private void SetMarkForTest()
        {
            _overallMarkScore = (_studentsTest.TestSettings.EstimationMethod.Type == "NON_MARK") ?
                (_overallPercentageScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.PassMarkPercentage ? "Зачёт" : "Не зачёт") :
                (_overallPercentageScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.ExcellentMarkPercentage ? "5" :
                (_overallPercentageScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.NormalMarkPercentage ? "4" :
                (_overallPercentageScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.SatisfactoryMarkPercentage ? "3" :
                (_overallPercentageScore >= _studentsTest.TestSettings.EstimationMethod.EstimationParametres.BadMarkPercentage ? "2" : "2"))));
        }

        private void CountOverallScore()
        {
            var counter = 0;
            foreach (var question in _studentsTest.Questions)
            {
                if (question.HasAnsweredCorrectly)
                {
                    counter++;
                }
            }

            _answeredCorrectlyQuestionsCounter = counter;
            _overallPercentageScore = Math.Round(counter * _scoreSummer, 2);
        }

        private void DefineScoreSummer()
        {
            _scoreSummer = 100 / (double)_studentsTest.Questions.Count;
        }
    }
}
