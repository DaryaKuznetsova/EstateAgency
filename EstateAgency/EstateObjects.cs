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
    class EstateObjects
    {
        public static void Delete(int deleteID, string currentTable, string currentID, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strCommand = string.Format("DELETE FROM EstateObjects WHERE @currentid = @deleteid");
            command.CommandText = strCommand;
            command.Parameters.Add("currentid", SqlDbType.NVarChar).Value = currentID;
            command.Parameters.Add("deleteid", SqlDbType.NVarChar).Value = deleteID;
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

        public static void Update(SqlConnection sqlConnection, int updateID, int status, int owner, float price, string address, int district,
            string description, int realtytype, int tradetype, float area, byte rooms = 0, string landdescription = null, float landarea = 0)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom;
            if (realtytype == 3 || realtytype == 4)
            {
                strcom = string.Format("UPDATE EstateObjects SET statusid=(@status), ownerid=(@owner), price=(@price), address=(@address), districtid=(@district), description=(@description), realtytypeid=(@realtytype), tradetypeid=(@tradetype), area=(@area), rooms=(@rooms)," +
    "landdescription=(@landd), landarea=(@landa)" +
    " WHERE Id='{0}'", updateID);

                command.Parameters.Add("landd", SqlDbType.NVarChar).Value = landdescription;
                command.Parameters.Add("landa", SqlDbType.NVarChar).Value = landarea;
            }

            else if (realtytype == 1)
            {
                strcom = string.Format("UPDATE EstateObjects SET statusid=(@status), ownerid=(@owner), price=(@price), address=(@address), districtid=(@district), description=(@description), realtytypeid=(@realtytype), tradetypeid=(@tradetype), area=(@area), rooms=(@rooms)" +
" WHERE Id='{0}'", updateID);
                command.Parameters.Add("rooms", SqlDbType.NVarChar).Value = rooms;
            }
            else
                strcom = string.Format("UPDATE EstateObjects SET statusid=(@status), ownerid=(@owner), price=(@price), address=(@address), districtid=(@district), description=(@description), realtytypeid=(@realtytype), tradetypeid=(@tradetype), area=(@area)" +
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

        public static void Insert(SqlConnection sqlConnection, int status, int owner, float price, string address, int district,
    string description, int realtytype, int tradetype, float area, byte rooms = 0, string landdescription = null, float landarea = 0)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            string strcom1 = string.Format("insert into EstateObjects (statusid, ownerid, price, address, districtid, description, realtytypeid, tradetypeid, area, rooms)" +
                "values (@status, @owner, @price, @address, @district, @description, @realtytype, @tradetype, @area, @rooms)");
            string strcom2 = string.Format("insert into EstateObjects (statusid, ownerid, price, address, districtid, description, realtytypeid, tradetypeid, area)" +
    "values (@status, @owner, @price, @address, @district, @description, @realtytype, @tradetype, @area)");
            string strcom3 = string.Format("insert into EstateObjects (statusid, ownerid, price, address, districtid, description, realtytypeid, tradetypeid, area, rooms, landdescription, landarea)" +
    "values (@status, @owner, @price, @address, @district, @description, @realtytype, @tradetype, @area, @rooms, @landd, @landa)");

            if(realtytype==1)
            {
                command.CommandText = strcom1;
                command.Parameters.Add("rooms", SqlDbType.NVarChar).Value = rooms;
            }

            if (realtytype == 2)
                command.CommandText = strcom2;

            if (realtytype == 3)
            {
                command.CommandText = strcom3;
                command.Parameters.Add("landd", SqlDbType.NVarChar).Value = landdescription;
                command.Parameters.Add("landa", SqlDbType.NVarChar).Value = landarea;
                command.Parameters.Add("rooms", SqlDbType.NVarChar).Value = rooms;
            }
            command.Parameters.Add("status", SqlDbType.NVarChar).Value = status;
            command.Parameters.Add("owner", SqlDbType.NVarChar).Value = owner;
            command.Parameters.Add("price", SqlDbType.NVarChar).Value = price;
            command.Parameters.Add("address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("district", SqlDbType.NVarChar).Value = district;
            command.Parameters.Add("description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("realtytype", SqlDbType.NVarChar).Value = realtytype;
            command.Parameters.Add("tradetype", SqlDbType.NVarChar).Value = tradetype;
            command.Parameters.Add("area", SqlDbType.NVarChar).Value = area;


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

        public static void CreateItemInfo(SqlConnection SqlConnection, int id,
            out string StatusComboBox, out string OwnerComboBox, out string PriceTextBox,
            out string AddressTextBox, out string DistrictComboBox, out string DescriptionTextBox,
            out string RealtyTypeComboBox, out string TradeTypeComboBox, out string areaTextBox,
            out string RoomsTextBox, out string LandTextBox, out string LandAreaTextBox)
        {
            StatusComboBox = "";
            OwnerComboBox = "";
            PriceTextBox = "";
            AddressTextBox = "";
            DistrictComboBox = "";
            DescriptionTextBox = "";
            RealtyTypeComboBox = "";
            TradeTypeComboBox = "";
            areaTextBox = "";
            RoomsTextBox = "";
            LandTextBox = "";
            LandAreaTextBox = "";

            string strCommand = string.Format("Select * FROM EstateObjects WHERE Id = @id");
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, SqlConnection);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    StatusComboBox = reader.GetValue(1).ToString();
                    OwnerComboBox = reader.GetValue(2).ToString();
                    PriceTextBox = reader.GetValue(3).ToString();
                    AddressTextBox = reader.GetValue(4).ToString();
                    DistrictComboBox = reader.GetValue(5).ToString();
                    DescriptionTextBox = reader.GetValue(6).ToString();
                    RealtyTypeComboBox = reader.GetValue(7).ToString();
                    TradeTypeComboBox = reader.GetValue(8).ToString();
                    areaTextBox = reader.GetValue(9).ToString();
                    RoomsTextBox = reader.GetValue(10).ToString();
                    LandTextBox = reader.GetValue(11).ToString();
                    LandAreaTextBox = reader.GetValue(12).ToString();
                }
            }
            finally
            {
                reader.Close();
                SqlConnection.Close();
            }
        }
    }
}
