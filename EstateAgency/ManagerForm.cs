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
            //dataGridView1.DataSource = ShowTable.AllTable(SqlConnection);
            ComboBoxes();
            TextBoxes();
            Exit();
            CurrentUser.ClientId = -1;
            CurrentUser.ManagerId = -1;
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
            InfoButton.Visible = true;
            ShowSearchResults();
            filter = true;
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
                itemInfoForm.Notation = Notation.Client;
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

        private void ShowSearchResults()
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

            dataGridView1.DataSource = Query.SelectEstateObjects(realtyType, tradeType, minPrice, maxPrice, minArea, maxArea, minLandArea, maxLandArea, districts, rooms, SqlConnection);
        }

        private bool filter = false;

        private void RefreshData()
        {
            if (filter) ShowSearchResults();
            else ShowTable.AllTable(SqlConnection);
        }

        public static string CreateParameters(CheckedListBox clb)
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
                        DataRowView drv = (DataRowView)clb.CheckedItems[i];
                        int valueOfItem = Convert.ToInt32(drv["Id"]);
                        res = res + valueOfItem + ", ";
                    }
                }
                else
                    for (int i = 0; i < clb.CheckedItems.Count; i++)
                    {
                        res = res + clb.CheckedItems[i] + ", ";
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
            RefreshData();
        }

        private void changeSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.Update;
            sof.ShowDialog();
            RefreshData();
        }

        private void deleteSMI_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.Delete;
            sof.ShowDialog();
            RefreshData();
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

        private void Exit()
        {
            personSMI.Visible = false;
            personSMI.Enabled = false;
            catalogSMI.Visible = false;
            catalogSMI.Enabled = false;
            statisticsSMI.Visible = false;
            statisticsSMI.Enabled = false;
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
            dataGridView1.Visible = false;
            PriceLabel.Visible = false;
            AreaLabel.Visible = false;
            DistrictLabel.Visible = false;
            RoomsLabel.Visible = false;
            LandAreaLabel.Visible = false;
            InfoButton.Visible = false;
            paymentButton.Visible = false;
        }

        private void RequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchObjectForm sof = new SearchObjectForm(SqlConnection);
            sof.Notation = Notation.ManagerRequests;
            sof.Show();
        }

        private void accountSMI_Click(object sender, EventArgs e)
        {
            Exit();
            dataGridView1.Visible = true;
            paymentButton.Visible = true;
            dataGridView1.DataSource = ShowTable.DisplayClientRequests(SqlConnection, CurrentUser.ClientId);
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
                string[] res = Query.Contacts(SqlConnection, CurrentUser.ClientId, id);
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
            ReportsForm sf = new ReportsForm(SqlConnection);
            sf.Show();
        }

        private void AdvancedSearchButton_Click(object sender, EventArgs e)
        {
            
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

        private void открытьXlsФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            bool open = OpenFile(ref fileName); // Название и путь файла выбраны успешно
            if (open)
            {
                try
                {
                    ExcelExport.InsetExcel(fileName, SqlConnection);
                    MessageBox.Show("opened");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }
        }

        public static bool OpenFile(ref string filename) // Выбор пути сохранения и проверка расширения
        {
            bool ok = false;
            OpenFileDialog SFD = new OpenFileDialog();
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

        private void Statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm rf = new StatisticsForm(SqlConnection);
            rf.Show();
        }

        private void EnterPictureBox_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm(this, SqlConnection);
            authorizationForm.ShowDialog();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Exit();
            CurrentUser.ClientId = -1;
            CurrentUser.ManagerId = -1;
            EnterPictureBox.Enabled = true;
        }

        public void EnterClient()
        {
            personSMI.Visible = true ;
            personSMI.Enabled = true;

            RealtyTypeComboBox.Visible = true;
            TradeTypeComboBox.Visible = true;
            DistrictCheckedListBox.Visible = true;
            RoomsCheckedListBox.Visible = true;
            PriceMinTextBox.Visible = true;
            PriceMaxTextBox.Visible = true;
            LandAreaMinTextBox.Visible = true;
            LandAreaMaxTextBox.Visible = true;
            AreaMinTextBox.Visible = true;
            AreaMaxTextBox.Visible = true;
            SearchButton.Visible = true;
            dataGridView1.Visible = true;
            PriceLabel.Visible = true;
            AreaLabel.Visible = true;
            DistrictLabel.Visible = true;
            RoomsLabel.Visible = true;
            LandAreaLabel.Visible = true;
            InfoButton.Visible = true;
            EnterPictureBox.Enabled = false;
        }

        public void EnterManager()
        {
            personSMI.Visible = false;
            personSMI.Enabled = false;
            catalogSMI.Visible = true ;
            catalogSMI.Enabled = true;
            statisticsSMI.Visible = true;
            statisticsSMI.Enabled = true;
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
            dataGridView1.Visible = false;
            InfoButton.Visible = false;
            paymentButton.Visible = false;
            EnterPictureBox.Enabled = false;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            CreateInfoForm();
            RefreshData();
        }

        private void ввестиЗначенияВручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemInfoForm itemf = new ItemInfoForm(SqlConnection, -1);
            itemf.Notation = Notation.Insert;
            itemf.ShowDialog();
            RefreshData();
        }
    }
}
