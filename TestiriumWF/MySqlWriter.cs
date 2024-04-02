using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ZstdSharp.Unsafe;
using static Mysqlx.Datatypes.Scalar.Types;

namespace TestiriumWF
{
    internal class MySqlWriter
    {
        private string GetConnectionString()
        {
            ConnectionStringSettings settings = new ConnectionStringSettings();
            settings = ConfigurationManager.ConnectionStrings["TestingSystemDBConnection"];
            return settings.ConnectionString;
        }

        public void ConnectToDatabase()
        {
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Подключение открыто!");
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться!");
                }
                
            }
        }

        public void ExecuteInsertSqlCommand(string sqlCommand)
        {
            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = sqlCommand;
                    command.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }

        public bool ExecuteCheckSqlCommand(string sqlCommand)
        {
            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = sqlCommand;
                    
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }

                sqlConnection.Close();

                return false;
            }
        }
    }
}
