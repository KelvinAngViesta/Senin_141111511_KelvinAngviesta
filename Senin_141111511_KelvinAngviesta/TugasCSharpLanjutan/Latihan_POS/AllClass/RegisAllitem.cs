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
    class RegisAllitem
    {
        static MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=database_latihan_pos;Uid=root;password=;");
        
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
            DateTime DateTimeBarang= DateTime.Now;
            String DateTimeBrgNow = DateTimeBarang.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime DateTimeBrgUp = DateTime.Now;
            String DateTimeBrgUpdate = DateTimeBrgUp.ToString("yyyy/MM/dd HH:mm:ss");
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
                 cmd.Parameters.AddWithValue("@TglBarang", DateTimeBrgNow);
                 cmd.Parameters.AddWithValue("@TglUpdateBarang", DateTimeBrgUpdate);
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
        public void TambahCust(string KodeCust, string NamaCust, string AlamatCust, string HpCust, string EmailCust)
        {
            RegisAllitem regisbarang = new RegisAllitem();
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
            String DateTimeCustNow = DateTimeCust.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime DateTimeCustup = DateTime.Now;
            String DateTimeCustUpdate = DateTimeCust.ToString("yyyy/MM/dd HH:mm:ss");
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
                cmd.Parameters.AddWithValue("@Datenow", DateTimeCustNow);
                cmd.Parameters.AddWithValue("@DateUpdate", DateTimeCustUpdate);
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
        public void TambahRegiSup(string KodeSup, string NamaSup, string AlamatSup, string HpSup, string EmailSup)
        {
            RegisAllitem regisbarang = new RegisAllitem();
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
            DateTime DateTimeSup = DateTime.Now;
            String DateTimeSupNow = DateTimeSup.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime DateTimeSupup = DateTime.Now;
            String DateTimeSupUpdate = DateTimeSupup.ToString("yyyy/MM/dd HH:mm:ss");
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
                cmd.Parameters.AddWithValue("@Datenow", DateTimeSupNow);
                cmd.Parameters.AddWithValue("@DateUpdate", DateTimeSupUpdate);
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
