using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.ProgrammWindows
{
    public partial class TestiriumMainMenu : Form
    {
        public TestiriumMainMenu(int user_number)
        {
            InitializeComponent();
        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            //TestCreating testCreating = new TestCreating();
            //testCreating.Show();
            //this.Hide();
        }

        private void TestiriumMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
