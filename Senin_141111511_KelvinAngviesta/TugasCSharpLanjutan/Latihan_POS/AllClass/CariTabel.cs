using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Latihan_POS.AllClass;
using System.Data;
using System.Windows.Forms;

namespace Latihan_POS.AllClass
{
    class CariTabel
    {
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=database_latihan_pos; Uid=root; pwd=''";
        MySqlCommand cmd;
        public bool CekAllKode(String kode, String item)
        {
            conn = new MySqlConnection(connString);
            bool Nilai = false;
            if (item == "Barang")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblbarang where id = '" + kode + "'";
                    cmd = new MySqlCommand(sql, conn);
                    Nilai = cmd.ExecuteReader().HasRows;
                    MessageBox.Show(sql);
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
            else if (item == "Customer")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblcustomer where KodeCust = '" + kode + "'";
                    cmd = new MySqlCommand(sql, conn);
                    MessageBox.Show(sql);
                    Nilai = cmd.ExecuteReader().HasRows;
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
            else if (item == "Supplier")
            {
                try
                {
                    conn.Open();
                    String sql = "SELECT * FROM tblsupplier where KodeSup = '" + kode + "'";
                    cmd = new MySqlCommand(sql, conn);
                    MessageBox.Show(sql);
                    Nilai = cmd.ExecuteReader().HasRows;
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
            return Nilai;
        }
    }
}
