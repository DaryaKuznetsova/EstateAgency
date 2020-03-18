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

namespace EstateAgency
{
    public enum Notation
    {
        Client=1,
        Delete=2,
        Update=3,
        Insert=4,
        ManagerRequests=5
    };

    public partial class SearchObjectForm : Form
    {
        bool Filter = false;
        private Notation notation = Notation.Client;

        public Notation Notation
        {
            get { return notation; }
            set
            {
                notation = value;
                ChangeNotation();
            }
        }

        SqlConnection SqlConnection { get; set; }
        public SearchObjectForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            SqlConnection = sqlConnection;
            TextBoxes();
            ComboBoxes();
        }

        private void ShowsearchResults()
        {

        }

        private void ChangeNotation()
        {
            BlockEverything();
            if (Notation == Notation.Client)
            {
                InfoButton.Enabled = true;
                InfoButton.Visible = true;
            }
            if(Notation == Notation.Delete)
            {
                DeleteButton.Visible = true;
                DeleteButton.Enabled = true;
            }
            if (Notation == Notation.Update)
            {
                ChangeButton.Visible = true;
                ChangeButton.Enabled = true;
            }
            if (Notation == Notation.ManagerRequests)
            {
                RequestButton.Visible = true;
                RequestButton.Enabled = true;
                BlockFilter();
                dataGridView1.DataSource = ShowTable.DisplayCurrentRequests(SqlConnection);
            }
        }

        private void BlockFilter()
        {
            RealtyTypeComboBox.Visible = false;
            TradeTypeComboBox.Visible = false;
            DistrictCheckedListBox.Visible = false;
            RoomsCheckedListBox.Visible = false;
            PriceMinTextBox.Visible = false;
            PriceMaxTextBox.Visible = false;
            LandAreaMinTextBox.Visible = false;
            LandAreaMaxTextBox.Visible = false;
            AreaMinTextBox.Visible = false;
            AreaMaxTextBox.Visible = false;
            SearchButton.Visible = false;
            PriceLabel.Visible = false;
            AreaLabel.Visible = false;
            DistrictLabel.Visible = false;
            RoomsLabel.Visible = false;
            LandAreaLabel.Visible = false;
        }

        private void BlockEverything()
        {
            DeleteButton.Enabled = false;
            DeleteButton.Visible = false;
            ChangeButton.Enabled = false;
            ChangeButton.Visible = false;
            InfoButton.Enabled = false;
            InfoButton.Visible = false;
            RequestButton.Visible = false;
            RequestButton.Enabled = false;
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

        public void DataLoad()
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
            string districts = ManagerForm.CreateParameters(DistrictCheckedListBox);
            string rooms = ManagerForm.CreateParameters(RoomsCheckedListBox);

            if (Filter)
                dataGridView1.DataSource = ShowTable.DisplayCurrentRequests(SqlConnection);
            else
                dataGridView1.DataSource = Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            CreateInfoForm();
            DataLoad();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CreateInfoForm();
            DataLoad();
        }

        void CreateInfoForm()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                ItemInfoForm itemInfoForm = new ItemInfoForm(SqlConnection, id);
                itemInfoForm.Notation = notation;
                try
                {
                    itemInfoForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("запускай через отладчик");
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            CreateInfoForm();
            DataLoad();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            CreateInfoForm();
            DataLoad();
        }

        //private void SearchButton_Click(object sender, EventArgs e)
        //{
        //    int realtyType = Convert.ToInt32(RealtyTypeComboBox.SelectedValue);
        //    int tradeType = Convert.ToInt32(TradeTypeComboBox.SelectedValue);
        //    float minPrice = PriceMinTextBox.Value;
        //    float maxPrice = PriceMaxTextBox.Value;
        //    float minArea = AreaMinTextBox.Value;
        //    float maxArea = AreaMaxTextBox.Value;
        //    float minLandArea = LandAreaMinTextBox.Value;
        //    float maxLandArea = LandAreaMaxTextBox.Value;

        //    var elements = DistrictCheckedListBox.CheckedItems;
        //    string districts = ManagerForm.CreateParameters(DistrictCheckedListBox);
        //    string rooms = ManagerForm.CreateParameters(RoomsCheckedListBox);

        //    dataGridView1.DataSource = Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection);
        //}

        private void SearchButton_Click_1(object sender, EventArgs e)
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
            string districts = ManagerForm.CreateParameters(DistrictCheckedListBox);
            string rooms = ManagerForm.CreateParameters(RoomsCheckedListBox);

            dataGridView1.DataSource = Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection);
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
