using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Latihan_POS.AllClass;

namespace Latihan_POS.AllClass
{
    class RegisCustomer
    {
        static MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=database_latihan_pos;Uid=root;password=;");
       
        public void TambahBarang(string KodeCust, string NamaCust, string AlamatCust, string HpCust,string EmailCust)
        {
            RegisBarang regisbarang = new RegisBarang();
            if (regisbarang.isNumber(KodeCust) == -1)
            {
                MessageBox.Show("Kode Harus Angka !");
                KodeCust = "";
                return;
            }
            else if (NamaCust == "")
            {
                MessageBox.Show("Nama Harus Diisi!");
                return;
            }
            else if (AlamatCust == "")
            {
                MessageBox.Show("Alamat Harus Diisi");
                return;
            }
            else if (regisbarang.isNumber(HpCust) == -1)
            {
                MessageBox.Show("Hp Harus Angka !");
                HpCust = "";
                return;
            }
            else if (EmailCust == "")
            {
                MessageBox.Show("Email Harus Diisi");
                return;
            }
            DateTime DateTimeCust = DateTime.Now;
            MySqlCommand cmd = Connection.CreateCommand();
            string Insert = "INSERT INTO tblcustomer (KodeCust, NamaCust,AlamatCust ,HpCust,EmailCust,Datenow,DateUpdate)";
            Insert += " VALUES (@KodeCust,@NamaCust,@AlamatCust,@HpCust,@EmailCust,@Datenow,@DateUpdate)";
            try
            {
                cmd.CommandText = Insert;
                cmd.Parameters.AddWithValue("@KodeCust", KodeCust);
                cmd.Parameters.AddWithValue("@NamaCust", NamaCust);
                cmd.Parameters.AddWithValue("@AlamatCust", AlamatCust);
                cmd.Parameters.AddWithValue("@HpCust", Convert.ToInt32(HpCust));
                cmd.Parameters.AddWithValue("@EmailCust", EmailCust);
                cmd.Parameters.AddWithValue("@Datenow", DateTimeCust);
                cmd.Parameters.AddWithValue("@DateUpdate", DateTimeCust);
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barang Berhasil Disimpan");
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Simpan Database Error!");
            }
            finally
            {
                Connection.Close();
            }

        }

    }
}
