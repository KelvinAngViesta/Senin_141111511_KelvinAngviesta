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
    public partial class FormTradee : Form
    {
        public FormTradee()
        {
            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            CariTabel cariTabels = new CariTabel();
            bool hasilBarang = cariTabels.CekAllKode(TxtKode.Text, "Barang");
            bool hasilSupplier = cariTabels.CekAllKode(TxtNamaSupp.Text, "Supplier");
            //MessageBox.Show(Convert.ToString(hasilSupplier));
            if (hasilBarang && hasilSupplier == true)
            {
                PnlItem.Visible = true;
                cariTabels.CeKBarang(TxtKode.Text,TxtNamaBarang,TxtHarga,CmboBox);
            }
            else
            {
                MessageBox.Show("Salah Satu kode salah");
                PnlItem.Visible = false;
            }
        }

        private void FormTradee_Load(object sender, EventArgs e)
        {
            PnlItem.Visible = false;
        }
        public void ViewTable()
        {
            ViewAllItem view = new ViewAllItem();
            view.ViewTableSell(DgvTraded);
            
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            ClassTrade classTrade = new ClassTrade();
            Decimal hargaAkhir;
            Decimal quantitas = Convert.ToDecimal(CmboBox.SelectedItem);
            Decimal hargawal = Convert.ToDecimal(TxtHarga.Text);
            hargaAkhir = quantitas * hargawal;
            classTrade.TradeBarang(TxtNamaBarang.Text, TxtKode.Text, quantitas, hargawal, hargaAkhir);
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
            FormTradee formtrade = new FormTradee();
            FormAwal formawal = new FormAwal();
            formtrade.Close();
            formawal.ShowDialog();
        }

        
    }
}
