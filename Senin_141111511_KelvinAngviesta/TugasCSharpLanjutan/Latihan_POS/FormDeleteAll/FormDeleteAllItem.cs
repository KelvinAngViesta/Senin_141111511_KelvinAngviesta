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

namespace Latihan_POS.FormDeleteAll
{
    public partial class FormDeleteAllItem : Form
    {
        public FormDeleteAllItem()
        {
            InitializeComponent();
        }
        private void PicBoxClose_MouseHover(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed2;
        }

        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed;
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string cariKode = TxtKode.Text;
            string nama = CmboBoxItem.SelectedItem.ToString();
            CariTabel cariTabels = new CariTabel();
            bool hasil = cariTabels.CekAllKode(cariKode, nama);
            if (CmboBoxItem.SelectedIndex == 0)
            {
                if (cariKode.Trim() != "" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteAllItem deleteAllitem = new DeleteAllItem();
                        deleteAllitem.hapusBarang(cariKode);
                        MessageBox.Show("Hapus Data barang Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ada !");
                }
            }
            if (CmboBoxItem.SelectedIndex == 1)
            {
                if (cariKode.Trim() != "" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteAllItem deleteAllitem = new DeleteAllItem();
                        deleteAllitem.hapusCustomer(cariKode);
                        MessageBox.Show("Hapus Data Customer Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ada !");
                }
            }
            if (CmboBoxItem.SelectedIndex == 2)
            {
                if (cariKode.Trim() != "" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteAllItem deleteAllitem = new DeleteAllItem();
                        deleteAllitem.hapusSupplier(cariKode);
                        MessageBox.Show("Hapus Data Supplier Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ada !");
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
            FormAwal form = new FormAwal();
            FormDeleteAllItem formDelete = new FormDeleteAllItem();
            formDelete.Show();
            formDelete.Close();
        }

        private void FormDeleteAllItem_Load(object sender, EventArgs e)
        {
            CmboBoxItem.Items.Add("Barang");
            CmboBoxItem.Items.Add("Customer");
            CmboBoxItem.Items.Add("Supplier");
            CmboBoxItem.SelectedIndex = 0;
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            FormAwal formawal = new FormAwal();
            FormDeleteAllItem formDelete = new FormDeleteAllItem();
            formDelete.Close();
            formawal.ShowDialog();
        }

        
    }
}
