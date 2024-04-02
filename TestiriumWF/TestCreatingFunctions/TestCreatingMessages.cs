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
        public void ShowWarningDeleteAnswersMessage()
        {
            MessageBox.Show(ConfigurationManager.AppSettings.Get("WarningDeleteAnswersMessage"),
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public void ShowWarningAddingMoreDefinitions()
        {
            MessageBox.Show(ConfigurationManager.AppSettings.Get("WarningAddingMoreDefinitions"),
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
