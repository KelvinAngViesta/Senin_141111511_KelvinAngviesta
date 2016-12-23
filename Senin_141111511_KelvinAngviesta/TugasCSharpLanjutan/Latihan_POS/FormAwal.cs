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
        FormRegistrationBarang FormRegis;
        FormAwal FormUtama;
        FormCustomer FormCust;
        
        
        private void FormAwal_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(myConnectionString);
        }

        private void custToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (FormCust == null || !FormCust.IsHandleCreated)
            {
                FormCust = new FormCustomer();
                FormCust.MdiParent = this;
                FormCust.BringToFront();
                FormCust.Show();
            }
            else if(FormRegis.Visible == true)
            {
                FormCust.Show();
                FormRegis.Hide();
            }
            }

        private void PicBox1_MouseHover(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.Green2;
        }

        private void PicBox1_MouseLeave(object sender, EventArgs e)
        {
            PicBox1.Image = Resources.Green1;
        }

        private void PicBox1_Click(object sender, EventArgs e)
        {
            if (FormRegis == null || !FormRegis.IsHandleCreated)
            {
                FormRegis = new FormRegistrationBarang();
                FormRegis.MdiParent = this;
                FormRegis.BringToFront();
                FormRegis.Show();
            }
            else
            {
                FormRegis.Show();
                FormCust.Hide();
            }
            PicBox1.Hide();
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            
        }



        }
    }

