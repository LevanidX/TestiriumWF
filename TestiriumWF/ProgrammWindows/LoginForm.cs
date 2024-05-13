using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.ProgrammWindows;

namespace TestiriumWF
{
    public partial class LoginForm : Form
    {
        private MySqlWriter _mySqlWriter = new MySqlWriter();

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckTeacherLogin()
        {
            var teacherCommand = $"SELECT user_teacher_password " +
                $"FROM users_teachers " +
                $"WHERE user_teacher_login='{loginTextBox.Text}' AND " +
                $"user_teacher_password='{passwordTextBox.Text}'";
            
            return _mySqlWriter.ExecuteCheckSqlCommand(teacherCommand);
        }

        private bool CheckStudentLogin()
        {
            var studentCommand = $"SELECT user_student_password " +
                $"FROM users_students " +
                $"WHERE user_student_login='{loginTextBox.Text}' AND " +
                $"user_student_password='{passwordTextBox.Text}'";

            return _mySqlWriter.ExecuteCheckSqlCommand(studentCommand);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (isTeacherCheckBox.Checked)
                {
                    if (CheckTeacherLogin())
                    {
                        UserConfig.UserId = Convert.ToInt32(_mySqlWriter.ExecuteSelectScalarCommand($"SELECT user_teacher_id " +
                            $"FROM users_teachers " +
                            $"WHERE user_teacher_login='{loginTextBox.Text}' AND user_teacher_password='{passwordTextBox.Text}'"));

                        UserConfig.IsTeacher = true;

                        UserConfig.LoginForm = this;
                        TestiriumMainMenu testiriumMainMenu = new TestiriumMainMenu();
                        testiriumMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    if (CheckStudentLogin())
                    {
                        UserConfig.UserId = Convert.ToInt32(_mySqlWriter.ExecuteSelectScalarCommand($"SELECT user_student_number " +
                            $"FROM users_students " +
                            $"WHERE user_student_login='{loginTextBox.Text}' AND user_student_password='{passwordTextBox.Text}'"));

                        UserConfig.IsTeacher = false;


                        UserConfig.LoginForm = this;
                        TestiriumMainMenu testiriumMainMenu = new TestiriumMainMenu();
                        testiriumMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введен неверный логин или пароль");
            }
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {
            loginTextBox.Text = "levashka";
            passwordTextBox.Text = "Rurik123";
            isTeacherCheckBox.Checked = true;
        }

        private void studentRB_CheckedChanged(object sender, EventArgs e)
        {
            loginTextBox.Text = "gera45";
            passwordTextBox.Text = "Jorik981";
            isTeacherCheckBox.Checked = false;
        }
    }
}
