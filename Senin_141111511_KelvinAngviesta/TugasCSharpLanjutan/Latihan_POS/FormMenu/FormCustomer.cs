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
namespace Latihan_POS
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {

            String KodeCust = TxtKodeCust.Text,
                   NamaCust = TxtNamaCust.Text,
                   AlamatCust = TxtAlamatCust.Text,
                   HpCust= TxHpCust.Text,
                   EmailCust = TxtEmailCust.Text;
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
                regisAllitem.TambahCust(KodeCust, NamaCust,AlamatCust,HpCust, EmailCust);
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
            FormCustomer FormCust = new FormCustomer();
            form.Show();
            FormCust.Close();
        }
    }
}
