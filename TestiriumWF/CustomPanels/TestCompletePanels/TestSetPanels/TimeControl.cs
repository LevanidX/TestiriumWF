using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammFunctions;

namespace TestiriumWF.CustomPanels
{
    public partial class TimeControl : UserControl
    {
        string _timeForTest;

        public TimeControl(string timeForTest)
        {
            InitializeComponent();
            _timeForTest = timeForTest;
        }

        private void TimeControl_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $"{_timeForTest}:00";
        }

        public void StartTimer()
        {
            
        }
    }
}
