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
    public partial class OwnerInfo : Form
    {
        public SqlConnection sqlConnection { get; set; }
        public OwnerInfo(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Surname = SurnameTextBox.Text;
                string Name = NameTextBox.Text;
                string Patronymic = PatronymicTextBox.Text;
                string phone = PhoneTextBox.Text;
                string email = EmailTextBox.Text;
                RegistrationMethods.AddOwner(phone, email, Surname, Name, Patronymic, sqlConnection);
                MessageBox.Show("Владелец добавлен");
                this.Close();
            }
            catch(Exception el)
            {
                MessageBox.Show(el.ToString());
            }

        }
    }
}
