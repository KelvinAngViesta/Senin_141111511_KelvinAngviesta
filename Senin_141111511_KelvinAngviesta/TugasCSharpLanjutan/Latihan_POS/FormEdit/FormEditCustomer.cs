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


namespace Latihan_POS.FormEdit
{
    public partial class FormEditCustomer : Form
    {
        public FormEditCustomer()
        {
            InitializeComponent();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            String cari = TxtIdEditCust.Text,
                    KodeEditCust = TxtKodeEditCust.Text,
                    NamaEditCust = TxtNamaEditCust.Text,
                    AlamatEditCust = TxtAlamatEditCust.Text,
                    HpCust = TxtEditHp.Text,
                    EmailCust = TxtEditEmailCust.Text;
            PnlEditCust.Visible = false;
            try
            {
                ClassCari classcari = new ClassCari();
                classcari.Cari(cari, KodeEditCust, NamaEditCust, AlamatEditCust, HpCust, EmailCust);
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Simpan Database Error!");
            }
            }
    }
}
