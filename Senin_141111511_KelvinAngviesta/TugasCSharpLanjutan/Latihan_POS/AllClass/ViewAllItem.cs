using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;

namespace Latihan_POS.AllClass
{
    class ViewAllItem
    {
        public void ViewTableBarang(DataGridView DgViewBarang)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=database_latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            DgViewBarang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewBarang.Rows.Clear();
            DgViewBarang.Refresh();
            String sql = "SELECT * FROM tblbarang";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DgViewBarang, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetString(4).ToString(), reader.GetString(5).ToString(), reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss")
                    , reader.GetDateTime(7).ToString("dd-MM-yyyy HH:mm:ss"));
                DgViewBarang.Rows.Add(row);
            }

            conn.Close();

        }
        public void ViewTableCustomer(DataGridView DgViewCust)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=database_latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            DgViewCust.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewCust.Rows.Clear();
            DgViewCust.Refresh();
            String sql = "SELECT * FROM tblcustomer";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DgViewCust, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetString(4).ToString(), reader.GetDateTime(5).ToString("dd-MM-yyyy HH:mm:ss")
                    , reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"));
                DgViewCust.Rows.Add(row);
            }

            conn.Close();
        }
        public void ViewTableSupplier(DataGridView DgViewSupp)
        {
            MySqlConnection conn;
            String ConnString = "Server=Localhost; Database=database_latihan_pos; Uid=root; Pwd='';";
            MySqlCommand cmd;
            MySqlDataReader reader;
            conn = new MySqlConnection(ConnString);
            DgViewSupp.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgViewSupp.Rows.Clear();
            DgViewSupp.Refresh();
            String sql = "SELECT * FROM tblsupplier";

            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DgViewSupp, reader.GetString(0).ToString(), reader.GetString(1).ToString(), reader.GetString(2).ToString(), reader.GetString(3).ToString(),
                    reader.GetString(4).ToString(), reader.GetDateTime(5).ToString("dd-MM-yyyy HH:mm:ss")
                    , reader.GetDateTime(6).ToString("dd-MM-yyyy HH:mm:ss"));
                DgViewSupp.Rows.Add(row);
            }

            conn.Close();
        }
    }
}
