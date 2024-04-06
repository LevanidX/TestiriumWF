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

        private List<string> GetValue(MySqlDataReader dataReader)
        {
            List<string> items = new List<string>
            {
                dataReader.GetString(0),
                dataReader.GetInt32(1).ToString()
            };
            
            return items;
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

                        UserConfig.PersonName = "Плетнев Леонид"; //пока происходит вход только под одним аккаунтом, при входе на главное меню обработать вставку ника в юсер контроле клиент бокса

                        UserConfig.IsTeacher = true;

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
                        var studentNumber = Convert.ToInt32(_mySqlWriter.ExecuteSelectScalarCommand($"SELECT user_student_number " +
                            $"FROM users_students " +
                            $"WHERE user_student_login='{loginTextBox.Text}' AND user_student_password='{passwordTextBox.Text}'"));

                        UserConfig.PersonName = _mySqlWriter.ExecuteSelectScalarCommand($"SELECT CONCAT(student_surname, ' ', student_name) " +
                            $"FROM users_students, students " +
                            $"WHERE {studentNumber} = student_id");
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
    }
}
