using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class DeleteUpdateInsertMethods
    {
        public static void Delete(int deleteID, string currentTable, string currentID, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM {0} WHERE {1} = '{2}'", currentTable, currentID, deleteID);
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

        public static void Update(int updateID, int status, int owner, float  price, string address, int district,
            string description, int realtytype, int tradetype, float area, byte rooms, string landdescription, float landarea, SqlConnection sqlConnection)
        {
                SqlCommand command = sqlConnection.CreateCommand();
                string strcom = string.Format("UPDATE EstateObjects SET statusid=(@status), ownerid=(@owner), price=(@price), address=(@address), districtid=(@district), description=(@description), realtytypeid=(@realtytype), tradetypeid=(@tradetype), area=(@area), rooms=(@rooms)," +
                    "landdescription=(@landd), landarea=(@landa)" +
                    " WHERE Id='{0}'", updateID);
                command.CommandText = strcom;
                command.Parameters.Add("status", SqlDbType.NVarChar).Value = status;
                command.Parameters.Add("owner", SqlDbType.NVarChar).Value = owner;
            command.Parameters.Add("price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("district", SqlDbType.NVarChar).Value = district;
            command.Parameters.Add("description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("realtytype", SqlDbType.NVarChar).Value = realtytype;
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradetype;
            command.Parameters.Add("area", SqlDbType.NVarChar).Value = area;
            command.Parameters.Add("rooms", SqlDbType.NVarChar).Value = rooms;
            command.Parameters.Add("landd", SqlDbType.NVarChar).Value = landdescription;
            command.Parameters.Add("landa", SqlDbType.NVarChar).Value = landarea;
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

        public static void Insert(int status, int owner, float price, string address, int district,
    string description, int realtytype, int tradetype, float area, byte rooms, string landdescription, float landarea, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom = string.Format("insert into EstateObjects (statusid, ownerid, price, address, districtid, description, realtytypeid, tradetypeid, area, rooms, landdescription, landarea)" +
                "values (@status, @owner, @price, @address, @district, @description, @realtytype, @tradetype, @area, @rooms, @landd, @landa)");
            command.CommandText = strcom;
            command.Parameters.Add("status", SqlDbType.NVarChar).Value = status;
            command.Parameters.Add("owner", SqlDbType.NVarChar).Value = owner;
            command.Parameters.Add("price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("district", SqlDbType.NVarChar).Value = district;
            command.Parameters.Add("description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("realtytype", SqlDbType.NVarChar).Value = realtytype;
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradetype;
            command.Parameters.Add("area", SqlDbType.NVarChar).Value = area;
            command.Parameters.Add("rooms", SqlDbType.NVarChar).Value = rooms;
            command.Parameters.Add("landd", SqlDbType.NVarChar).Value = landdescription;
            command.Parameters.Add("landa", SqlDbType.NVarChar).Value = landarea;
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
