using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiriumWF;

namespace TestiriumWF.TestCreatingFunctions
{
    internal class TestRandomiser
    {
        public List<string> MixAnswers(List<string> answers)
        {
            List<string> comboItemAnswers = new List<string>();
            Random random = new Random();

            while (comboItemAnswers.Count() != answers.Count())
            {
                var nextNum = random.Next(0, answers.Count);

                if (!comboItemAnswers.Contains(answers[nextNum]))
                {
                    comboItemAnswers.Add(answers[nextNum]);
                }
            }

            return comboItemAnswers;
        }
    }
}
