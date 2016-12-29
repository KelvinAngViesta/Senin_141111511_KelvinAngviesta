using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS.AllClass
{
    class DeleteAllItem
    {

        String connString = "Server=Localhost; Database=database_latihan_pos; Uid=root; pwd=''";
        MySqlConnection conn;
        public void hapusBarang(string kode)
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblbarang WHERE kode = @kode";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void hapusCustomer(string kode)
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblcustomer WHERE KodeCust = @kode";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void hapusSupplier(string kode)
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                string sql = "DELETE FROM tblsupplier WHERE KodeSup = @kode";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
