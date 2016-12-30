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
using Latihan_POS.Properties;

namespace Latihan_POS.FormMenu
{
    public partial class FormSell : Form
    {
        public FormSell()
        {
            InitializeComponent();
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            PnlItem.Visible = false;
            ViewTable();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            CariTabel cariTabels = new CariTabel();
            bool hasilBarang = cariTabels.CekAllKode(TxtKode.Text, "Barang");
            bool hasilCustomer = cariTabels.CekAllKode(TxtNamaSupp.Text, "Customer");
            //MessageBox.Show(Convert.ToString(hasilSupplier));
            if (hasilBarang && hasilCustomer == true)
            {
                PnlItem.Visible = true;
                cariTabels.CeKBarang(TxtKode.Text, TxtNamaBarang, TxtHarga, CmboBox);
            }
            else
            {
                MessageBox.Show("Salah Satu kode salah");
                PnlItem.Visible = false;
            }
        }
        public void ViewTable()
        {
            ViewAllItem view = new ViewAllItem();
            view.ViewTableSell(dgvSell);

        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {

            ClassTrade classTrade = new ClassTrade();
            Decimal hargaAkhir;
            Decimal quantitas = Convert.ToDecimal(CmboBox.SelectedItem);
            Decimal hargawal = Convert.ToDecimal(TxtHarga.Text);
            hargaAkhir = quantitas * hargawal;
            classTrade.SellBarang(TxtNamaBarang.Text, TxtKode.Text, quantitas, hargawal, hargaAkhir);
            ViewTable();
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
        private void PicBoxClose_MouseHover(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed2;
        }

        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed;
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            FormSell formtrade = new FormSell();
            FormAwal formawal = new FormAwal();
            formtrade.Close();
            formawal.ShowDialog();
        }
    }
}
