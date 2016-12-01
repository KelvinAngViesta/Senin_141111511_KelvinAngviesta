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
        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
        }

        private void FormAwal_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(myConnectionString);
        }
    }
}
