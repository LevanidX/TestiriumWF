using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestiriumWF.CustomControls;
using TestiriumWF.ProgrammWindows;
using TestiriumWF.SqlFunctions;
using MySql.Data.MySqlClient;

namespace TestiriumWF.CustomPanels
{
    public partial class UsersControl : UserControl
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        private bool _isTeacher;

        private int _selectedCatalogId;

        public UsersControl() => InitializeComponent();

        private void UsersControl_Load(object sender, EventArgs e)
        {
            usersDataGridView.DataGridRightClick += () => usersDataGridMenuStrip.Show(MousePosition);

            FillUsersValues(true, teachersPanel, teachersCatalogPanel,
                specialitiesFlowLayoutPanel, "get_available_specialities");
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            new UserEditor(_isTeacher, _selectedCatalogId).Show();
            UserConfig.MainMenu.Enabled = false;
        }
        private void btnTeachers_Click(object sender, EventArgs e)
        {
            FillUsersValues(true, teachersPanel, teachersCatalogPanel,
                specialitiesFlowLayoutPanel, "get_available_specialities");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            FillUsersValues(false, studentsPanel, studentsCatalogPanel,
                classesFlowLayoutPanel, "get_available_classes");
        }

        private void FillDataGridWithUsers(int currentCatalog, string procedureName, string parameterName)
        {
            usersDataGridView.FillData(_mySqlFunctions.CallProcedureWithReturnedDataTable(procedureName, new MySqlParameter[]
            {
                new MySqlParameter(parameterName, currentCatalog)
            }));
        }

        private void FillUsersValues(bool isTeacher, Panel panel, Panel catalogPanel, 
            FlowLayoutPanel flowLayoutPanel, string procedureName)
        {
            _isTeacher = isTeacher;

            panel.BringToFront();
            catalogPanel.BringToFront();

            flowLayoutPanel.Controls.Clear();

            foreach (DataRow row in _mySqlFunctions.CallProcedureWithReturnedDataTable(procedureName).Rows)
            {
                CreateCustomLinkLabel(row[0].ToString(), row[1].ToString(), flowLayoutPanel);
            }

            FillDataGridWithUsers(0, _isTeacher ? "get_teachers_from_speciality" : "get_students_from_class",
               _isTeacher ? "speciality_id" : "class_id");

            lblChoicedClass.Text = "Не выбран";
            lblChoicedSpeciality.Text = "Не выбрана";
            btnCreateUser.Enabled = false;
        }

        private void CreateCustomLinkLabel(string catalogId, string catalogName, Panel containerPanel)
        {
            var customLinkLabel = new CustomLinkLabel();

            customLinkLabel.TagValue = catalogId;
            customLinkLabel.TextValue = catalogName;
            customLinkLabel.AddEventClick(LinkLabelClick);

            containerPanel.Controls.Add(customLinkLabel);
        }

        private void LinkLabelClick(object sender, EventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            _selectedCatalogId = Convert.ToInt32(linkLabel.Tag);
            FillDataGridWithUsers(_selectedCatalogId, 
                _isTeacher ? "get_teachers_from_speciality" : "get_students_from_class",
                _isTeacher ? "speciality_id" : "class_id");
            btnCreateUser.Enabled = true;
            lblChoicedSpeciality.Text = linkLabel.Text;
            lblChoicedClass.Text = linkLabel.Text;
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserEditor(_isTeacher, usersDataGridView.GetSelectedId(), _selectedCatalogId).Show();
            UserConfig.MainMenu.Enabled = false;
        }

            private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(
                "Вы уверены, что хотите удалить данного пользователя?",
                "Тестириум",
                MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                _mySqlFunctions.CallProcedure(_isTeacher ? "delete_user_teacher" : "delete_user_student", new MySqlParameter[]
                {
                    new MySqlParameter("person_id", usersDataGridView.GetSelectedId())
                });

                FillDataGridWithUsers(_selectedCatalogId, _isTeacher ? "get_teachers_from_speciality" : "get_students_from_class",
                    _isTeacher ? "speciality_id" : "class_id");
            }
        }

        private void btnAddNewSpeciality_Click(object sender, EventArgs e)
        {
            new CreateNewSpeciality().Show();
            UserConfig.MainMenu.Enabled = false;
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            new CreateNewClass().Show();
            UserConfig.MainMenu.Enabled = false;
        }
    }
}
