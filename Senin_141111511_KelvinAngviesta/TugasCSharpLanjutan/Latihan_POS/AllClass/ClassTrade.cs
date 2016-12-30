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
    class ClassTrade
    {
        MySqlConnection conn;
        String ConnString = "Server=Localhost; Database=database_latihan_pos; Uid=root; Pwd='';";
        public void TradeBarang(String namaBrg, String namaSupp, Decimal banyak, Decimal hargaSatuan, Decimal Totharga)
        {
            conn = new MySqlConnection(ConnString);

            try
            {
                conn.Open();
                string insert = "INSERT INTO tbltrade (namaBarang,namaSupp,banyakTrade,hargaSatuan,totalHarga,waktuTrade)";
                insert += " VALUES (@namaBrg,@namaSupp,@banyak,@hargaSatuan,@total,@waktu)";
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@namabrg", namaBrg);
                cmd.Parameters.AddWithValue("@namaSupp", namaSupp);
                cmd.Parameters.AddWithValue("@banyak", banyak);
                cmd.Parameters.AddWithValue("@hargaSatuan", hargaSatuan);
                cmd.Parameters.AddWithValue("@total", Totharga);
                cmd.Parameters.AddWithValue("@waktu", waktuNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barang berhasil dibeli");
            }
            finally
            {
                conn.Close();
            }
        }
        public void SellBarang(String namaBrg, String namaSupp, Decimal banyak, Decimal hargaSatuan, Decimal Totharga)
        {
            conn = new MySqlConnection(ConnString);

            try
            {
                conn.Open();
                string insert = "INSERT INTO tblSell (namaBarang,namaCustomer,banyakTrade,hargaSatuan,totalHarga,waktuTrade)";
                insert += " VALUES (@namaBrg,@namaSupp,@banyak,@hargaSatuan,@total,@waktu)";
                DateTime sekarang = DateTime.Now;
                String waktuNow = sekarang.ToString("yyyy/MM/dd HH:mm:ss");
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = insert;
                cmd.Parameters.AddWithValue("@namabrg", namaBrg);
                cmd.Parameters.AddWithValue("@namaSupp", namaSupp);
                cmd.Parameters.AddWithValue("@banyak", banyak);
                cmd.Parameters.AddWithValue("@hargaSatuan", hargaSatuan);
                cmd.Parameters.AddWithValue("@total", Totharga);
                cmd.Parameters.AddWithValue("@waktu", waktuNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barang berhasil dibeli");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
