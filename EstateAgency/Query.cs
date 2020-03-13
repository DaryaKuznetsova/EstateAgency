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
            command.CommandText = string.Format("select {0} from EstateObjects where " +
                "realtytypeid=2 and tradetypeid=@tradetype " +
                "and price BETWEEN @minprice AND @maxprice " +
                "and area between @minarea and @maxarea and districtid in ({1})", parameters, districts);
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
            command.CommandText = string.Format("select {0} from EstateObjects where " +
                "realtytypeid=1 and tradetypeid=@tradetype " +
                "and price BETWEEN @minprice AND @maxprice " +
                "and area between @minarea and @maxarea and districtid in ({1}) and rooms in ({2})", parameters, districts, rooms);
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
            //command.CommandText = string.Format("select {0} from EstateObjects where " +
            //    "(realtytypeid=3 or realtytypeid=4) and tradetypeid=@tradetype " +
            //    "and price BETWEEN @minprice AND @maxprice " +
            //    "and area between @minarea and @maxarea " +
            //    "and landarea between @minlandarea and @maxlandarea " +
            //    "and districtid in ({1}) and rooms in ({2})", parameters, districts, rooms);
            command.CommandText = Room(parameters, districts, rooms);
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;
            command.Parameters.Add("minlandarea", SqlDbType.NVarChar).Value = minLandArea;
            command.Parameters.Add("maxlandarea", SqlDbType.NVarChar).Value = maxLandArea;
            return command;
        }

        private static string Room(string parameters, string districts, string rooms)
        {
            string res = string.Format("select {0} from EstateObjects e where " +
                "e.realtytypeid=2 " +
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
                "and e.price BETWEEN @minprice AND @maxprice " +
                "and e.area between @minarea and @maxarea " +
                "and e.landarea between @minlandarea and @maxlandarea " +
                "and e.districtid in ({1}) " +
                "and e.rooms in ({2})", parameters, districts, rooms);
            return res;
        }


        public static void AddPicture(int ObjectId, string path, SqlConnection sqlConnection)
        {
            InsertPicture(sqlConnection, path);
            int picId = SelectPictureId(sqlConnection, path);
            InsertPictureObjectLink(sqlConnection, ObjectId, picId);
        }

        private static void InsertPicture(SqlConnection sqlConnection, string path)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Pictures (picture) VALUES ( @picture)";
            command.Parameters.Add("picture", SqlDbType.NVarChar).Value = path;
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

        private static void InsertPictureObjectLink(SqlConnection sqlConnection, int ObjectId, int PictureId)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO PictureObjectLinks VALUES ( @ObjectId, @PictureId)";
            command.Parameters.Add("ObjectId", SqlDbType.NVarChar).Value = ObjectId;
            command.Parameters.Add("PictureId", SqlDbType.NVarChar).Value = PictureId;
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

        private static int SelectPictureId(SqlConnection sqlConnection, string path)
        {
            int id = 0;

            string strCommand = string.Format("Select id FROM pictures WHERE picture = '{0}'", path);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return id;
        }

        public static void DeletePicture(SqlConnection sqlConnection, string path, int ObjectId)
        {
            int PictureId = SelectPictureId(sqlConnection, path);
            DeleteLink(sqlConnection, ObjectId, PictureId);
            DeletePictureFromTable(sqlConnection, path);
        }

        private static void DeleteLink(SqlConnection sqlConnection, int ObjectId, int PictureId)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM PictureObjectLinks WHERE IdObject = '{0}' and IdPicture='{1}'", ObjectId, PictureId);
            command.CommandText = strCommand;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private static void DeletePictureFromTable(SqlConnection sqlConnection, string path)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM Pictures WHERE Picture = '{0}'", path);
            command.CommandText = strCommand;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static List<string> Images(List<string> images, SqlConnection sqlConnection, int id)
        {
            images = new List<string>();

            string strCommand = string.Format("Select Pictures.Picture" +
                " FROM EstateObjects" +
                " inner join PictureObjectLinks on EstateObjects.Id=PictureObjectLinks.IdObject" +
                " inner join Pictures on PictureObjectLinks.IdPicture=Pictures.Id" +
                " WHERE EstateObjects.Id = '{0}'", id);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    images.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }

            return images;
        }

        public static string[] Contacts(SqlConnection sqlConnection, int client, int item)
        {
            string[] res = new string[2];
            Managers(res, sqlConnection, item, client);
            return res;
        }

        private static void Managers(string[] res, SqlConnection sqlConnection, int item, int client)
        {
            string strCommand = string.Format("Select phone, email FROM Managers inner join Trades on Managers.Id=Trades.ManagerId where trades.ItemId = '{0}' and trades.Clientid = '{1}'", item, client);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
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
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom;
                strcom = string.Format("UPDATE EstateObjects SET statusid=4 WHERE Id='{0}'", item);
            command.CommandText = strcom;
            

            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("4");
            }
            catch(Exception w)
            {
                MessageBox.Show(w.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            UpdateTrade(sqlConnection, item, pType, pInstrument);
        }

        private static void UpdateTrade(SqlConnection sqlConnection, int item, int pType, int pInstrument)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom;
            strcom = string.Format("UPDATE Trades SET paymenttypeid='{0}', paymentinstrumentid='{1}' WHERE ItemId='{2}'", pType, pInstrument, item);
            command.CommandText = strcom;

            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private static SqlCommand SelectTradesCommand(DateTime firstDate, DateTime secondDate, SqlConnection sqlConnection, string parameters = "*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = string.Format("select {0} from Trades t where t.date BETWEEN @firstdate AND @seconddate", parameters);
            command.Parameters.Add("firstdate", SqlDbType.NVarChar).Value = firstDate;
            command.Parameters.Add("seconddate", SqlDbType.NVarChar).Value = secondDate;

            return command;
        }

        public static DataTable SelectTrades(DateTime firstDate, DateTime secondDate, SqlConnection sqlConnection, string parameters="*")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command = SelectTradesCommand(firstDate, secondDate, sqlConnection, parameters);
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


        private static string TradeObject(string parameters, string districts, string rooms)
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
            command.CommandText = TradeObject(parameters, districts, rooms);

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

        private static string Columns(string estate, string trade)
        {
            string res = "";
            if (String.Compare(estate, trade) == 0) res = estate;
            if(trade =="*"&& estate != "*")
            {
                string temp = "t.id, t.itemid, t.managerid, t.clientid, t.date, t.paymentid, t.paymentinstrument, ";
                res = temp + estate;
            }
            if (trade != "*" && estate == "*")
            {
                string temp = "e.id, e.statusid, e.ownerid, e.price, e.address, e.districtid, e.description, e.realtytypeid, e.tradetypeid, e.area, e.rooms, e.landdescription, e.landarea, ";
                res = temp + trade;
            }
            if(trade != "*" && estate != "*")
            {
                res=estate + ", " + trade;
            }
            return res;
        }
    }
}
