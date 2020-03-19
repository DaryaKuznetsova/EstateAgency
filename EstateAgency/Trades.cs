using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private static int CurrentTrade(SqlConnection sqlConnection)
        {
            int trade = -1;
            string strCommand = string.Format("select max(id) from Trades");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    trade = reader.GetInt32(0);
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return trade;
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

        public static string[] Contacts(SqlConnection sqlConnection, int client, int item)
        {
            string[] res = new string[2];
            Managers(res, sqlConnection, item, client);
            return res;
        }

        private static void Managers(string[] res, SqlConnection sqlConnection, int item, int client)
        {
            string strCommand = string.Format("Select phone, email FROM Managers inner join Trades on Managers.Id=Trades.ManagerId " +
                "where trades.ItemId = @item and trades.Clientid = @client");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("@item", item);
            command.Parameters.AddWithValue("@client", client);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    res[0] = reader.GetValue(0).ToString();
                    res[1] = reader.GetValue(1).ToString();
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
        }

        public static void FinalTrade(SqlConnection sqlConnection, int item, int pType, int pInstrument)
        {
            //SqlCommand command = sqlConnection.CreateCommand();
            //string strcom;
            //strcom = string.Format("UPDATE EstateObjects SET statusid=4 WHERE Id=@item");
            //command.CommandText = strcom;
            //command.Parameters.AddWithValue("@item", item);

            //sqlConnection.Open();
            //try
            //{
            //    command.ExecuteNonQuery();
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}
            EstateObjects.UpdateStatus(sqlConnection, item, 4);
            UpdateTrade(sqlConnection, item, pType, pInstrument);
        }

        private static void UpdateTrade(SqlConnection sqlConnection, int item, int pType, int pInstrument)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom;
            strcom = string.Format("UPDATE Trades SET paymenttypeid=(@ptid), paymentinstrumentid=(@piid) WHERE ItemId=@item", pType, pInstrument, item);
            command.CommandText = strcom;
            command.Parameters.AddWithValue("@ptid", pType);
            command.Parameters.AddWithValue("@piid", pInstrument);
            command.Parameters.AddWithValue("@item", item);

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

        public static void DeleteTrade(SqlConnection sqlConnection, int linkId)
        {
            int[] tradeItemId = TradeItemId(sqlConnection, linkId);
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM Trades WHERE id = @deleteid");
            command.CommandText = strCommand;
            command.Parameters.Add("deleteid", SqlDbType.NVarChar).Value = tradeItemId[0];
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
            EstateObjects.UpdateStatus(sqlConnection, tradeItemId[1], 1);
        }

        private static int[] TradeItemId(SqlConnection sqlConnection, int id)
        {
            int[] res = new int[2];
            int trade = -1;
            int item = -1;
            string strCommand = string.Format("Select tradeid, objectid FROM ClientObjectLinks WHERE id=@id");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    trade = reader.GetInt32(0);
                    item = reader.GetInt32(1);
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }

            res[0] = trade;
            res[1] = item;
            return res;
        }

        public static void DeleteLink(SqlConnection sqlConnection, int deleteid)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM ClientObjectLinks WHERE id = @deleteid");
            command.CommandText = strCommand;
            command.Parameters.Add("deleteid", SqlDbType.NVarChar).Value = deleteid;
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

        public static void UpdateLinksWithTrade(SqlConnection sqlConnection)
        {
            int trade = CurrentTrade(sqlConnection);

            SqlCommand command = sqlConnection.CreateCommand();
            string strcom;
            strcom = string.Format("UPDATE ClientObjectLinks SET tradeid=(@ptid)");
            command.CommandText = strcom;
            command.Parameters.AddWithValue("@ptid", trade);

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
    }
}
