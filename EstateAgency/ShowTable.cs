﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    class ShowTable
    {
        public static DataTable DisplayTable(string tableName, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM " + tableName;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error!");
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
