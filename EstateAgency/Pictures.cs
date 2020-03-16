using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Pictures
    {
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
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }

            return images;
        }
    }
}
