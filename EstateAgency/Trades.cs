using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Trades
    {
        public static void CreateClientObjectLink(SqlConnection sqlConnection, int ClientId, int ObjectId)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom = string.Format("insert into ClientObjectLinks (ClientId, ObjectId)" +
                "values (@client, @object)");
            command.CommandText = strcom;
            command.Parameters.Add("client", SqlDbType.NVarChar).Value = ClientId;
            command.Parameters.Add("object", SqlDbType.NVarChar).Value = ObjectId;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void CreateTrade(SqlConnection sqlConnection, int item, int manager)
        {
            int client = FindClient(sqlConnection, item);
            DateTime date = new DateTime();
            date = DateTime.Today;
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom = string.Format("insert into trades (itemid, managerid, clientid, date)" +
                " values (@item, @manager, @client, @date)");
            command.CommandText = strcom;
            command.Parameters.Add("item", SqlDbType.NVarChar).Value = item;
            command.Parameters.Add("manager", SqlDbType.NVarChar).Value = manager;
            command.Parameters.Add("client", SqlDbType.NVarChar).Value = client;
            command.Parameters.Add("date", SqlDbType.NVarChar).Value = date;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private static int FindClient(SqlConnection sqlConnection, int id)
        {
            int client = -1;
            string strCommand = string.Format("Select clientid FROM ClientObjectLinks WHERE objectid = @id");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    client = reader.GetInt32(0);
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return client;
        }
    }
}
