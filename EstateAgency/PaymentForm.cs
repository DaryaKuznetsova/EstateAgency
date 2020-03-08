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
    public partial class PaymentForm : Form
    {
        SqlConnection sqlConnection;
        public PaymentForm(SqlConnection s)
        {
            InitializeComponent();
            sqlConnection = s;
            ComboBoxes();
        }
        public int Id { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Query.FinalTrade(sqlConnection, Id, Convert.ToInt32(PaymentInstrumentCB.SelectedValue), Convert.ToInt32(PaymentInstrumentCB.SelectedValue));
        }

        private void ComboBoxes()
        {
            sqlConnection.Open();
            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = "select * from PaymentTypes";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                PaymentTypeCB.DataSource = table;
                PaymentTypeCB.ValueMember = "Id";
                PaymentTypeCB.DisplayMember = "Name";

            }

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = "select * from PaymnetInstruments";
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                PaymentInstrumentCB.DataSource = table;
                PaymentInstrumentCB.ValueMember = "Id";
                PaymentInstrumentCB.DisplayMember = "Name";

            }

            sqlConnection.Close();
            
        }
    }
}
