using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TugasCSharpLanjutanLatihan5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContextMenu ClikKanan = new ContextMenu();
            ClikKanan.MenuItems.Add("Copy", copyToolStripMenuItem_Click);
            ClikKanan.MenuItems.Add("Cut", cutToolStripMenuItem_Click);
            ClikKanan.MenuItems.Add("Paste", pasteToolStripMenuItem_Click);
            ClikKanan.MenuItems.Add("Delete", deleteToolStripMenuItem_Click);
            richTextBox1.ContextMenu = ClikKanan;
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

        private void tsbbtnBold_Click(object sender, EventArgs e)
        {
            Font Bold, NonBold;
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

        private void CmbboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(CmbboxSize.SelectedItem.ToString()));
        }

        private void CmbboxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(CmbboxFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var Warna = new ColorDialog();
            if (Warna.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = Warna.Color;
            }
        }
        String filename;
        Boolean Newfile = false;

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Pilih File";
            OpenFile.Filter = "Text Files(*.txt)|*.txt|Semua Files(*.*)|";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamRead = new StreamReader(File.OpenRead(OpenFile.FileName));
                richTextBox1.Text = streamRead.ReadToEnd();
                streamRead.Dispose();
                filename = OpenFile.FileName;
                richTextBox1.Enabled = true;
                LblFileName.Text = "";
                LblFileName.Text = "(*Sedang diedit)" + filename;

            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Newfile == false)
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.Title = "Pilih Tempat Penyimpanan ";
                SaveFile.Filter = "Text Files(*.txt)|*.txt|Semua Files(*.*)|";
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(File.Create(SaveFile.FileName));
                    streamWriter.Write(richTextBox1.Text);
                    streamWriter.Dispose();
                    filename = SaveFile.FileName;
                    LblFileName.Text = filename;
                }

            }
            else if (Newfile == true)
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.Title = "Pilih Tempat Penyimpanan ";
                SaveFile.Filter = "Text Files(*.txt)|*.txt|Semua Files(*.*)|";
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(File.Create(SaveFile.FileName));
                    streamWriter.Write(richTextBox1.Text);
                    streamWriter.Dispose();
                    filename = SaveFile.FileName;
                    LblFileName.Text = filename;
                    Newfile = false;
                }

            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newfile = true;
            richTextBox1.Enabled = true;
            richTextBox1.Text = "";
            LblFileName.Text = "File Name : *Untitled";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Modified)
            {
                if (MessageBox.Show("File Belum Tersimpan ! Apakah anda ingin keluar ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveFileDialog SaveFile = new SaveFileDialog();
                    SaveFile.Filter = "Text Files(*.txt)|*.txt|Semua Files(*.*)|";
                    SaveFile.FileName = "";
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFile.FileName, richTextBox1.Text);
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void BtnSaveEdit_Click(object sender, EventArgs e)
        {
            StreamWriter streamWrite = new StreamWriter(filename);
            streamWrite.Write(richTextBox1.Text);
            streamWrite.Dispose();
            LblFileName.Text = filename;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart,richTextBox1.SelectionLength);

        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


      
    }
}
