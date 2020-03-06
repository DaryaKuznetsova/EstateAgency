using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstateAgency
{
    class RegistrationMethods
    {

        public static void AddManager(string phone, string email, string password, string surname, string name, string patronymic, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Managers (phone, email, name, surname, patronymic, password) VALUES ( @phone, @email, @name, @surname, @patronymic, @password)";
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = password;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public  static void AddClient(string phone, string email, string password, string surname, string name, string patronymic, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Clients (phone, email, name, surname, patronymic, password) VALUES ( @phone, @email, @name, @surname, @patronymic, @password)";
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = password;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void AddOwner(string phone, string email, string surname, string name, string patronymic, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Owners (phone, email, name, surname, patronymic) VALUES ( @phone, @email, @name, @surname, @patronymic)";
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static bool CorrectEmail(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                return true;
            else return false;
        }

        public static bool RegistratedClient(string phone, string password, SqlConnection sqlConnection)
        {
                string strCommand = string.Format("Select * FROM Clients WHERE Phone = '{0}' and Password='{1}'", phone, password);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(strCommand, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                if (reader.HasRows) return true;
                else return false;
                }
                finally
                {
                    reader.Close();
                    sqlConnection.Close();
                }
        }

        public static bool RegistratedManager(string phone, string password, SqlConnection sqlConnection)
        {
            string strCommand = string.Format("Select * FROM Managers WHERE Phone = '{0}' and Password='{1}'", phone, password);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(strCommand, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.HasRows) return true;
                else return false;
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
        }
    }
}
