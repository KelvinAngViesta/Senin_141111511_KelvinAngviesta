using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCSharpLanjutanLatihan5
{
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }
        private void FormEditor_Load(object sender, EventArgs e)
        {
            PanelWarna.Hide();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
            {
                PanelWarna.Show();
                pictureBox1.Show();
            }
        }

        private void PanelWarna_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
