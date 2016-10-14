using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCSharpLanjutanLatihan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (FontFamily font in FontFamily.Families)
            {

                CmbboxFont.Items.Add(font.Name.ToString());
               
               
            }
            
            for (int i = 2; i <= 115; i += 2)
            {
                CmbboxSize.Items.Add(i);
                
            }
            CmbboxSize.SelectedIndex = 5;
            CmbboxFont.Text = "Times New Roman";
            
            
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font Bold,NonBold;
            NonBold = richTextBox1.SelectionFont;
            if (NonBold.Bold)
            {
                Bold = new Font(NonBold, NonBold.Style & ~FontStyle.Bold);
                tsbbtnBold.Checked = false;
            }
            else
            {
               Bold = new Font(NonBold, NonBold.Style | FontStyle.Bold);
               tsbbtnBold.Checked = true;
            }
            richTextBox1.SelectionFont = Bold;
        }

        private void tsbbtnItalic_Click(object sender, EventArgs e)
        {
            Font Italic, NonItalic;
            NonItalic = richTextBox1.SelectionFont;
            if (NonItalic.Italic)
            {
                Italic = new Font(NonItalic, NonItalic.Style & ~FontStyle.Italic);
                tsbbtnItalic.Checked = false;
            }
            else
            {
                Italic = new Font(NonItalic, NonItalic.Style | FontStyle.Italic);
                tsbbtnItalic.Checked = true;
            }
            richTextBox1.SelectionFont = Italic;
        }

        private void tsbbtnUnderline_Click(object sender, EventArgs e)
        {
            Font UnderLine, NonUnderline;
            NonUnderline = richTextBox1.SelectionFont;
            if (NonUnderline.Underline)
            {
                UnderLine = new Font(NonUnderline, NonUnderline.Style & ~FontStyle.Underline);
                tsbbtnUnderline.Checked = false;
            }
            else
            {
                UnderLine = new Font(NonUnderline, NonUnderline.Style | FontStyle.Underline);
                tsbbtnUnderline.Checked = true;
            }
            richTextBox1.SelectionFont = UnderLine;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var Warna = new ColorDialog();
            Warna.ShowDialog();
            richTextBox1.ForeColor = Warna.Color;
        }

 
        private void CmbboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(CmbboxFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void CmbboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(CmbboxSize.SelectedItem.ToString()));
           
        }
       
      
    }
}
