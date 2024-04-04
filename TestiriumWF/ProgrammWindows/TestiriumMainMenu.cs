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
        MySqlWriter _mySqlWriter = new MySqlWriter();

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
            string sqlCommand = "SELECT test_id," +
                "test_name AS 'Название', " +
                "CONCAT(teacher_surname, ' ', " +
                "SUBSTRING(teacher_name, 1, 1), '.', " +
                "SUBSTRING(teacher_patronymic, 1, 1), '.') AS 'Автор'," +
                "test_creation_date AS 'Дата создания'" +
                "FROM tests, users_teachers, teachers " +
                "WHERE test_user_teacher_number = user_teacher_id " +
                "AND user_teacher_number = teacher_id " +
                "AND test_course_number = 1";

            customDataGridView1.SetFillData(sqlCommand);
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
