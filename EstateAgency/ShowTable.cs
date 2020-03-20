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
            command.CommandText = "SELECT * FROM EstateObjects where statusid=1";
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


        public static DataTable DisplayClientRequests(SqlConnection sqlConnection, int id, int status)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = string.Format("SELECT Requests.id, Requests.objectid," +
                " EstateObjects.Price, EstateObjects.Address," +
                " EstateObjects.Area from EstateObjects" +
                " inner join Requests on EstateObjects.id = Requests.ObjectId" +
                " inner join Clients on requests.clientid = clients.id" +
                " where clients.id = @client and estateobjects.statusid=@status");
            command.Parameters.AddWithValue("client", id);
            command.Parameters.AddWithValue("status", status);
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

        public static DataTable DisplayTrades(SqlConnection sqlConnection, int clientid)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            command.CommandText = string.Format("SELECT * from trades where clientid=@id");
            command.Parameters.AddWithValue("id", clientid);
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
