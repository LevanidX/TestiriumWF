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
    public partial class PopUserPanel : UserControl
    {
        public PopUserPanel()
        {
            InitializeComponent();
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            if (UserConfig.IsTestStarted)
            {
                var dialogResult = MessageBox.Show(
                    "При выходе с тестирования результат текущего прохождения сохранится!\n" +
                    "Вы действительно хотите продолжить?",
                    "Тестириум",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    UserConfig.SaveTestResultAction?.Invoke();
                    Application.Exit();
                }
            }
            else if (UserConfig.IsTestCreatingStarted)
            {
                var dialogResult = MessageBox.Show(
                    "При выходе с создания тестирования, оно не сохранится!\n" +
                    "Вы действительно хотите продолжить?",
                    "Тестириум",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    UserConfig.IsTestCreatingStarted = false;
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (UserConfig.IsTestStarted)
            {
                MessageBox.Show(
                    "Редактирование профиля станет доступно после завершения тестирования",
                    "Тестириум",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (UserConfig.IsTestCreatingStarted)
            {
                MessageBox.Show(
                    "Редактирование профиля станет доступно после завершения создания тестирования",
                    "Тестириум",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this.Visible = false;
                var editUserProfile = new EditUserProfile();
                this.Parent.Controls.Add(editUserProfile);
                editUserProfile.BringToFront();
            }
        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            if (UserConfig.IsTestStarted)
            {
                var dialogResult = MessageBox.Show(
                    "При выходе с тестирования результат текущего прохождения сохранится!\n" +
                    "Вы действительно хотите продолжить?",
                    "Тестириум",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    UserConfig.SaveTestResultAction?.Invoke();
                    UserConfig.MainMenu.Close();
                    UserConfig.LoginForm.Show();
                }
            }
            else if (UserConfig.IsTestCreatingStarted)
            {
                var dialogResult = MessageBox.Show(
                    "При выходе с создания тестирования, оно не сохранится!\n" +
                    "Вы действительно хотите продолжить?",
                    "Тестириум",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    UserConfig.IsTestCreatingStarted = false;
                    UserConfig.MainMenu.Close();
                    UserConfig.LoginForm.Show();
                }
            }
            else
            {
                UserConfig.MainMenu.Close();
                UserConfig.LoginForm.Show();
            }
        }
    }
}
