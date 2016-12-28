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
using Latihan_POS.AllClass;

namespace Latihan_POS
{
    public partial class FormRegistrationBarang : Form
    {
        public FormRegistrationBarang()
        {
            InitializeComponent();
        }

        private void FormRegistrationBarang_Load(object sender, EventArgs e)
        {
            FormAwal form = (FormAwal)MdiParent;
            
        }
       

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String IdBarang = TxtIdBrg.Text,
                   KodeBarang = TxtKodeBrg.Text,
                   NamaBarang = TxtNamaBrg.Text,
                   HargaHPP = TxtHrgBrg.Text,
                   HargaJual = TxtHrgJual.Text,
                   JlhBarang = TxtJlhBrg.Text;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "txtId" && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            try
            {
                RegisAllitem regisbarang = new RegisAllitem();
                regisbarang.TambahBarang(IdBarang, KodeBarang, NamaBarang, HargaHPP, HargaJual, JlhBarang);
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Simpan Database Error!");
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
            FormAwal form = new FormAwal();
            FormRegistrationBarang formregis = new FormRegistrationBarang();
            form.Show();
            formregis.Close();
        }

      

    }
}
