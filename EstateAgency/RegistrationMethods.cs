using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    class RegistrationMethods
    {
        static string salt = "gt#90mCti2.q";

        static string GetHash(string password, string salt) //Получение хэш-значения
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //Экземпляр объекта MD5
            byte[] digest = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt)); //Вычисление хэш-значения
            string base64digest = Convert.ToBase64String(digest, 0, digest.Length); //Получение строкового значения из массива байт
            return base64digest;
        }

        public static void AddManager(string phone, string email, string password, string surname, string name, string patronymic, SqlConnection sqlConnection)
        {
            string hashPas = GetHash(password, salt);

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Managers (phone, email, name, surname, patronymic, password) VALUES ( @phone, @email, @name, @surname, @patronymic, @password)";
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = hashPas;
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
            string hashPas = GetHash(password, salt);

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Clients (phone, email, name, surname, patronymic, password) VALUES ( @phone, @email, @name, @surname, @patronymic, @password)";
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            command.Parameters.Add("patronymic", SqlDbType.NVarChar).Value = patronymic;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = hashPas;
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

        public static bool CorrectCode(string code, SqlConnection sqlConnection)
        {
            string pas="w";

            string strCommand = string.Format("Select pass FROM passwords WHERE pass = @code");

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = strCommand;
            command.Parameters.Add("code", SqlDbType.NVarChar).Value = code;
            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    pas = reader.GetValue(0).ToString();
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (pas != "w") return true;
            else return false;
        }

        public static int RegistratedClient(string phone, string password, SqlConnection sqlConnection)
        {
            string hashPas = GetHash(password, salt);

            int id = -1;
                string strCommand = string.Format("Select id FROM Clients WHERE Phone = @phone and Password=@password");

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = strCommand;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = hashPas;
            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            finally
                {
                    reader.Close();
                    sqlConnection.Close();
                }
            return id;
        }

        public static int RegistratedManager(string phone, string password, SqlConnection sqlConnection)
        {
            string hashPas = GetHash(password, salt);

            int id = -1;
            string strCommand = string.Format("Select id FROM Managers WHERE Phone = @phone and Password=@password");

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = strCommand;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = hashPas;
            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            return id;
        }
    }
}
