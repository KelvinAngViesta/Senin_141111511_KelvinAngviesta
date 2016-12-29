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

namespace Latihan_POS.FormLihatAll
{
    public partial class FormAlldata : Form
    {
        public FormAlldata()
        {
            InitializeComponent();
            ViewAllItem ViewItemBarang = new ViewAllItem();
            ViewItemBarang.ViewTableBarang(DgViewBarang);
        }

        private void FormAlldata_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
