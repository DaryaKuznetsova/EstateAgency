using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgency
{
    class ShowTable
    {
        private Notation notation = Notation.Client;

        public Notation Notation
        {
            get { return notation; }
            set
            {
                notation = value;
               // ChangeNotation();
            }
        }
        
        public static DataTable AllTable(SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM EstateObjects";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error!");
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        //private static DataTable Filter(SqlConnection sqlConnection, SearchObjectForm sof)
        //{

        //}

        public static DataTable DisplayCurrentRequests(SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM EstateObjects" +
                " where statusid=2";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error!");
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }


        public static DataTable DisplayClientRequests(SqlConnection sqlConnection, int id)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = string.Format("SELECT * from EstateObjects inner join ClientObjectLinks on EstateObjects.id = clientobjectlinks.ObjectId inner join Clients on clientobjectlinks.clientid = clients.id where clients.id = '{0}'", id);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch(Exception r)
            {
                MessageBox.Show(r.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }

        public static DataTable Test(SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = string.Format("SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Trades'");
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
