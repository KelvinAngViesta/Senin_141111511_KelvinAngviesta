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
    class RegisSuplier
    {
        static MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=database_latihan_pos;Uid=root;password=;");
        public void TambahRegiSup(string KodeSup, string NamaSup, string AlamatSup, string HpSup, string EmailSup)
        {
            RegisBarang regisbarang = new RegisBarang();
            if (regisbarang.isNumber(KodeSup) == -1)
            {
                MessageBox.Show("Kode Harus Angka !");
                KodeSup = "";
                return;
            }
            else if (NamaSup == "")
            {
                MessageBox.Show("Nama Harus Diisi!");
                return;
            }
            else if (AlamatSup == "")
            {
                MessageBox.Show("Alamat Harus Diisi");
                return;
            }
            else if (regisbarang.isNumber(HpSup) == -1)
            {
                MessageBox.Show("Hp Harus Angka !");
                HpSup = "";
                return;
            }
            else if (EmailSup == "")
            {
                MessageBox.Show("Email Harus Diisi");
                return;
            }
            DateTime DateTimeCust = DateTime.Now;
            MySqlCommand cmd = Connection.CreateCommand();
            string Insert = "INSERT INTO tblsupplier (KodeSup, NamaSup,AlamatSup,HpSup,EmailSup,Datenow,DateUpdate)";
            Insert += " VALUES (@KodeSup,@NamaSup,@AlamatSup,@HpSup,@EmailSup,@Datenow,@DateUpdate)";
            try
            {
                cmd.CommandText = Insert;
                cmd.Parameters.AddWithValue("@KodeSup", KodeSup);
                cmd.Parameters.AddWithValue("@NamaSup", NamaSup);
                cmd.Parameters.AddWithValue("@AlamatSup", AlamatSup);
                cmd.Parameters.AddWithValue("@HpSup", Convert.ToInt32(HpSup));
                cmd.Parameters.AddWithValue("@EmailSup", EmailSup);
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
