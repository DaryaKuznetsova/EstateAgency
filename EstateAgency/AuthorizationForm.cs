using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (ManagerCheckBox.Checked )
            {
                if (RegistrationMethods.RegistratedManager(phone, password)) MessageBox.Show("Успешно");
                else MessageBox.Show("!");
            }
            else if (RegistrationMethods.RegistratedClient (phone, password)) MessageBox.Show("Успешно");
            else MessageBox.Show("!");
        }
    }
}
