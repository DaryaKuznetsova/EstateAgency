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
        public static DataTable DisplayTable(string tableName, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM " + tableName;
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


        public static DataTable DisplayMyRequests(SqlConnection sqlConnection, int id)
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

        public static void DisplayPotentialTrades(SqlConnection sqlConnection)
        {

        }
    }
}
