using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class FormRegistrationBarang : Form
    {
        //koneksi
        String myConnectionString = "Server=localhost;Database=database_latihan_pos;Uid=root;Pwd='';";
        MySqlConnection conn;
        MySqlCommand cmd;
        public FormRegistrationBarang()
        {
            InitializeComponent();
        }

        private void FormRegistrationBarang_Load(object sender, EventArgs e)
        {
            FormAwal form = (FormAwal)MdiParent;
            conn = new MySqlConnection(myConnectionString);
        }
        private int isNumber(String number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                //MessageBox.Show(number[i]+" < '0' && " +number[i]+" > '9'");
                if ((int)number[i] < (int)'0' || (int)number[i] > (int)'9')
                {
                    MessageBox.Show("Bukan Angka");
                    return -1;
                }
            }
            return 0;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String IdBrg = TxtIdBrg.Text;
            String JlhBrg = TxtJlhBrg.Text;
            String HrgBrg = TxtHrgBrg.Text;
            String HrgJualBrg = TxtHrgJual.Text;
            String KodeBrg = TxtKodeBrg.Text;
            String NamaBrg = TxtNamaBrg.Text;

            if (isNumber(TxtIdBrg.Text) == -1)
            {
                MessageBox.Show("Id Barang Harus Angka !");
                IdBrg = "";
                return;
            }
            else if (isNumber(TxtJlhBrg.Text) == -1)
            {
                MessageBox.Show("Jumlah Barang Harus Angka !");
                JlhBrg = "";
                return;
            }
            else if (isNumber(TxtHrgBrg.Text) == -1)
            {
                MessageBox.Show("Harga Barang Harus Angka!");
                HrgBrg = "";
                return;
            }
            else if (isNumber(TxtHrgJual.Text) == -1)
            {
                MessageBox.Show("Harga Jual Barang Harus Angka!");
                HrgJualBrg = "";
                return;
            }
            else if (TxtKodeBrg.Text == "")
            {
                MessageBox.Show("Kode Barang Harus Diisi!");
                return;
            }
            else if (TxtNamaBrg.Text == "")
            {
                MessageBox.Show("Nama Barang Harus Diisi");
                return;
            }
            conn.Open();
            //databasename
            //id,kode,nama,jumlahAwal,hargaHPP,hargajual
            try
            {
                cmd = conn.CreateCommand();
                String values = "'" + IdBrg + "', '" + KodeBrg + "', '" + NamaBrg + "', '" + JlhBrg + "', '" + HrgBrg + "', '" + HrgJualBrg + "'";
                cmd.CommandText = "INSERT INTO tblbarang (id, kode,nama, jumlahAwal, hargaHPP, hargajual) VALUES(" + values + ");";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Barang Berhasil Disimpan");
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Simpan Database Error!");
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            FormAwal form = (FormAwal)MdiParent;
            form.Show();
            this.Close();
        }

    }
}
