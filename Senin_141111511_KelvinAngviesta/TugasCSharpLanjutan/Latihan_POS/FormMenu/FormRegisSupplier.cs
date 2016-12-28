using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.AllClass;
using Latihan_POS.FormMenu;


namespace Latihan_POS.FormMenu
{
    public partial class FormRegisSupplier : Form
    {
        public FormRegisSupplier()
        {
            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            String KodeSup = TxtKodeSup.Text,
                   NamaSup = TxtNamaSup.Text,
                   AlamatSup = TxtAlamatSup.Text,
                   HpSup = TxHpSup.Text,
                   EmailSup = TxtEmailSup.Text;
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
                RegisAllitem regisAllitem = new RegisAllitem();
                regisAllitem.TambahRegiSup(KodeSup, NamaSup, AlamatSup, HpSup, EmailSup);
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
            FormRegisSupplier formRegisSup = new FormRegisSupplier();
            form.Show();
            formRegisSup.Close();
        }
    }
}
