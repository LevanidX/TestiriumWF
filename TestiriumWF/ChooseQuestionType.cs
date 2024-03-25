using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    public partial class ChooseQuestionType : Form
    {
        private Form _testCreatingForm = new Form();
        private Panel _containerPanel = new Panel();

        public ChooseQuestionType(Form testCreatingForm, Panel containerPanel)
        {
            InitializeComponent();
            _testCreatingForm = testCreatingForm;
            _containerPanel = containerPanel;
        }

        private void ChooseQuestionType_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EndChoosing();
        }

        private void btnOneAnswerQuestion_Click(object sender, EventArgs e)
        {
            OneQuestionPanel oneQuestionPanel = new OneQuestionPanel();
            _containerPanel.Controls.Add(oneQuestionPanel);
            oneQuestionPanel.BringToFront();
            oneQuestionPanel.Location = new Point(18, 18);

            EndChoosing();
        }

        private void EndChoosing()
        {
            _testCreatingForm.Enabled = true;
            this.Close();
        }
    }
}
