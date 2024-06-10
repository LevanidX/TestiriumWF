using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    internal class TestCreatingMessages
    {
        /// <summary>
        /// Показывает сообщение с предупреждением об удалении крайних двух ответов
        /// </summary>
        public static void ShowWarningDeleteAnswersMessage()
        {
            MessageBox.Show(ConfigurationManager.AppSettings.Get("WarningDeleteAnswersMessage"),
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static void ShowFutureUpdateMessage()
        {
            MessageBox.Show("Функционал добавления изображений и видеороликов планируется добавить в будущем обновлении!",
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
