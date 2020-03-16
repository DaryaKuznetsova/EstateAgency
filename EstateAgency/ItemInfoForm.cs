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
    public partial class ItemInfoForm : Form
    {
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

        private void ChangeNotation()
        {
            BlockEverything();
            MakeReadOnly();
            if (Notation == Notation.Client)
            {
                BuyButton.Visible = true;
                BuyButton.Enabled = true;
            }
            if (Notation == Notation.Delete)
            {
                DeleteButton.Visible = true;
                DeleteButton.Enabled = true;
            }
            if (Notation == Notation.Update)
            {
                MakeNotReadOnly();
                ChangeButton.Visible = true;
                ChangeButton.Enabled = true;
                AddImageButton.Enabled = true;
                AddImageButton.Visible = true;
                DeleteImageButton.Enabled = true;
                DeleteImageButton.Visible = true;
                AddOwnerButton.Enabled = true;
                AddOwnerButton.Visible = true;
            }
            if (Notation == Notation.Insert)
            {
                MakeNotReadOnly();
                AddButton.Visible = true;
                AddButton.Enabled = true;
                AddImageButton.Enabled = true;
                AddImageButton.Visible = true;
                DeleteImageButton.Enabled = true;
                DeleteImageButton.Visible = true;
                AddOwnerButton.Enabled = true;
                AddOwnerButton.Visible = true;
            }
            if (Notation == Notation.ManagerRequests)
            {
                acceptButton.Visible = true;
                acceptButton.Enabled = true;
            }
        }

        private void MakeNotReadOnly()
        {
            TradeTypeComboBox.AllowDrop = true;
            RealtyTypeComboBox.AllowDrop = true;

            PriceTextBox.ReadOnly = false;
            AddressTextBox.ReadOnly = false;
            DescriptionTextBox.ReadOnly = false;
            AreaTextBox.ReadOnly = false;
            RoomsTextBox.ReadOnly = false;
            LandAreaTextBox.ReadOnly = false;
            LandAreaTextBox.ReadOnly = false;
        }

        private void BlockEverything()
        {
            DeleteButton.Enabled = false;
            DeleteButton.Visible = false;
            ChangeButton.Enabled = false;
            ChangeButton.Visible = false;
            BuyButton.Enabled = false;
            BuyButton.Visible = false;
            acceptButton.Enabled = false;
            acceptButton.Visible = false;
            AddButton.Enabled = false;
            AddButton.Visible = false;
            AddImageButton.Enabled = false;
            AddImageButton.Visible = false;
            DeleteImageButton.Enabled = false;
            DeleteImageButton.Visible = false;
            AddOwnerButton.Enabled = false;
            AddOwnerButton.Visible = false;
            PrevImageButton.Enabled = false;
            PrevImageButton.Visible = false;
            NextImageButton.Enabled = false;
            NextImageButton.Visible = false;
        }

        private void MakeReadOnly()
        {
            TradeTypeComboBox.AllowDrop = false;
            RealtyTypeComboBox.AllowDrop = false;

            PriceTextBox.ReadOnly = true;
            AddressTextBox.ReadOnly = true;
            DescriptionTextBox.ReadOnly = true;
            AreaTextBox.ReadOnly = true;
            RoomsTextBox.ReadOnly = true;
            LandAreaTextBox.ReadOnly = true;
            LandAreaTextBox.ReadOnly = true;
        }

        private void AllowPrevNextImageButtons()
        {
            PrevImageButton.Enabled = true;
            PrevImageButton.Visible = true;
            NextImageButton.Enabled = true;
            NextImageButton.Visible = true;
        }
        public SqlConnection SqlConnection { get; set; }
        public int Id { get; set; }

        public ItemInfoForm(SqlConnection sqlConnection, int id)
        {
            InitializeComponent();
            SqlConnection = sqlConnection;
            Id = id;
            ComboBoxes();
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
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                DistrictComboBox.DataSource = table;
                DistrictComboBox.ValueMember = "Id";
                DistrictComboBox.DisplayMember = "Name";
            }
            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from Statuses";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                StatusComboBox.DataSource = table;
                StatusComboBox.ValueMember = "Id";
                StatusComboBox.DisplayMember = "Name";
            }
            using (var command = SqlConnection.CreateCommand())
            {
                command.CommandText = "select * from Owners";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                OwnerComboBox.DataSource = table;
                OwnerComboBox.ValueMember = "Id";
                OwnerComboBox.DisplayMember = "Surname";
            }
            SqlConnection.Close();
        }

        private void CreateItemInfoForm(int id)
        {
            string statusComboBox = "";
            string ownerComboBox = "";
            string priceTextBox = "";
            string addressTextBox = "";
            string districtComboBox = "";
            string descriptionTextBox = "";
            string realtyTypeComboBox = "";
            string tradeTypeComboBox = "";
            string areaTextBox = "";
            string roomsTextBox = "";
            string landTextBox = "";
            string landAreaTextBox = "";

            EstateObjects.CreateItemInfo(SqlConnection, id,
                out statusComboBox, out ownerComboBox, out priceTextBox,
                out addressTextBox, out districtComboBox, out descriptionTextBox,
                out realtyTypeComboBox, out tradeTypeComboBox, out areaTextBox,
                out roomsTextBox, out landTextBox, out landAreaTextBox);

            StatusComboBox.Text = statusComboBox;
            OwnerComboBox.Text = ownerComboBox;
            PriceTextBox.Text = priceTextBox;
            AddressTextBox.Text = addressTextBox;
            DistrictComboBox.Text = districtComboBox;
            DescriptionTextBox.Text = descriptionTextBox;
            RealtyTypeComboBox.Text = realtyTypeComboBox;
            TradeTypeComboBox.Text = tradeTypeComboBox;
            AreaTextBox.Text = areaTextBox;
            RoomsTextBox.Text = roomsTextBox;
            LandTextBox.Text = landTextBox;
            LandAreaTextBox.Text = landAreaTextBox;

            images= Images(id);
            if (images.Count > 0)
            {
                AllowPrevNextImageButtons();
                pictureBox1.Image = Image.FromFile(images[0]);
            }

            Block();
        }

        private static List<string> images;
        private static string currentimagepath = "";

        private List<string> Images(int id)
        {
            return Pictures.Images(images, SqlConnection, Id);
        }

        private void NextImage(List<string> images, ref int i)
        {
            if (i + 1 >= images.Count) i = 0;
            else i++;
            pictureBox1.Image = Image.FromFile(images[i]);
            currentimagepath = images[i];
        }

        private void PrevImage(List<string> images, ref int i)
        {
            if (i - 1 <0) i = images.Count-1;
            else i--;
            pictureBox1.Image = Image.FromFile(images[i]);
            currentimagepath = images[i];
        }

        private static int currentPicture=0;

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertData();
                EstateObjects.Update(SqlConnection, Id, Status, OwnerId, Price, Address, District, Description, RealtyTypes, TradeTypes, Area, Rooms, LandDescription, LandArea);
                MessageBox.Show("Запись изменена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool Block()
        {
            if(RealtyTypeComboBox.SelectedIndex==1||RealtyTypeComboBox.SelectedIndex == 2)
            {
                LandTextBox.Enabled = false;
                LandAreaTextBox.Enabled = false;
                return true;
            }
            else
            {
                LandTextBox.Enabled = true;
                LandAreaTextBox.Enabled = true;
                return false;
            }
        }

        private int RealtyTypes { get; set; }
        private int TradeTypes { get; set; }
        private int District { get; set; }
        private int OwnerId { get; set; }
        private int Status { get; set; }
        private float Price { get; set; }
        private string Address { get; set; }
        private string Description { get; set; }
        private byte Rooms { get; set; }
        private float LandArea { get; set; }
        private float Area { get; set; }
        private string LandDescription { get; set; }

        private void ConvertData()
        {
            RealtyTypes = (int)RealtyTypeComboBox.SelectedValue;
            TradeTypes = (int)TradeTypeComboBox.SelectedValue;
            District = (int)DistrictComboBox.SelectedValue;
            OwnerId = (int)OwnerComboBox.SelectedValue;
            Status = (int)StatusComboBox.SelectedValue;
            Price = (float)Convert.ToDouble(PriceTextBox.Text);
            Address = AddressTextBox.Text;
            Description = DescriptionTextBox.Text;
            Rooms = Convert.ToByte(RoomsTextBox.Text);
            if (!Block())
            {
                LandArea = (float)Convert.ToDouble(LandAreaTextBox.Text);
                Area = (float)Convert.ToDouble(AreaTextBox.Text);
                LandDescription = LandTextBox.Text;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertData();
                EstateObjects.Insert(SqlConnection, Status, OwnerId, Price, Address, District, Description, RealtyTypes, TradeTypes, Area, Rooms, LandDescription, LandArea);
                MessageBox.Show("Запись добавлена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                EstateObjects.Delete(Id, "EstateObjects", "Id", SqlConnection);
                MessageBox.Show("Запись удалена");
                this.Close();
            }
            catch
            {
                MessageBox.Show("невозможно удалить");
            }
          
        }

        private void ItemInfoForm_Load(object sender, EventArgs e)
        {
            CreateItemInfoForm(Id);
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(PriceTextBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void areaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(AreaTextBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LandAreaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(LandAreaTextBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void RoomsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void RealtyTypeComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            Block();
        }

        private void RealtyTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            Block();
        }

        private void AddOwnerButton_Click(object sender, EventArgs e)
        {
            OwnerInfo oi = new OwnerInfo(SqlConnection);
            oi.Show();
        }

        private void PrevImageButton_Click(object sender, EventArgs e)
        {
            PrevImage(images, ref currentPicture);
        }

        private void NextImageButton_Click(object sender, EventArgs e)
        {
            NextImage(images, ref currentPicture);
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg|Все файлы ()*.*|*.*";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Pictures.AddPicture(Id, opf.FileName, SqlConnection);
                    MessageBox.Show("Изображение дабвлено");
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка при добавлении");
                }
                images = Images(Id);
            }
        }

        private void DeleteImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                Pictures.DeletePicture(SqlConnection, currentimagepath, Id);
                MessageBox.Show("Изображение удалено");
                images = Images(Id);
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertData();
                EstateObjects.Update(SqlConnection, Id, 3, OwnerId, Price, Address, District, Description, RealtyTypes, TradeTypes, Area, Rooms, LandDescription, LandArea);
                Trades.CreateTrade(SqlConnection, Id, ManagerId);
                MessageBox.Show("Заявка одобрена");
            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
            }

        }

        public int ClientId { get; set; }
        public int ManagerId { get; set; }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertData();
                EstateObjects.Update(SqlConnection, Id, 2, OwnerId, Price, Address, District, Description, RealtyTypes, TradeTypes, Area, Rooms, LandDescription, LandArea);
                Trades.CreateClientObjectLink(SqlConnection, ClientId, Id);
                MessageBox.Show("Заявка подана на рассмотрение");
            }
            catch(Exception u)
            {
                MessageBox.Show(u.ToString());
            }

        }
    }
}
