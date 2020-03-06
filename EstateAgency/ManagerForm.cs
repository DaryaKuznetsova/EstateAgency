using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EstateAgency
{
    public partial class ManagerForm : Form
    {
        public SqlConnection SqlConnection { get;set; }
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public ManagerForm()
        {
            InitializeComponent();
            SqlConnection = new SqlConnection(connectionString);
            dataGridView1.DataSource = ShowTable.DisplayTable("EstateObjects", SqlConnection);
            ComboBoxes();
        }

        public void DataLoad()
        {
            dataGridView1.DataSource = ShowTable.DisplayTable("EstateObjects", SqlConnection);
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

        private void CreateDataGridView()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["StatusId"].Visible = false;
            dataGridView1.Columns["OwnerId"].Visible = false;
            dataGridView1.Columns["DistrictId"].Visible = false;
            dataGridView1.Columns["Description"].Visible = false;
            dataGridView1.Columns["RealtyTypeId"].Visible = false;
            dataGridView1.Columns["TradeTypeId"].Visible = false;
            dataGridView1.Columns["Area"].Visible = false;
            dataGridView1.Columns["LandDescription"].Visible = false;
            dataGridView1.Columns["LandArea"].Visible = false;
            dataGridView1.Columns["Furniture"].Visible = false;
            dataGridView1.Columns["Trades"].Visible = false;
            dataGridView1.Columns["Pictures"].Visible = false;
            dataGridView1.Columns["Owners"].Visible = false;
            dataGridView1.Columns["Districts"].Visible = false;
            dataGridView1.Columns["Statuses"].Visible = false;
            dataGridView1.Columns["RealtyTypes"].Visible = false;
            dataGridView1.Columns["TradeTypes"].Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm(SqlConnection);
            authorizationForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int realtyType = Convert.ToInt32(RealtyTypeComboBox.SelectedValue);
            int tradeType= Convert.ToInt32(TradeTypeComboBox.SelectedValue);
            float minPrice = (float)Convert.ToDouble(PriceMinTextBox.Text);
            float maxPrice = (float)Convert.ToDouble(PriceMaxTextBox.Text);
            float minArea = (float)Convert.ToDouble(AreaMinTextBox.Text);
            float maxArea = (float)Convert.ToDouble(AreaMaxTextBox.Text);
            var elements = DistrictCheckedListBox.CheckedIndices;
            List<int> districts = new List<int>();
            foreach (DataRowView indexChecked in DistrictCheckedListBox.CheckedItems)
            {
                //districts.Add(Convert.ToInt32(indexChecked));
               // MessageBox.Show(indexChecked.);
            }

            int d1=-1;
            int d2=-1;
            int d3=-1;
            int d4=-1;
            int d5=-1;
            int d6=-1;
            int d7=-1;
            try
            {
                d1 = districts[0];
                MessageBox.Show(d1.ToString());
                d2 = districts[1];
                MessageBox.Show(d2.ToString());
                d3 = districts[2];
                MessageBox.Show(d3.ToString());
                d4 = districts[3];
                MessageBox.Show(d4.ToString());
                d5 = districts[4];
                MessageBox.Show(d5.ToString());
                d6 = districts[5];
                MessageBox.Show(d6.ToString());
                d7 = districts[6];
                MessageBox.Show(d7.ToString());
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }

            float minLandArea = (float)Convert.ToDouble(LandAreaMinTextBox.Text);
            float maxLandArea = (float)Convert.ToDouble(LandAreaMaxTextBox.Text);;
            List<byte> rooms = new List<byte>();
            foreach (int indexChecked in RoomsCheckedListBox.CheckedIndices)
                rooms.Add(Convert.ToByte(indexChecked));

            dataGridView1.DataSource= Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, SqlConnection, d1, d2, d3, d4, d5, d6, d7);
        }

        private void addSMI_Click(object sender, EventArgs e)
        {
            ItemInfoForm itemf = new ItemInfoForm(SqlConnection, -1);
            itemf.ShowDialog();
            DataLoad();
        }

        private void changeSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.ShowDialog();
            DataLoad();
        }

        private void deleteSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.ShowDialog();
            DataLoad();
        }

        void Block()
        {
            if (RealtyTypeComboBox.SelectedIndex == 1 || RealtyTypeComboBox.SelectedIndex == 2)
            {
                LandAreaMinTextBox.Enabled = false;
                LandAreaMaxTextBox.Enabled = false;
            }
            else
            {
                LandAreaMinTextBox.Enabled = true ;
                LandAreaMaxTextBox.Enabled = true ;
            }
            if(RealtyTypeComboBox.SelectedIndex == 2)
                RoomsCheckedListBox.Enabled = false;
            else RoomsCheckedListBox.Enabled = true;
        }

        private void MakeVisible()
        {
            LandAreaMinTextBox.Visible = true;
            LandAreaMaxTextBox.Visible = true;
            RoomsCheckedListBox.Visible = true;
        }

        private void RealtyTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            Block();
        }
    }
}
