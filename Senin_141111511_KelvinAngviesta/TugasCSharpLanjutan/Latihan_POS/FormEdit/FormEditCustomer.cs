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
using Latihan_POS.FormEdit;
using Latihan_POS.Properties;


namespace Latihan_POS.FormEdit
{
    public partial class FormEditCustomer : Form
    {
        public FormEditCustomer()
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
        private void FormEditCustomer_Load(object sender, EventArgs e)
        {
            PnlEditCust.Visible = false;
            PnlEditBarang.Visible = false;
            PnlEditSuppl.Visible = false;
            CmboBoxItem.SelectedIndex = 0;
            if (CmboBoxItem.SelectedItem.ToString() == "Customer")
            {
            }
            CariTabel cariTabel = new CariTabel();
        }
        private void BtnCari_Click(object sender, EventArgs e)
        {
            
            
           
            if (CmboBoxItem.SelectedIndex == 0)
            {
                String kode = TxtIdBarang.Text;
                String id = TxtIdBarang.Text; 
                string nama = CmboBoxItem.SelectedItem.ToString();
                CariTabel cariTabels = new CariTabel();
                bool hasil = cariTabels.CekAllKode(id, nama);
                if (kode.Trim() != "" && hasil)
                {
                    PnlEditBarang.Visible = true;
                    TxtEditBarangId.Text = kode;
                    MessageBox.Show("Kode Barang Bersifat Tetap");
                    PnlEditCust.Visible = false;
                    PnlEditSuppl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kode tidak ditemukan");
                }

            }
            if (CmboBoxItem.SelectedIndex == 1)
            {
                String id = TxtIdBarang.Text; String kode = TxtIdBarang.Text; 
                string nama = CmboBoxItem.SelectedItem.ToString();
                CariTabel cariTabels = new CariTabel();
                bool hasil = cariTabels.CekAllKode(kode, nama);
                if (kode.Trim() != "" && hasil)
                {
                    PnlEditCust.Visible = true;
                    TxtKodeEditCust.Text = kode;
                    PnlEditBarang.Visible = false;
                    PnlEditSuppl.Visible = false;
                   
                }
                else
                {
                    MessageBox.Show("KodeCustomer Tidak ditemukan");
                }
            }
            if (CmboBoxItem.SelectedIndex == 2)
            {
                String kode = TxtIdBarang.Text;
                string nama = CmboBoxItem.SelectedItem.ToString();
                CariTabel cariTabels = new CariTabel();
                bool hasil = cariTabels.CekAllKode(kode, nama);
                MessageBox.Show(nama);
                if (kode.Trim() != "" && hasil)
                {
                    PnlEditSuppl.Visible = true;
                    TxtKodeSupp.Text = kode;
                    PnlEditCust.Visible = false;
                    PnlEditBarang.Visible = false;
         
                }
                else
                {
                    MessageBox.Show("Kode Supplier tidak ditemukan");
                }
            }
            
        }

       

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string id = CmboBoxItem.SelectedItem.ToString();
            EditAll editCust = new EditAll();
            editCust.editCustomer(TxtEditBarangId.Text, TxtNamaEditCust.Text, TxtAlamatEditCust.Text, TxtEditHp.Text, TxtEditEmailCust.Text);
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

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            FormEditCustomer formedit = new FormEditCustomer();
            FormAwal formawal = new FormAwal();
            formedit.Close();
            formawal.ShowDialog();
            
        }

        private void BtnSimpanEditBarang_Click(object sender, EventArgs e)
        {
            string id = CmboBoxItem.SelectedItem.ToString();
            EditAll editBrg = new EditAll();
            editBrg.editCariBrg(TxtEditBarangId.Text, TxtKodeBrgEdit.Text, TxtNamaEditBrg.Text, TxtJmlahBrgEdit.Text, TxtHargaHppEdit.Text, TxtHargaJualEdit.Text);
       
         }

        private void BtnCancelEdit_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnCancelSupp_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnSmpanEditSupp_Click(object sender, EventArgs e)
        {

            string Id = CmboBoxItem.SelectedItem.ToString();
            EditAll EditSup = new EditAll();
            EditSup.editSupplier(TxtKodeSupp.Text, TxtNamaSupp.Text, TxtAlamatSupp.Text, TxtNoHpSupp.Text, TxtEmailSupp.Text);
            
        }

        
    }
}
