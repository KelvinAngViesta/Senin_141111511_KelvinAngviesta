using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

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
            Form1 form = (Form1)MdiParent;            
            PanelWarna.Visible = false;
            foreach (KnownColor Color in Enum.GetValues(typeof(KnownColor)))
            {
                CmboxBackGround.Items.Add(Color);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
            {
                PanelWarna.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FormUtama = (Form1)MdiParent;
            FormUtama.richTextBox1.BackColor = Color.FromName(CmboxBackGround.Text);
            FormUtama.show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Warna = new ColorDialog();
            if (Warna.ShowDialog() == DialogResult.OK)
            {
                Form1 FormUtama = (Form1)MdiParent;
                FormUtama.richTextBox1.BackColor = Warna.Color;
                FormUtama.show();
                this.Close();
            }
        }

        

        
    }
}
