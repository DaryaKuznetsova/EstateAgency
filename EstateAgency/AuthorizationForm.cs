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
    public partial class AuthorizationForm : Form
    {
        SqlConnection SqlConnection;
        ManagerForm mf;
        public AuthorizationForm(ManagerForm f, SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.SqlConnection = sqlConnection;
            button1.Enabled = false;
            mf = f;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(SqlConnection);
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (ManagerCheckBox.Checked)
            {
                if (RegistrationMethods.RegistratedManager(phone, password, SqlConnection) != -1)
                {
                    CurrentUser.ManagerId = RegistrationMethods.RegistratedManager(phone, password, SqlConnection);
                    mf.EnterManager();
                    this.Close();
                }
                else MessageBox.Show("Пользователя с данным логином и паролем нет в системе. Пожалуйста, проверьте введенные данные.");
            }
            else if (RegistrationMethods.RegistratedClient(phone, password, SqlConnection) != -1)
            {
                CurrentUser.ClientId = RegistrationMethods.RegistratedClient(phone, password, SqlConnection);
                mf.EnterClient();
                this.Close();
            }
            else MessageBox.Show("Пользователя с данным логином и паролем нет в системе. Пожалуйста, проверьте введенные данные.");
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void BlockButton()
        {
            if (LoginTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0)
                button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }
    }
}
