using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class SearchObjectForm : Form
    {
        EstateAgency db;
        public SearchObjectForm(EstateAgency database)
        {
            InitializeComponent();
            db = database;
            db.EstateObjects.Load();
            dataGridView1.DataSource = db.EstateObjects.Local.ToBindingList();
            CreateDataGridView();
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EstateObjects eo = db.EstateObjects.Find(id);
                ItemInfoForm itemInfoForm = new ItemInfoForm(db, eo);
                CreateItemInfoForm(itemInfoForm, eo);
                try
                {
                    itemInfoForm.Show();
                }
                catch(Exception)
                {
                    MessageBox.Show("запускай через отладчик");
                }

                dataGridView1.Refresh();
            }
        }

        static void CreateItemInfoForm(ItemInfoForm itemInfoForm, EstateObjects eo)
        {
            itemInfoForm.StatusTextBox.Text = eo.Statuses.Name;
            itemInfoForm.RealtyTypeTextBox.Text = eo.RealtyTypes.Name;
            itemInfoForm.TradeTypeTextBox.Text = eo.TradeTypes.Name;
            itemInfoForm.DistrictTextBox.Text = eo.Districts.Name;
            itemInfoForm.OwnerInfoTextBox.Text = eo.Owners.Name;
            itemInfoForm.PriceTextBox.Text = eo.Price.ToString();
            itemInfoForm.AddressTextBox.Text = eo.Address;
            itemInfoForm.DescriptionTextBox.Text = eo.Description;
            itemInfoForm.RoomsTextBox.Text = eo.Rooms.ToString();
            itemInfoForm.LandAreaTextBox.Text = eo.LandArea.ToString();
            itemInfoForm.areaTextBox.Text = eo.Area.ToString();
            itemInfoForm.LandTextBox.Text = eo.LandDescription;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EstateObjects eo = db.EstateObjects.Find(id);
                ItemInfoForm itemInfoForm = new ItemInfoForm(db, eo);
                CreateItemInfoForm(itemInfoForm, eo);
                try
                {
                    itemInfoForm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("запускай через отладчик");
                }
                dataGridView1.Refresh();
            }
        }
    }
}
