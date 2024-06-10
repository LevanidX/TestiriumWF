using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TestiriumWF.ProgrammFunctions
{
    internal class UserMessages
    {
        public static void ShowWrongLoginOrPasswordMessage()
        {
            MessageBox.Show(
                "Логин или пароль были введены неверно!\nПовторите попытку.",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void ShowSuccessEditUserMessage()
        {
            MessageBox.Show(
                "Обновление данных было успешно произведено!",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void ShowSuccessAddNewUserMessage()
        {
            MessageBox.Show(
                "Добаление нового пользователя было успешно произведено!",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarningDeleteSpecialityMessage()
        {
            return MessageBox.Show(
                "ВНИМАНИЕ: Удаление специальности приведёт к удалению всех связанных пользователей!" +
                "\nВы хотите продолжить?",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }

        public static DialogResult ShowWarningDeleteClassMessage()
        {
            return MessageBox.Show(
                "ВНИМАНИЕ: Удаление класса приведёт к удалению всех связанных пользователей!" +
                "\nВы хотите продолжить?",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
    }
}
