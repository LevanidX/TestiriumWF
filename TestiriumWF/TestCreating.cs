﻿using System;
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
    public partial class TestCreating : Form
    {
        public TestCreating()
        {
            InitializeComponent();
        }

        private void TestCreating_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            ChooseQuestionType chooseQuestionType = new ChooseQuestionType(this, containerPanel);
            chooseQuestionType.Show();
            this.Enabled = false;
        }
    }
}
