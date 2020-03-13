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
    public partial class ReportForm : Form
    {
        SqlConnection SqlConnection;

        public ReportForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            SqlConnection = sqlConnection;
            CheckedListBoxes();
            TextBoxes();
            ComboBoxes();
        }

        private void CheckedListBoxes()
        {
            SqlConnection.Open();
            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Trades'";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                TradeColumnsListBox.DataSource = table;
                TradeColumnsListBox.ValueMember = "column_name";
                TradeColumnsListBox.DisplayMember = "column_name";

            }

            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'EstateObjects'";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                EstateObjectColumnsListBox.DataSource = table;
                EstateObjectColumnsListBox.ValueMember = "column_name";
                EstateObjectColumnsListBox.DisplayMember = "column_name";
            }

            SqlConnection.Close();
        }

        private void TextBoxes()
        {
            PriceMinTextBox.Min = true;
            PriceMaxTextBox.Min = false;
            AreaMinTextBox.Min = true;
            AreaMaxTextBox.Min = false;
            LandAreaMinTextBox.Min = true;
            LandAreaMaxTextBox.Min = false;
            PriceMaxTextBox.Text = "До";
            PriceMinTextBox.Text = "От";
            AreaMaxTextBox.Text = "До";
            AreaMinTextBox.Text = "От";
            LandAreaMaxTextBox.Text = "До";
            LandAreaMinTextBox.Text = "От";
        }

        private void ComboBoxes()
        {
            SqlConnection.Open();
            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from RealtyTypes";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                RealtyTypeComboBox.DataSource = table;
                RealtyTypeComboBox.ValueMember = "Id";
                RealtyTypeComboBox.DisplayMember = "Name";

            }

            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from TradeTypes";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                TradeTypeComboBox.DataSource = table;
                TradeTypeComboBox.ValueMember = "Id";
                TradeTypeComboBox.DisplayMember = "Name";

            }

            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from Districts";
                var table2 = new DataTable();
                table2.Load(command.ExecuteReader());
                DistrictCheckedListBox.DataSource = table2;
                DistrictCheckedListBox.ValueMember = "Id";
                DistrictCheckedListBox.DisplayMember = "Name";
            }

            SqlConnection.Close();
        }

        private string CreateParameters(CheckedListBox clb)
        {
            string res = "";
            if (clb.CheckedItems.Count == 0)
                if (clb.Name == "DistrictCheckedListBox") res = "1, 2, 3, 4, 6, 7, 8";
                else res = "1, 2, 3, 4, 5, 6, 7";
            else
            {
                if (clb.Name == "DistrictCheckedListBox")
                {
                    for (int i = 0; i < clb.CheckedItems.Count; i++)
                    {
                        DataRowView drv = (DataRowView)DistrictCheckedListBox.CheckedItems[i];
                        int valueOfItem = Convert.ToInt32(drv["Id"]);
                        res = res + valueOfItem + ", ";
                    }
                }
                else
                    for (int i = 0; i < clb.CheckedItems.Count; i++)
                    {
                        res = res + RoomsCheckedListBox.CheckedItems[i] + ", ";
                    }
                res = res.Substring(0, res.Length - 2);
            }
            return res;
        }

        private string CreateSelectStringColumns(CheckedListBox clb, string pref)
        {
            string res = "";
            if (clb.CheckedItems.Count == 0)
            {
                res = "*";
            }
            else
            {
                for (int i = 0; i < clb.CheckedItems.Count; i++)
                {
                    DataRowView drv = (DataRowView)clb.CheckedItems[i];
                    string valueOfItem = Convert.ToString(drv["column_name"]);
                    valueOfItem = pref + "." + valueOfItem;

                    res = res + valueOfItem + ", ";
                }
                res = res.Substring(0, res.Length - 2);
            }
            return res;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int realtyType = Convert.ToInt32(RealtyTypeComboBox.SelectedValue);
            int tradeType = Convert.ToInt32(TradeTypeComboBox.SelectedValue);
            float minPrice = PriceMinTextBox.Value;
            float maxPrice = PriceMaxTextBox.Value;
            float minArea = AreaMinTextBox.Value;
            float maxArea = AreaMaxTextBox.Value;
            float minLandArea = LandAreaMinTextBox.Value;
            float maxLandArea = LandAreaMaxTextBox.Value;
            DateTime firstDate = FirstDatePicker.Value;
            DateTime secondDate = SecondDatePicker.Value;

            var elements = DistrictCheckedListBox.CheckedItems;
            string districts = CreateParameters(DistrictCheckedListBox);
            string rooms = CreateParameters(RoomsCheckedListBox);

            string tradesParameters = CreateSelectStringColumns(TradeColumnsListBox, "t");
            string estateobjectsParameters = CreateSelectStringColumns(EstateObjectColumnsListBox, "e");

            if(TableNameListBox.CheckedItems.Count!=0)
            {
                if (TableNameListBox.CheckedItems.Count == 1)
                {
                    if (TableNameListBox.CheckedItems[0].ToString() == "Сделки")
                        dataGridView1.DataSource = Query.SelectTrades(firstDate, secondDate, SqlConnection, tradesParameters);
                    if (TableNameListBox.CheckedItems[0].ToString() == "Объекты недвижимости")
                        dataGridView1.DataSource = Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection, estateobjectsParameters);
                }
                else dataGridView1.DataSource = Query.JoinTradeObject(firstDate, secondDate, realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection, estateobjectsParameters, tradesParameters);
                DataTable = (DataTable)dataGridView1.DataSource;
            }
        }

        private static DataTable DataTable;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            bool save = SavingIntoFile(ref fileName); // Название и путь файла выбраны успешно
            if (save)
            {
                try
                {
                    //DataTable.ExportToExcel(fileName);
                    ExcelExport.ExportFiles(DataTable, fileName);
                    MessageBox.Show("Изменения сохранены!");
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }               
            }
        }

        static bool SavingIntoFile(ref string filename) // Выбор пути сохранения и проверка расширения
        {
            bool ok = false;
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "Файлы Excel|*.xlsx;*.xls";
            if (SFD.ShowDialog() == DialogResult.Cancel)
                return false;

            filename = SFD.FileName;
            string sss = "";
            string ssss = "";
            if (filename.Length >= 3)
            {
                sss = filename.Substring(filename.Length - 3);
                ssss = filename.Substring(filename.Length - 4);
            }
            if (sss != "xls" && ssss != "xlsx")
            {
                MessageBox.Show("Неверное расширение");
                ok = false;
            }
            else ok = true;
            return ok;
        }
    }
}
