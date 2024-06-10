using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TestiriumWF.SqlFunctions;

namespace TestiriumWF.ProgrammWindows
{
    public partial class CreateNewSpeciality : Form
    {
        MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        private Action _updateAction;
        private string _specialityId;

        private bool _isEditing;

        public CreateNewSpeciality(Action updateAction)
        {
            InitializeComponent();

            _updateAction = updateAction;
        }

        public CreateNewSpeciality(string specialityId, Action updateAction)
        {
            InitializeComponent();

            _updateAction = updateAction;
            _specialityId = specialityId;

            _isEditing = true;
        }

        private void CreateNewSpeciality_Load(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                var specialityData = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_speciality_data",
                    new MySqlParameter[] { new MySqlParameter("s_id", _specialityId) }).Rows[0];

                btnSave.Text = "Сохранить изменения";
                specialityTextBox.TextValue = specialityData[0].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (specialityTextBox.TextValue != string.Empty)
                {
                    _mySqlFunctions.CallProcedure(_isEditing ? "update_speciality" : "push_new_speciality", new MySqlParameter[]
                    {
                        _isEditing ? new MySqlParameter("s_id", _specialityId) : new MySqlParameter(),
                        new MySqlParameter("s_name", specialityTextBox.TextValue)
                    });

                    _updateAction?.Invoke();

                    MessageBox.Show(_isEditing ?
                        "Редактирование специальности было произведено успешно!" :
                        "Добавление новой специальности было произведено успешно!");
                }
                else
                {
                    MessageBox.Show("Вы не ввели даннные!");
                }
            }
            catch
            {
                MessageBox.Show("Такая специальность уже существует!");
            }
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            UserConfig.MainMenu.Enabled = true;
            this.Close();
        }
    }
}
