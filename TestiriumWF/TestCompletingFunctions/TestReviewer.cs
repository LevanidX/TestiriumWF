using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomPanels.DeserializedQuestionPanels;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestReviewer
    {
        private Panel _questionsContainerPanel;

        public TestReviewer(Panel questionsContainerPanel)
        {
            _questionsContainerPanel = questionsContainerPanel;
        }

        public void ReviewPanels()
        {
            SetQuestionPanelsForReview<TestOneQuestionPanel>();
            SetQuestionPanelsForReview<TestMultipleQuestionPanel>();
            SetQuestionPanelsForReview<TestTextQuestionPanel>();
            SetQuestionPanelsForReview<TestSequenceQuestionPanel>();
            SetQuestionPanelsForReview<TestMatchQuestionPanel>();
        }

        private void SetQuestionPanelsForReview<TestQuestionPanel>()
        {
            var SetQuestionPanelForReviewMethod = typeof(TestQuestionPanel).GetMethod("SetQuestionPanelForReview",
                    BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);

            foreach (var questionPanel in _questionsContainerPanel.Controls.OfType<TestQuestionPanel>())
            {
                SetQuestionPanelForReviewMethod.Invoke(questionPanel, null);
            }
        }
    }
}
