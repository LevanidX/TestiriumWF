﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static Mysqlx.Datatypes.Scalar.Types;

namespace TestiriumWF
{
    internal class MySqlWriter
    {
        delegate string GetValues(MySqlDataReader sqlDataReader);

        private string GetConnectionString()
        {
            ConnectionStringSettings settings = new ConnectionStringSettings();
            settings = ConfigurationManager.ConnectionStrings["TestingSystemDBConnection"];


            return settings.ConnectionString;
        }

        public void ExecuteNotReadableSqlCommand(string sqlCommand)
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

        public List<List<string>> ExecuteSelectCommand(string sqlCommand, Func<MySqlDataReader, List<string>> action)
        {
            List<List<string>> items = new List<List<string>>();

            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = sqlCommand;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(action(reader));
                        }
                    }
                }

                sqlConnection.Close();
            }

            return items;
        }

        public string ExecuteSelectScalarCommand(string sqlCommand)
        {
            object reader = new object();

            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandText = sqlCommand;

                    reader = command.ExecuteScalar();
                }

                sqlConnection.Close();
            }

            return reader.ToString();
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

        public BindingSource ExecuteFillData(string sqlCommand)
        {
            var bindingSource = new BindingSource();

            using (var sqlConnection = new MySqlConnection(GetConnectionString()))
            {
                sqlConnection.Open();

                using (var dataAdapter = new MySqlDataAdapter())
                {
                    dataAdapter.SelectCommand = new MySqlCommand(sqlCommand, sqlConnection);
                    
                    using (var dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                        bindingSource.DataSource = dataTable;
                    }
                }

                sqlConnection.Close();

                return bindingSource;
            }
        }
    }
}
