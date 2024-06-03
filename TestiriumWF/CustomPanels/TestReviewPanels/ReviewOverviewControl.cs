using System;
using TestStructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.CustomPanels
{
    public partial class ReviewOverviewControl : UserControl
    {
        private TeacherTestReviewer _testReviewer = new TeacherTestReviewer();
        private Test _studentsTest;

        private string _studentsFullName;

        public ReviewOverviewControl(Test studentsTest, string studentsFullName)
        {
            InitializeComponent();
            _studentsTest = studentsTest;
            _studentsFullName = studentsFullName;
        }

        private void ReviewOverviewControl_Load(object sender, EventArgs e)
        {
            lblTestTitle.Text = "Результат по тестированию: " + _studentsTest.Name;
            lblMarkResult.Text = "Процент - " + _studentsTest.OverallResult.OverallPercentageScore + "%";
            lblPercentageResult.Text = "Оценка - " + _studentsTest.OverallResult.OverallMarkScore;
            lblStudentName.Text = "Обучающийся: " + _studentsFullName;

            studentResultDataGridView.FillData(_testReviewer.GetDataTableResults(_studentsTest));
        }
    }
}
