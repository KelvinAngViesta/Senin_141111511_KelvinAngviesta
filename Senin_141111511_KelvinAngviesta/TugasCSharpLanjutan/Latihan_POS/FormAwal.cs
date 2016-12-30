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
using Latihan_POS.Properties;
using Latihan_POS.FormMenu;
using Latihan_POS.FormEdit;
using Latihan_POS.AllClass;
using Latihan_POS.FormDeleteAll;
using Latihan_POS.FormLihatAll;
namespace Latihan_POS
{
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
        }
       

        private void PicBox1_MouseHover(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.AddRegisBarang2;
            
        }
        private void FormAwal_Load(object sender, EventArgs e)
        {

        }
        private void PicBox1_MouseLeave(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.AddRegisBarang1;
        }
       
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PicBox2.Image = Resources.ListBarang2;
        }

        private void PicBox2_MouseLeave(object sender, EventArgs e)
        {
            PicBox2.Image = Resources.ListBarang;
        }
        private void PicBoxCust_MouseHover(object sender, EventArgs e)
        {
            PicBoxCust.Image = Resources.AddCustomer2;
        }
        private void PicBoxClose_MouseHover(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed2;
        }

        private void PicBoxClose_MouseLeave(object sender, EventArgs e)
        {
            PicBoxClose.Image = Resources.IconClosed;
        }

        private void PicBoxCust_MouseLeave(object sender, EventArgs e)
        {
            PicBoxCust.Image = Resources.AddCustomer1;
        }
        private void PicBoxSup_MouseHover(object sender, EventArgs e)
        {
            PicBoxSup.Image = Resources.Supplier2;
        }

        private void PicBoxSup_MouseLeave(object sender, EventArgs e)
        {
            PicBoxSup.Image = Resources.Supplier1;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PicEditCust.Image = Resources.EdiitAll2;
        }

        private void PicEditCust_MouseLeave(object sender, EventArgs e)
        {
            PicEditCust.Image = Resources.EditAll1;
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            PicBoxAddItem.Image = Resources.IconAddBarangNews2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PicBoxAddItem.Image = Resources.IconAddBarangNews1;
        }
        private void PicDeleteAll_MouseHover(object sender, EventArgs e)
        {
            PicDeleteAll.Image = Resources.data_delete_icon22;
        }

        private void PicDeleteAll_MouseLeave(object sender, EventArgs e)
        {
            PicDeleteAll.Image = Resources.data_delete_icon2;
        }
        private void PicBox1_Click(object sender, EventArgs e)
        {

            FormTradee formtrade = new FormTradee();
            FormAwal formawal = new FormAwal();
            formtrade.ShowDialog();
            
           
        }


        private void PicBox4_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicEditCust.Hide();
            PicDeleteAll.Hide();
            formAbout.ShowDialog();
        }

        private void PicBoxCust_Click(object sender, EventArgs e)
        {
            FormCustomer FormCust = new FormCustomer();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicBoxAddItem.Hide();
            PicEditCust.Hide();
            PicDeleteAll.Hide();
            FormCust.ShowDialog();
        }

        private void PicBoxSup_Click(object sender, EventArgs e)
        {
            FormRegisSupplier FormSup = new FormRegisSupplier();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicEditCust.Hide();
            PicBoxAddItem.Hide();
            PicDeleteAll.Hide();
            FormSup.ShowDialog();

        }

        private void PicEditCust_Click(object sender, EventArgs e)
        {
            FormEditCustomer FormEditCust = new FormEditCustomer();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicBoxAddItem.Hide();
            PicEditCust.Hide();
            PicDeleteAll.Hide();
            FormEditCust.ShowDialog();
            
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormRegistrationBarang FormRegis = new FormRegistrationBarang();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicEditCust.Hide();
            PicBoxAddItem.Hide();
            PicDeleteAll.Hide();
            FormRegis.ShowDialog();
        }

        private void PicDeleteAll_Click(object sender, EventArgs e)
        {
            FormDeleteAllItem formDelete = new FormDeleteAllItem();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox1.Hide();
            PicBoxCust.Hide();
            PicBoxClose.Hide();
            PicBoxSup.Hide();
            PicEditCust.Hide();
            PicBoxAddItem.Hide();
            PicDeleteAll.Hide();
            formDelete.ShowDialog();
        }

        private void PicBox2_Click(object sender, EventArgs e)
        {
            FormAwal formAwal = new FormAwal();
            FormViewDataBarang formview = new FormViewDataBarang();
            formview.ShowDialog();
            formAwal.Hide();
        }

        private void pictureBox1_MouseHover_2(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.IconStore2;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.IconStore1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormSell formsell = new FormSell();
            FormAwal formawal = new FormAwal();
            formsell.ShowDialog();
            formawal.Hide();
           
        }

        

       
        }
    }

