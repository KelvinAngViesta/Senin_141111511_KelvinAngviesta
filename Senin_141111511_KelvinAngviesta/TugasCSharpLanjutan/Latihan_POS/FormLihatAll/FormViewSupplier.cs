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

namespace Latihan_POS.FormLihatAll
{
    public partial class FormViewSupplier : Form
    {
        public FormViewSupplier()
        {
            InitializeComponent();

            ViewAllItem ViewItemBarang = new ViewAllItem();
            ViewItemBarang.ViewTableSupplier(DgViewSupp);
        }

        private void FormViewSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
