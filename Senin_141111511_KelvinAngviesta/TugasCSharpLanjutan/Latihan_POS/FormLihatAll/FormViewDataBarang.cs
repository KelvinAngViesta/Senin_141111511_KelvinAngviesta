using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.FormLihatAll;
using Latihan_POS.Properties;

namespace Latihan_POS.FormLihatAll
{
    public partial class FormViewDataBarang : Form
    {
        public FormViewDataBarang()
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
        private void PicBoxCust_Click(object sender, EventArgs e)
        {
            FormAlldata formDataBarang = new FormAlldata();
            FormViewCust formDataCust = new FormViewCust();
            FormViewSupplier formDataSup = new FormViewSupplier();
            formDataBarang.Show();
            formDataCust.Hide();
            formDataSup.Hide();

        }

        private void PicBoxCost_Click(object sender, EventArgs e)
        {
            FormAlldata formDataBarang = new FormAlldata();
            FormViewCust formDataCust = new FormViewCust(); 
            FormViewSupplier formDataSup = new FormViewSupplier();
            formDataCust.Show();
            formDataBarang.Hide();
            formDataSup.Hide();
        }

        private void PicBoxSupp_Click(object sender, EventArgs e)
        {
            FormAlldata formDataBarang = new FormAlldata();
            FormViewCust formDataCust = new FormViewCust();
            FormViewSupplier formDataSup = new FormViewSupplier(); 
            formDataSup.Show();
            formDataCust.Hide();
            formDataBarang.Hide();
            

        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            FormAwal formawal = new FormAwal();
            FormAlldata formDataBarang = new FormAlldata();
            FormViewCust formDataCust = new FormViewCust();
            FormViewSupplier formDataSup = new FormViewSupplier();
            formDataSup.Close();
            formDataCust.Close();
            formDataBarang.Close();
            formawal.ShowDialog();
        }

        
    }
}
