using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EstateAgency
{
    class RegistrationMethods
    {
        public static void AddManager(string phone, string email, string password, string surname, string name, string patronymic)
        {
            using (EstateAgency db = new EstateAgency())
            {
                Managers m = new Managers { Phone = phone, Email = email, Surname = surname, Name = name, Patronymic = patronymic, Password = password };
                db.Managers.Add(m);
                db.SaveChanges();
            }
        }

        public  static void AddClient(string phone, string email, string password, string surname, string name, string patronymic)
        {
            using (EstateAgency db = new EstateAgency())
            {
                Clients c = new Clients { Phone = phone, Email = email, Surname = surname, Name = name, Patronymic = patronymic, Password = password };
                db.Clients.Add(c);
                db.SaveChanges();
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

        public static bool RegistratedClient(string phone, string password)
        {
            using (EstateAgency db = new EstateAgency())
            {
                Clients c = db.Clients.FirstOrDefault(p => p.Phone == phone && p.Password==password);
                if (c != null)
                    return true;
                else return false;
            }
        }

        public static bool RegistratedManager(string phone, string password)
        {
            using (EstateAgency db = new EstateAgency())
            {
                Managers  c = db.Managers.FirstOrDefault(p => p.Phone == phone && p.Password == password);
                if (c != null)
                    return true;
                else return false;
            }
        }
    }
}
