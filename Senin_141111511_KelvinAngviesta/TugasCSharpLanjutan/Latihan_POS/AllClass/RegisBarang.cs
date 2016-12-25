using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Latihan_POS.AllClass;

namespace Latihan_POS.AllClass
{
    class RegisBarang
    {
        static MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=database_latihan_pos;Uid=root;password=;");

        MySqlCommand cmd;
        
        public int isNumber(String number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if ((int)number[i] < (int)'0' || (int)number[i] > (int)'9')
                {
                    return -1;
                }
            }
            return 0;
        }
        
        public void TambahBarang(string IdBarang,string KodeBarang,string NamaBarang,string HargaHPP,string HargaJual,string JlhBarang)
        {
            if (isNumber(IdBarang) == -1)
            {
                MessageBox.Show("Id Barang Harus Angka !");
                IdBarang= "";
                return;
            }
            else if (isNumber(JlhBarang) == -1)
            {
                MessageBox.Show("Jumlah Barang Harus Angka !");
                JlhBarang= "";
                return;
            }
            else if (isNumber(HargaHPP) == -1)
            {
                MessageBox.Show("Harga Barang Harus Angka!");
                HargaHPP = "";
                return;
            }
            else if (isNumber(HargaJual) == -1)
            {
                MessageBox.Show("Harga Jual Barang Harus Angka!");
                HargaJual = "";
                return;
            }
            else if (KodeBarang == "")
            {
                MessageBox.Show("Kode Barang Harus Diisi!");
                return;
            }
            else if (NamaBarang == "")
            {
                MessageBox.Show("Nama Barang Harus Diisi");
                return;
            }
            DateTime DateTimeNow = DateTime.Now;
            MySqlCommand cmd = Connection.CreateCommand();
            string Insert = "INSERT INTO tblbarang (id, kode,nama, jumlahAwal, hargaHPP, hargajual,tglbuatbarang,tglupdatebarang)";
            Insert += " VALUES (@IdBrg,@KodeBrg,@NamaBrg,@JlhBrg,@HrgBrg,@HrgJualBrg,@TglBarang,@TglUpdateBarang)";
            try
            {
                 cmd.CommandText = Insert;
                 cmd.Parameters.AddWithValue("@IdBrg", IdBarang);
                 cmd.Parameters.AddWithValue("@KodeBrg", KodeBarang);
                 cmd.Parameters.AddWithValue("@NamaBrg", NamaBarang);
                 cmd.Parameters.AddWithValue("@JlhBrg", Convert.ToInt32(JlhBarang));
                 cmd.Parameters.AddWithValue("@HrgBrg", Convert.ToInt32(HargaHPP));
                 cmd.Parameters.AddWithValue("@HrgJualBrg", Convert.ToInt32(HargaJual));
                 cmd.Parameters.AddWithValue("@TglBarang", DateTimeNow);
                 cmd.Parameters.AddWithValue("@TglUpdateBarang", DateTimeNow);
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
