using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        private static string JoinTradeObjectCommand(string parameters, string districts, string rooms)
        {
            string res = string.Format("select {0} " +
                "from EstateObjects e " +
                "inner join Trades t on e.Id=t.ItemId " +
                "where e.realtytypeid=@realtytype " +
                "and e.tradetypeid=@tradetype " +
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and (e.landarea between @minlandarea and @maxlandarea or e.landarea is NULL) " +
                "and e.districtid in ({1}) " +
                "and (e.rooms in ({2}) or e.rooms is NULL) " +
                "and t.date between @firstdate and @seconddate", parameters, districts, rooms);
            return res;
        }

        public static DataTable JoinTradeObject(DateTime firstDate, DateTime secondDate, int realtyType, int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, float minLandArea, float maxLandArea, string districts, string rooms, SqlConnection sqlConnection, string estateParameters = "*", string tradeParameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string parameters = Columns(estateParameters, tradeParameters);
            command.CommandText = JoinTradeObjectCommand(parameters, districts, rooms);

            command.Parameters.Add("realtytype", SqlDbType.NVarChar).Value = realtyType;
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

        private static string Columns(string estate, string trade)
        {
            string res = "";
            if (String.Compare(estate, trade) == 0) res = estate;
            if (trade == "*" && estate != "*")
            {
                string temp = "t.id, t.itemid, t.managerid, t.clientid, t.date, t.paymentid, t.paymentinstrument, ";
                res = temp + estate;
            }
            if (trade != "*" && estate == "*")
            {
                string temp = "e.id, e.statusid, e.ownerid, e.price, e.address, e.districtid, e.description, e.realtytypeid, e.tradetypeid, e.area, e.rooms, e.landdescription, e.landarea, ";
                res = temp + trade;
            }
            if (trade != "*" && estate != "*")
            {
                res = estate + ", " + trade;
            }
            return res;
        }
    }
}
