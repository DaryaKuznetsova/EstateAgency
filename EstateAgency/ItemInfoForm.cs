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
                OwnerComboBox.DisplayMember = "Name";
            }
            SqlConnection.Close();
        }

        private void CreateItemInfoForm(int id)
        {
            string strCommand = string.Format("Select * FROM EstateObjects WHERE Id = '{0}'", id);
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read()) 
                {
                    StatusComboBox.SelectedValue = reader.GetValue(1).ToString();
                    OwnerComboBox.SelectedValue = reader.GetValue(2).ToString();
                    PriceTextBox.Text = reader.GetValue(3).ToString();
                    AddressTextBox.Text = reader.GetValue(4).ToString();
                    DistrictComboBox.SelectedValue = reader.GetValue(5).ToString();
                    DescriptionTextBox.Text = reader.GetValue(6).ToString();
                    RealtyTypeComboBox.SelectedValue = reader.GetValue(7).ToString();
                    TradeTypeComboBox.SelectedValue = reader.GetValue(8).ToString();
                    areaTextBox.Text = reader.GetValue(9).ToString();
                    RoomsTextBox.Text = reader.GetValue(10).ToString();
                    LandTextBox.Text = reader.GetValue(11).ToString();
                    LandAreaTextBox.Text = reader.GetValue(12).ToString();
                }
            }
            catch(Exception e )
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
                SqlConnection.Close();
            }
            List<string> images= Images(id);

            pictureBox1.Image = Image.FromFile(images[0]);
            Block();
        }

        private static List<string> images;

        private List<string> Images(int id)
        {
            images = new List<string>();

            string strCommand = string.Format("Select Pictures.Picture" +
                " FROM EstateObjects" +
                " inner join PictureObjectLinks on EstateObjects.Id=PictureObjectLinks.IdObject" +
                " inner join Pictures on PictureObjectLinks.IdPicture=Pictures.Id" +
                " WHERE EstateObjects.Id = '{0}'", id);
            SqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    images.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
                SqlConnection.Close();
            }

            return images;
        }

        private void NextImage(List<string> images, ref int i)
        {
            if (i + 1 >= images.Count) i = 0;
            else i++;
            pictureBox1.Image = Image.FromFile(images[i]);
        }

        private void PrevImage(List<string> images, ref int i)
        {
            if (i - 1 <0) i = images.Count-1;
            else i--;
            pictureBox1.Image = Image.FromFile(images[i]);
        }

        private static int currentPicture=0;

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int RealtyTypes = (int)RealtyTypeComboBox.SelectedValue;
                int TradeType = (int)TradeTypeComboBox.SelectedValue;
                int District = (int)DistrictComboBox.SelectedValue;
                int Owner = (int)OwnerComboBox.SelectedValue;
                int Status = (int)StatusComboBox.SelectedValue;
                float Price = (float)Convert.ToDouble(PriceTextBox.Text);
                string Address = AddressTextBox.Text;
                string Description = DescriptionTextBox.Text;
                byte Rooms = Convert.ToByte(RoomsTextBox.Text);
                float LandArea = (float)Convert.ToDouble(LandAreaTextBox.Text);
                float Area = (float)Convert.ToDouble(areaTextBox.Text);
                string LandDescription = LandTextBox.Text;

                DeleteUpdateInsertMethods.Update(Id, Status, Owner, Price, Address, District, Description, RealtyTypes, TradeType, Area, Rooms, LandDescription, LandArea, SqlConnection);
                MessageBox.Show("Запись изменена");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void Block()
        {
            if(RealtyTypeComboBox.SelectedIndex==1||RealtyTypeComboBox.SelectedIndex == 2)
            {
                LandTextBox.Enabled = false;
                LandAreaTextBox.Enabled = false;
            }
            else
            {
                LandTextBox.Enabled = true;
                LandAreaTextBox.Enabled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int RealtyTypes = (int)RealtyTypeComboBox.SelectedValue;
                int TradeType = (int)TradeTypeComboBox.SelectedValue;
                int District = (int)DistrictComboBox.SelectedValue;
                int Owner = (int)OwnerComboBox.SelectedValue;
                int Status = (int)StatusComboBox.SelectedValue;
                float Price = (float)Convert.ToDouble(PriceTextBox.Text);
                string Address = AddressTextBox.Text;
                string Description = DescriptionTextBox.Text;
                byte Rooms = Convert.ToByte(RoomsTextBox.Text);
                float LandArea = (float)Convert.ToDouble(LandAreaTextBox.Text);
                float Area = (float)Convert.ToDouble(areaTextBox.Text);
                string LandDescription = LandTextBox.Text;

                DeleteUpdateInsertMethods.Insert(Status, Owner, Price, Address, District, Description, RealtyTypes, TradeType, Area, Rooms, LandDescription, LandArea, SqlConnection);
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
                DeleteUpdateInsertMethods.Delete(Id, "EstateObjects", "Id", SqlConnection);
                MessageBox.Show("Запись удалена");
                this.Close();
            }
            catch (Exception)
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
            if (!double.TryParse(areaTextBox.Text + e.KeyChar.ToString(), out double a) && e.KeyChar != 8)
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
                Query.AddPicture(Id, opf.FileName, SqlConnection);
            }
        }
    }
}
