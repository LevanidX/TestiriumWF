using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;
using TestiriumWF.ProgrammFunctions;
using TestStructure;
using ZstdSharp.Unsafe;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestCompletor
    {
        private float overallResult;
        private Test _studentsTest;
        private Panel _questionsPanel;

        private List<string> _userRadioButtonAnswers = new List<string>();

        public TestCompletor(Test studentsTest, Panel questionsPanel) 
        {
            _studentsTest = studentsTest;
            _questionsPanel = questionsPanel;
        }
    }
}
