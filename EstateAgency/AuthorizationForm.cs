﻿using System;
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
    public partial class AuthorizationForm : Form
    {
        SqlConnection sqlConnection;
        public AuthorizationForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(sqlConnection);
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (ManagerCheckBox.Checked )
            {
                if (RegistrationMethods.RegistratedManager(phone, password, sqlConnection)) MessageBox.Show("Успешно");
                else MessageBox.Show("!");
            }
            else if (RegistrationMethods.RegistratedClient (phone, password, sqlConnection )) MessageBox.Show("Успешно");
            else MessageBox.Show("!");
        }
    }
}
