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
    public partial class RegistrationForm : Form
    {
        SqlConnection sqlConnection;
        public RegistrationForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            this.sqlConnection = sqlConnection;
            CodeLabel.Visible = false;
            CodeTextBox.Visible = false;
            CodeTextBox.Enabled = false;
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
            BlockButton();
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
            string code = CodeTextBox.Text;
            if (password1.Equals(password2) && RegistrationMethods.CorrectEmail(email))
            {
                try
                {
                    if (ManagerCheckBox.Checked)
                        if (RegistrationMethods.CorrectCode(code, sqlConnection))
                        {
                            RegistrationMethods.AddManager(phone, email, password1, surname, name, patronymic, sqlConnection);
                            MessageBox.Show("Регистрация прошла успешно. Ваш логин - номер телефона. Авторизируйтесь для продолжения работы.");
                        }
                        else MessageBox.Show("Введен неверный код. Уточните код у администратора.");
                    else
                    {
                        RegistrationMethods.AddClient(phone, email, password1, surname, name, patronymic, sqlConnection);
                        MessageBox.Show("Регистрация прошла успешно. Ваш логин - номер телефона. Авторизируйтесь для продолжения работы.");
                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Пользователь с данным номером телефона или адресом электронной почты уже существует. Пожалуйста, проверьте введенные данные.");
                }
            }               
            else MessageBox.Show("Проверьте пароль и email.");
        }

        private void BlockButton()
        {
            if (SurnameTextBox.Text.Length != 0 && NameTextBox.Text.Length != 0 &&
                PatronymicTextBox.Text.Length != 0 && PhoneTextBox.Text.Length != 0 &&
                EmailTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0)
                RegistrationButton.Enabled = true;
            else RegistrationButton.Enabled = false;
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void Password2TextBox_TextChanged(object sender, EventArgs e)
        {
            BlockButton();
        }

        private void ManagerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ManagerCheckBox.Checked)
            {
                CodeLabel.Visible = true;
                CodeTextBox.Visible = true;
                CodeTextBox.Enabled = true;
            }
            else
            {
                CodeLabel.Visible = false ;
                CodeTextBox.Visible = false;
                CodeTextBox.Enabled = false;
            }
        }
    }
}
