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
            List<string> comboItemAnswers = new List<string>(); // перемешанные ответы
            List<int> triedNumbers = new List<int>(); //проверка наличия числа рандома в списке

            Random random = new Random();

            while (comboItemAnswers.Count() != answers.Count())
            {
                var nextNum = random.Next(0, answers.Count);

                if (!triedNumbers.Contains(nextNum))
                {
                    triedNumbers.Add(nextNum);
                    comboItemAnswers.Add(answers[nextNum]);
                }
            }

            return comboItemAnswers;
        }
    }
}
