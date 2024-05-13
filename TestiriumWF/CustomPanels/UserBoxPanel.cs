using System;
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
    public partial class UserBoxPanel : UserControl
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();
        private Action _clickAction;

        public UserBoxPanel()
        {
            InitializeComponent();
        }

        public void SetValues()
        {
            if (UserConfig.IsTeacher)
            {
                lblUserName.Text = _mySqlWriter.ExecuteSelectScalarCommand(
                    $"SELECT CONCAT(teacher_surname, ' ', teacher_name) " +
                    $"FROM users_teachers, teachers " +
                    $"WHERE {UserConfig.UserId} = teacher_id");
            }
            else
            {
                lblUserName.Text = _mySqlWriter.ExecuteSelectScalarCommand(
                    $"SELECT CONCAT(student_surname, ' ', student_name) " +
                    $"FROM users_students, students " +
                    $"WHERE {UserConfig.UserId} = student_id");
            }
        }

        public void SetClickAction(Action clickAction)
        {
            _clickAction = clickAction;
        }

        private void userBoxTableLayoutPanel_Click(object sender, EventArgs e)
        {
            _clickAction?.Invoke();
        }
    }
}
