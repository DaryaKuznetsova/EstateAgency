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
    class Query
    {
        public static DataTable SelectEstateObjects(int realtyType, int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, float minLandArea, float maxLandArea, string districts, string rooms, SqlConnection sqlConnection, string parameters="*")
        {
            SqlCommand command = sqlConnection.CreateCommand();

            if (realtyType == 1) command = SelectFlats(tradeType, minPrice, maxPrice, minArea, maxArea, districts, rooms, sqlConnection, parameters );
            if (realtyType == 2) command= SelectRooms(tradeType, minPrice, maxPrice, minArea, maxArea, districts, sqlConnection, parameters );
            if (realtyType == 3|| realtyType == 4) command = SelectHouse(tradeType, minPrice, maxPrice, minArea, maxArea, districts, rooms, minLandArea, maxLandArea, sqlConnection, parameters );
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }


        private static SqlCommand SelectRooms(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, string districts, SqlConnection sqlConnection, string parameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = Room(parameters, districts);
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;

            return command;
        }

        private static SqlCommand SelectFlats(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, string districts, string rooms, SqlConnection sqlConnection, string parameters="*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = Flat(parameters, districts, rooms);
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;

            return command;
        }

        private static SqlCommand SelectHouse(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, string districts, string rooms, float minLandArea, float maxLandArea, SqlConnection sqlConnection, string parameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = House(parameters, districts, rooms);
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;
            command.Parameters.Add("minlandarea", SqlDbType.NVarChar).Value = minLandArea;
            command.Parameters.Add("maxlandarea", SqlDbType.NVarChar).Value = maxLandArea;
            return command;
        }

        private static string Room(string parameters, string districts)
        {
            string res = string.Format("select {0} from EstateObjects e where " +
                "e.realtytypeid=2 " +
                "and e.statusid=1 " +
                "and e.tradetypeid=@tradetype " +
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and e.districtid in ({1})", parameters, districts);
            return res;
        }

        private static string Flat(string parameters, string districts, string rooms)
        {
            string res= string.Format("select {0} from EstateObjects e where " +
                "e.realtytypeid=1 " +
                "and e.statusid=1 " +
                "and e.tradetypeid=@tradetype " +
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and e.districtid in ({1}) " +
                "and e.rooms in ({2})", parameters, districts, rooms);
            return res;
        }

        private static string House(string parameters, string districts, string rooms)
        {
            string res= string.Format("select {0} from EstateObjects e where " +
                "(e.realtytypeid=3 or e.realtytypeid=4) " +
                "and e.tradetypeid=@tradetype " +
                "and e.statusid=1 " +
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and e.landarea between @minlandarea and @maxlandarea " +
                "and e.districtid in ({1}) " +
                "and e.rooms in ({2})", parameters, districts, rooms);
            return res;
        }
    }
}
