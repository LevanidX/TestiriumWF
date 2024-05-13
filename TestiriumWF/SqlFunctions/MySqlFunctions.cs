using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestiriumWF.SqlFunctions
{
    internal class MySqlFunctions
    {
        /// <summary>
        /// Получает строку с подключением
        /// </summary>
        /// <returns>Строка подключения</returns>
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["TestingSystemDBConnection"].ConnectionString;
        }

        /// <summary>
        /// Вызов процедуры
        /// </summary>
        /// <param name="procedureName">Наименование процедуры</param>
        /// <param name="parameters">Параметры</param>
        public void CallProcedure(string procedureName, params MySqlParameter[] parameters)
        {
            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procedureName;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddRange(parameters);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable CallProcedureWithReturnedDataTable(string procedureName, params MySqlParameter[] parameters)
        {
            var dataTable = new DataTable();

            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = procedureName;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddRange(parameters);

                    using (var dataAdapter = new MySqlDataAdapter())
                    {
                        dataAdapter.SelectCommand = sqlCommand;
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
