using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF.CustomPanels
{
    public partial class TestCompletingControl : UserControl
    {
        private TestDeserializer _testDeserializer;
        private Test _test;

        public TestCompletingControl(string xmlTestFile)
        {
            InitializeComponent();
            _testDeserializer = new TestDeserializer(_test, xmlTestFile);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            CreateTest();
        }

        private void CreateTest() //здесь нужно продолжить создание теста для прохождения
        {
            _test = _testDeserializer.DeserializeTest();
        }
    }
}
