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
    class CompoundStatistics
    {
        private static SqlCommand SelectTradesCommand(DateTime firstDate, DateTime secondDate, SqlConnection sqlConnection, string parameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = string.Format("select {0} from Trades t where t.date BETWEEN @firstdate AND @seconddate", parameters);
            command.Parameters.Add("firstdate", SqlDbType.NVarChar).Value = firstDate;
            command.Parameters.Add("seconddate", SqlDbType.NVarChar).Value = secondDate;

            return command;
        }

        public static DataTable SelectTrades(DateTime firstDate, DateTime secondDate, SqlConnection sqlConnection, string parameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command = SelectTradesCommand(firstDate, secondDate, sqlConnection, parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        public static DataTable SelectClients(SqlConnection sqlConnection, string clientParameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = string.Format("select {0} from clients c", clientParameters);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        private static string JoinClinetTradeCommand(string parameters)
        {
            string res = string.Format("select {0} " +
    "from Clients c " +
    "inner join Trades t on c.Id=t.ClientId " +
    "where t.date between @firstdate and @seconddate", parameters);
            return res;
        }

        public static DataTable JoinClientTrade(DateTime firstDate, DateTime secondDate, SqlConnection sqlConnection, string tradeParameters, string clientParameters)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string parameters = ClientTradeColumns(tradeParameters, clientParameters);
            command.CommandText = JoinClinetTradeCommand(parameters);

            command.Parameters.Add("firstdate", SqlDbType.NVarChar).Value = firstDate;
            command.Parameters.Add("seconddate", SqlDbType.NVarChar).Value = secondDate;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        private static string JoinClientTradeObjectCommand(string parameters, string districts, string rooms)
        {
            string res = string.Format("select {0} " +
                "from Trades t " +
                "inner join EstateObjects e on t.ItemId=e.Id " +
                "inner join Clients c on t.ClientId=c.Id " +
                "where e.realtytypeid=@realtytype " +
                "and e.tradetypeid=@tradetype " +
                "and e.statusid=@status " +
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and (e.landarea between @minlandarea and @maxlandarea or e.landarea is NULL) " +
                "and e.districtid in ({1}) " +
                "and (e.rooms in ({2}) or e.rooms is NULL) " +
                "and t.date between @firstdate and @seconddate", parameters, districts, rooms);
            return res;
        }

        public static DataTable JoinClientTradeObject(DateTime firstDate, DateTime secondDate,
            int status, int realtyType, int tradeType, float minPrice, float maxPrice,
            float minArea, float maxArea, float minLandArea, float maxLandArea,
            string districts, string rooms, SqlConnection sqlConnection,
            string estateParameters, string tradeParameters, string clientParameters, bool withClient)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string parameters = AllColumns(estateParameters, tradeParameters, clientParameters, withClient);
            command.CommandText = JoinClientTradeObjectCommand(parameters, districts, rooms);

            command.Parameters.Add("realtytype", SqlDbType.NVarChar).Value = realtyType;
            command.Parameters.Add("status", SqlDbType.NVarChar).Value = status;
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;
            command.Parameters.Add("minlandarea", SqlDbType.NVarChar).Value = minLandArea;
            command.Parameters.Add("maxlandarea", SqlDbType.NVarChar).Value = maxLandArea;
            command.Parameters.Add("firstdate", SqlDbType.NVarChar).Value = firstDate;
            command.Parameters.Add("seconddate", SqlDbType.NVarChar).Value = secondDate;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        private static string ClientTradeColumns(string trade, string client)
        {
            string res = "";
            if (String.Compare(client, trade) == 0) res = client;
            if (trade == "*" && client != "*")
            {
                string temp = "t.id, t.itemid, t.managerid, t.clientid, t.date, t.paymentid, t.paymentinstrument, ";
                res = temp + client;
            }
            if (trade != "*" && client == "*")
            {
                string temp = "c.id, c.Surname, c.Name, c.Patronymic, c.Phone, c.Email, ";
                res = temp + trade;
            }
            if (trade != "*" && client != "*")
            {
                res = client + ", " + trade;
            }
            return res;
        }

        private static string AllColumns(string estate, string trade, string client, bool withClient)
        {
            if (!withClient) client = "";
            string res = "";
            string tradeTemp = "t.id, t.itemid, t.managerid, t.clientid, t.date, t.paymenttypeid, t.paymentinstrumentid, ";
            string clientTemp = "c.id, c.Surname, c.Name, c.Patronymic, c.Phone, c.Email, ";
            string estateTemp = "e.id, e.statusid, e.price, e.address, e.ownerid, e.districtid, e.description, e.realtytypeid, e.tradetypeid, e.rooms, e.landarea, e.landdescription, ";

            if (trade == "*" && estate == "*" && client == "*")
                res = "*";

            if (trade == "*" && estate == "*" && client!="*")
                res = tradeTemp + estateTemp + client;

            if (trade == "*" && estate != "*" && client == "*")
                res = tradeTemp + clientTemp + estate;

            if (trade == "*" && estate != "*" && client != "*")
                res = tradeTemp + estate + ", " + client;

            if (trade != "*" && estate == "*" && client == "*")
                res = clientTemp + estateTemp+ trade;

            if (trade != "*" && estate == "*" && client != "*")
                res = trade + ", " + estateTemp  + client;

            if (trade != "*" && estate != "*" && client == "*")
                res = trade + ", " + estate + ", " + client;

            if (trade != "*" && estate != "*" && client != "*")
                res = trade+", " + estate + ", " + client;

            if(!withClient)
            if (res[res.Length - 2] == ',') res = res.Substring(0, res.Length - 2);
            return res;
        }

    }
}
