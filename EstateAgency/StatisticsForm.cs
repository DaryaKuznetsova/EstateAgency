using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        public void CreateChart(SqlConnection sqlConnection)
        {
            int i = 0;
            foreach (string manager in Managers(sqlConnection))
            {
                int flats = Count(mId[i], 1, sqlConnection);
                int rooms = Count(mId[i], 2, sqlConnection);
                int houses = Count(mId[i], 3, sqlConnection);
                i++;
                AddSeries(manager, flats, rooms, houses);
            }
        }

        private List<int> mId;

        private void AddSeries(string managerName, int flats, int rooms, int houses)
        {
            chart1.Series["Квартиры"].Points.AddXY(managerName, flats);
            chart1.Series["Комнаты"].Points.AddXY(managerName, rooms);
            chart1.Series["Дома"].Points.AddXY(managerName, houses);
        }

        private int Count(int id, int typeId, SqlConnection sqlConnection)
        {
            int count = 0;
            string strCommand = string.Format("Select count(*) from trades " +
                "inner join Managers on Trades.ManagerId=Managers.Id " +
                "inner join EstateObjects on Trades.ItemId=EstateObjects.Id " +
                "where managers.id = @id " +
                "and estateobjects.realtytypeid=@type");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", typeId);
            try
            {
                count = (Int32)command.ExecuteScalar();
            }
            finally
            {
                sqlConnection.Close();
            }
            return count;
        }

        private List<string> Managers(SqlConnection sqlConnection)
        {
            List<string> managers = new List<string>();
            mId = new List<int>();
            string strCommand = string.Format("Select surname, name, patronymic, id FROM Managers");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string temp = reader.GetString(0) + " " + reader.GetString(1)[0] + "." + reader.GetString(2)[0] + ".";
                    managers.Add(temp);
                    mId.Add(reader.GetInt32(3));
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return managers;
        }
    }
}
