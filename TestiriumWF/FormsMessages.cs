using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF
{
    internal class FormsMessages
    {
        public void ShowWarningNoNullAllowedMessage()
        {
            MessageBox.Show(
                ConfigurationManager.AppSettings.Get("WarningNoNullAllowedMessage"),
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public DialogResult ShowOneMoreCourseAddingMessage()
        {
            DialogResult dialog = MessageBox.Show(
                ConfigurationManager.AppSettings.Get("OneMoreCourseAddingMessage"),
                ConfigurationManager.AppSettings.Get("ProgrammName"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return dialog;
        }
    }
}
