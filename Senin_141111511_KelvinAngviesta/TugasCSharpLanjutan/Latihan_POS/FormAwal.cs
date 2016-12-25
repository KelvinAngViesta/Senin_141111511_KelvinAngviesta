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

namespace Latihan_POS
{
    public partial class FormAwal : Form
    {
        //koneksi
        String myConnectionString = "Server=localhost;Database=database_project;Uid=root;Pwd='';";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public FormAwal()
        {
            InitializeComponent();
        }
       
        
        
        private void FormAwal_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(myConnectionString);
        }


        private void PicBox1_MouseHover(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.AddRegisBarang2;
        }

        private void PicBox1_MouseLeave(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.AddRegisBarang1;
        }
        private void PicBox_MouseHover(object sender, EventArgs e)
        {
            PicBox.Image = Resources.AddBarangCustomer1;
        }

        private void PicBox_MouseLeave(object sender, EventArgs e)
        {
            PicBox.Image = Resources.AddBarangCustomer2;
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

        private void PicBoxCust_MouseLeave(object sender, EventArgs e)
        {
            PicBoxCust.Image = Resources.AddCustomer1;
        }
        private void PicBox1_Click(object sender, EventArgs e)
        {
            FormRegistrationBarang FormRegis = new FormRegistrationBarang();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox.Hide();
            PicBox1.Hide();
            FormRegis.ShowDialog();
            
           
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            FormCustomer FormCust = new FormCustomer();
            PicBox2.Hide();
            PicBox4.Hide();
            PicBox.Hide();
            PicBox1.Hide();
            FormCust.ShowDialog();
        }

        private void PicBox4_Click(object sender, EventArgs e)
        {
           
        }

       
        }
    }

