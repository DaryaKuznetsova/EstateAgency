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
        public int ClientId { get; set; }
        public int ManagerId { get; set; }
        public SqlConnection SqlConnection { get;set; }
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public ManagerForm()
        {
            InitializeComponent();
            SqlConnection = new SqlConnection(connectionString);
            dataGridView1.DataSource = ShowTable.DisplayTable("EstateObjects", SqlConnection);
            ComboBoxes();
            TextBoxes();
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm(this, SqlConnection);
            authorizationForm.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int realtyType = Convert.ToInt32(RealtyTypeComboBox.SelectedValue);
            int tradeType = Convert.ToInt32(TradeTypeComboBox.SelectedValue);
            float minPrice = PriceMinTextBox.Value;
            float maxPrice = PriceMaxTextBox.Value;
            float minArea = AreaMinTextBox.Value;
            float maxArea = AreaMaxTextBox.Value;
            float minLandArea = LandAreaMinTextBox.Value;
            float maxLandArea = LandAreaMaxTextBox.Value;

            var elements = DistrictCheckedListBox.CheckedItems;
            string districts = CreateParameters(DistrictCheckedListBox);
            string rooms = CreateParameters(RoomsCheckedListBox);

            dataGridView1.DataSource= Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection);
        }

        private string CreateParameters(CheckedListBox clb)
        {
            string res = "";
            if (clb.CheckedItems.Count == 0)
                if (clb.Name == "DistrictCheckedListBox") res = "1, 2, 3, 4, 6, 7, 8";
                else res = "1, 2, 3, 4, 5, 6, 7";
            else
            {
                if(clb.Name == "DistrictCheckedListBox")
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

        private void addSMI_Click(object sender, EventArgs e)
        {
            ItemInfoForm itemf = new ItemInfoForm(SqlConnection, -1);
            itemf.Notation = Notation.Insert;
            itemf.ShowDialog();
            DataLoad();
        }

        private void changeSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.Update;
            sof.ShowDialog();
            DataLoad();
        }

        private void deleteSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.Delete;
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

        private void RequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.ManagerRequests;
            sof.ManagerId = ManagerId;
            sof.Show();
        }

        private void accountSMI_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowTable.DisplayMyRequests(SqlConnection, ClientId);
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                PaymentForm pf = new PaymentForm(SqlConnection);
                string[] res = Query.Contacts(SqlConnection, ClientId, id);
                pf.PhoneTextBox.Text = res[0];
                pf.EmailTextBox.Text = res[1];
                pf.Id = id;
                try
                {
                    pf.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("запускай через отладчик");
                }
            }
        }

        private void reportSMI_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm(SqlConnection);
            rf.ShowDialog();
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShowTable.Test(SqlConnection);
        }

        private void LandAreaMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomsLabel_Click(object sender, EventArgs e)
        {

        }

        private void DistrictLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoomsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DistrictCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LandAreaMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LandAreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void AreaLabel_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void TradeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RealtyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
