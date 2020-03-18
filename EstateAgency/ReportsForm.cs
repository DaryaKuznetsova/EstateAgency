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
    public partial class ReportsForm : Form
    {
        SqlConnection SqlConnection;
        public ReportsForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            SqlConnection = sqlConnection;
            ComboBoxes(SqlConnection);
        }

        public void CreateChart(SqlConnection sqlConnection, DateTime date1, DateTime date2)
        {
            mId = new List<int>();
            int i = 0;
            foreach (string manager in Managers(sqlConnection))
            {
                int flats = Count(mId[i], 1, sqlConnection, date1, date2);
                int rooms = Count(mId[i], 2, sqlConnection, date1, date2);
                int houses = Count(mId[i], 3, sqlConnection, date1, date2);
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

        private int Count(int id, int typeId, SqlConnection sqlConnection, DateTime first, DateTime last)
        {
            int count = 0;
            string strCommand = string.Format("Select count(*) from trades " +
                "inner join Managers on Trades.ManagerId=Managers.Id " +
                "inner join EstateObjects on Trades.ItemId=EstateObjects.Id " +
                "where managers.id = @id " +
                "and estateobjects.realtytypeid=@type " +
                "and trades.date between @first and @last");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", typeId);
            command.Parameters.AddWithValue("@first", first);
            command.Parameters.AddWithValue("@last", last);
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

        private int TotalCount(SqlConnection sqlConnection, DateTime first, DateTime last)
        {
            int count = 0;
            string strCommand = string.Format("Select count(*) from trades " +
                "inner join EstateObjects on Trades.ItemId=EstateObjects.Id " +
                "where trades.date between @first and @last");
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            command.Parameters.AddWithValue("@first", first);
            command.Parameters.AddWithValue("@last", last);
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxes(SqlConnection SqlConnection)
        {
            SqlConnection.Open();
            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from managers";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                ManagerComboBox.DataSource = table;
                ManagerComboBox.ValueMember = "Id";
                ManagerComboBox.DisplayMember = "Surname";
            }
            SqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            CreateChart(SqlConnection, d1, d2);
            ManagerComboBox.DataSource = Managers(SqlConnection);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            GetInfo(ManagerComboBox.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
            string fileName = "";
            bool save = StatisticsForm.SavingIntoFile(ref fileName); // Название и путь файла выбраны успешно
            if (save)
            {
                try
                {
                    ExportWord.Report(ManagerComboBox.SelectedValue.ToString(),
                        dateTimePicker1.Value, dateTimePicker2.Value,
                        Flats, Rooms, Houses, Total, fileName);

                    MessageBox.Show("Изменения сохранены!");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
        }

        int Flats { get; set; }
        int Rooms { get; set; }
        int Houses { get; set; }
        int Total { get; set; }

        private void GetInfo(string name, DateTime date1, DateTime date2)
        {
            mId = new List<int>();
            int i = Managers(SqlConnection).IndexOf(name);

            Flats = Count(mId[i], 1, SqlConnection, date1, date2);
            Rooms = Count(mId[i], 2, SqlConnection, date1, date2);
            Houses = Count(mId[i], 3, SqlConnection, date1, date2);
            Total = TotalCount(SqlConnection, date1, date2);
        }

        private string Name(int id)
        {
            string name = "";
            List<string> managers = new List<string>();
            mId = new List<int>();
            string strCommand = string.Format("Select surname, name, patronymic FROM Managers " +
                "where id=@id");
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, SqlConnection);
            command.Parameters.AddWithValue("@id", id);
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
                SqlConnection.Close();
            }
            return name;
        }
    }
}
