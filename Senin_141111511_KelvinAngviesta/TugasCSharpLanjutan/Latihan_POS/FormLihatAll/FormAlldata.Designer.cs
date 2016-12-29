namespace Latihan_POS.FormLihatAll
{
    partial class FormAlldata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlldata));
            this.DgViewBarang = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahAwal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaHpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglbuatbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglupdatebarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // DgViewBarang
            // 
            this.DgViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kode,
            this.nama,
            this.jumlahAwal,
            this.hargaHpp,
            this.hargajual,
            this.tglbuatbarang,
            this.tglupdatebarang});
            this.DgViewBarang.Location = new System.Drawing.Point(3, 5);
            this.DgViewBarang.Name = "DgViewBarang";
            this.DgViewBarang.Size = new System.Drawing.Size(704, 208);
            this.DgViewBarang.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // kode
            // 
            this.kode.HeaderText = "Kode Barang";
            this.kode.Name = "kode";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Barang";
            this.nama.Name = "nama";
            // 
            // jumlahAwal
            // 
            this.jumlahAwal.HeaderText = "Jumlah Awal";
            this.jumlahAwal.Name = "jumlahAwal";
            // 
            // hargaHpp
            // 
            this.hargaHpp.HeaderText = "Harga HPP";
            this.hargaHpp.Name = "hargaHpp";
            // 
            // hargajual
            // 
            this.hargajual.HeaderText = "Harga Jual";
            this.hargajual.Name = "hargajual";
            // 
            // tglbuatbarang
            // 
            this.tglbuatbarang.HeaderText = "DateTime Barang";
            this.tglbuatbarang.Name = "tglbuatbarang";
            // 
            // tglupdatebarang
            // 
            this.tglupdatebarang.HeaderText = "DateTime Update Barang";
            this.tglupdatebarang.Name = "tglupdatebarang";
            // 
            // FormAlldata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 222);
            this.Controls.Add(this.DgViewBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlldata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlldata";
            this.Load += new System.EventHandler(this.FormAlldata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahAwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaHpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajual;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglbuatbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglupdatebarang;
    }
}