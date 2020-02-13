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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void PatronymicTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string surname = SurnameTextBox.Text;
            string name = NameTextBox.Text;
            string patronymic = PatronymicTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string password1 = PasswordTextBox.Text;
            string password2 = Password2TextBox.Text;
            if (password1.Equals(password2) && RegistrationMethods.CorrectEmail(email))
            {
                if (ManagerCheckBox.Checked)
                    RegistrationMethods.AddManager(phone, email, password1, surname, name, patronymic);
                else RegistrationMethods.AddClient(phone, email, password1, surname, name, patronymic);
                this.Close();
            }               
            else MessageBox.Show("Проверьте пароль и email");
            ManagerForm mf = new ManagerForm();
            mf.Show();

        }
    }
}
