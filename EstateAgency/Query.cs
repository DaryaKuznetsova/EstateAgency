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
        public static DataTable SelectEstateObjects(int realtyType, int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, float minLandArea, float maxLandArea, SqlConnection sqlConnection,
            int d1 = -1, int d2 = -1, int d3 = -1, int d4 = -1, int d5 = -1, int d6 = -1, int d7 = -1)
        {
            if (realtyType == 2) return SelectRooms(tradeType, minPrice, maxPrice, minArea, maxArea, sqlConnection,
            d1 = -1, d2 = -1, d3 = -1, d4 = -1, d5 = -1, d6 = -1, d7 = -1);
            else return null;
        }

        private static DataTable SelectRooms(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, SqlConnection sqlConnection,
            int d1=-1, int d2=-1, int d3 = -1, int d4 = -1, int d5 = -1, int d6 = -1, int d7 = -1)
        {
            DataTable dt = new DataTable();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select * from EstateObjects where " +
                "realtytypeid=2 and tradetypeid=@tradetype " +
                "and price BETWEEN @minprice AND @maxprice " +
                "and area between @minarea and @maxarea and (districtid=4 or districtid=3)";
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradeType;
            command.Parameters.Add("minprice", SqlDbType.NVarChar).Value = minPrice ;
            command.Parameters.Add("maxprice", SqlDbType.NVarChar).Value = maxPrice ;
            command.Parameters.Add("minarea", SqlDbType.NVarChar).Value = minArea ;
            command.Parameters.Add("maxarea", SqlDbType.NVarChar).Value = maxArea;
            //command.Parameters.Add("d1", SqlDbType.NVarChar).Value = d1;
            //command.Parameters.Add("d2", SqlDbType.NVarChar).Value = d2;
            //command.Parameters.Add("d3", SqlDbType.NVarChar).Value = d3;
            //command.Parameters.Add("d4", SqlDbType.NVarChar).Value = d4;
            //command.Parameters.Add("d5", SqlDbType.NVarChar).Value = d5;
            //command.Parameters.Add("d6", SqlDbType.NVarChar).Value = d6;
            //command.Parameters.Add("d7", SqlDbType.NVarChar).Value = d7;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;

        }

        private static void SelectFlats(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, List<int> district, List<byte> rooms, SqlConnection sqlConnection)
        {
            // 1  " +
            //"and districtid in (@d1, @d2, @d3, @d4, @d5, @d6, @d7)
        }

        private static void SelectHouse(int tradeType, float minPrice, float maxPrice, float minArea, float maxArea, List<int> district, List<byte> rooms, float minLandArea, float maxLandArea, SqlConnection sqlConnection)
        {
            //3
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
    }
}
