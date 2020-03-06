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
        public int ClientId { get; set; }
        public int ManagerId { get; set; }
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
            dataGridView1.DataSource = ShowTable.DisplayTable("EstateObjects", SqlConnection);
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
                dataGridView1.DataSource = ShowTable.DisplayCurrentRequests(SqlConnection);
            }
        }

        private void BlockEverything()
        {
            DeleteButton.Enabled = false;
            DeleteButton.Visible = false;
            ChangeButton.Enabled = false;
            ChangeButton.Visible = false;
            InfoButton.Enabled = false;
            InfoButton.Visible = false;
        }

        public void DataLoad()
        {
            dataGridView1.DataSource = ShowTable.DisplayTable("EstateObjects", SqlConnection);
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
                itemInfoForm.ClientId = ClientId;
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
        }
    }
}
