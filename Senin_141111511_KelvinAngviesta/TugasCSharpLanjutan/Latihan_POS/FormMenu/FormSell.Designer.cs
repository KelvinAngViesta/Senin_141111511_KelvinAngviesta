namespace Latihan_POS.FormMenu
{
    partial class FormSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSell));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlItem = new System.Windows.Forms.Panel();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.TxtHarga = new System.Windows.Forms.TextBox();
            this.CmboBox = new System.Windows.Forms.ComboBox();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.TxtNamaSupp = new System.Windows.Forms.TextBox();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.ID_Barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PicBoxClose = new System.Windows.Forms.PictureBox();
            this.PnlItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total Harga    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Jumlah Barang    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nama Barang      :";
            // 
            // PnlItem
            // 
            this.PnlItem.Controls.Add(this.label4);
            this.PnlItem.Controls.Add(this.label3);
            this.PnlItem.Controls.Add(this.label2);
            this.PnlItem.Controls.Add(this.TxtNamaBarang);
            this.PnlItem.Controls.Add(this.TxtHarga);
            this.PnlItem.Controls.Add(this.CmboBox);
            this.PnlItem.Controls.Add(this.BtnKeluar);
            this.PnlItem.Controls.Add(this.BtnCancel);
            this.PnlItem.Location = new System.Drawing.Point(326, 10);
            this.PnlItem.Name = "PnlItem";
            this.PnlItem.Size = new System.Drawing.Size(346, 183);
            this.PnlItem.TabIndex = 58;
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.BackColor = System.Drawing.Color.White;
            this.TxtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaBarang.Enabled = false;
            this.TxtNamaBarang.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaBarang.Location = new System.Drawing.Point(167, 23);
            this.TxtNamaBarang.Multiline = true;
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.ReadOnly = true;
            this.TxtNamaBarang.Size = new System.Drawing.Size(156, 23);
            this.TxtNamaBarang.TabIndex = 2;
            // 
            // TxtHarga
            // 
            this.TxtHarga.BackColor = System.Drawing.Color.White;
            this.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHarga.Enabled = false;
            this.TxtHarga.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHarga.Location = new System.Drawing.Point(167, 89);
            this.TxtHarga.Multiline = true;
            this.TxtHarga.Name = "TxtHarga";
            this.TxtHarga.ReadOnly = true;
            this.TxtHarga.Size = new System.Drawing.Size(156, 23);
            this.TxtHarga.TabIndex = 3;
            // 
            // CmboBox
            // 
            this.CmboBox.BackColor = System.Drawing.Color.White;
            this.CmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBox.FormattingEnabled = true;
            this.CmboBox.Location = new System.Drawing.Point(167, 59);
            this.CmboBox.Name = "CmboBox";
            this.CmboBox.Size = new System.Drawing.Size(157, 21);
            this.CmboBox.TabIndex = 4;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.BackColor = System.Drawing.Color.Yellow;
            this.BtnKeluar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeluar.Location = new System.Drawing.Point(171, 123);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(75, 26);
            this.BtnKeluar.TabIndex = 48;
            this.BtnKeluar.Text = "Tambah";
            this.BtnKeluar.UseVisualStyleBackColor = false;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(249, 123);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnCancel.TabIndex = 47;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kode Customer   :";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.Color.Black;
            this.Lbl1.Location = new System.Drawing.Point(17, 33);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(134, 23);
            this.Lbl1.TabIndex = 56;
            this.Lbl1.Text = "Kode Barang       :";
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.Yellow;
            this.BtnSimpan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Location = new System.Drawing.Point(235, 102);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 26);
            this.BtnSimpan.TabIndex = 55;
            this.BtnSimpan.Text = "Cari Barang";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // TxtNamaSupp
            // 
            this.TxtNamaSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaSupp.Location = new System.Drawing.Point(154, 64);
            this.TxtNamaSupp.Multiline = true;
            this.TxtNamaSupp.Name = "TxtNamaSupp";
            this.TxtNamaSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtNamaSupp.TabIndex = 54;
            // 
            // TxtKode
            // 
            this.TxtKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKode.Location = new System.Drawing.Point(154, 35);
            this.TxtKode.Multiline = true;
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(156, 23);
            this.TxtKode.TabIndex = 53;
            // 
            // dgvSell
            // 
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Barang,
            this.Nama,
            this.NamaCu,
            this.jumlahBeli,
            this.harga,
            this.hargaakhir,
            this.waktu});
            this.dgvSell.Location = new System.Drawing.Point(21, 199);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.Size = new System.Drawing.Size(681, 252);
            this.dgvSell.TabIndex = 55;
            // 
            // ID_Barang
            // 
            this.ID_Barang.HeaderText = "ID";
            this.ID_Barang.Name = "ID_Barang";
            this.ID_Barang.ReadOnly = true;
            this.ID_Barang.Visible = false;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "NamaBarang";
            this.Nama.Name = "Nama";
            // 
            // NamaCu
            // 
            this.NamaCu.HeaderText = "NamaCustomer";
            this.NamaCu.Name = "NamaCu";
            // 
            // jumlahBeli
            // 
            this.jumlahBeli.HeaderText = "Jumlah Beli";
            this.jumlahBeli.Name = "jumlahBeli";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga / Unit";
            this.harga.Name = "harga";
            // 
            // hargaakhir
            // 
            this.hargaakhir.HeaderText = "Harga Akhir";
            this.hargaakhir.Name = "hargaakhir";
            // 
            // waktu
            // 
            this.waktu.HeaderText = "Waktu Beli";
            this.waktu.Name = "waktu";
            this.waktu.Width = 140;
            // 
            // PicBoxClose
            // 
            this.PicBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxClose.Image")));
            this.PicBoxClose.Location = new System.Drawing.Point(694, 5);
            this.PicBoxClose.Name = "PicBoxClose";
            this.PicBoxClose.Size = new System.Drawing.Size(27, 30);
            this.PicBoxClose.TabIndex = 55;
            this.PicBoxClose.TabStop = false;
            this.PicBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 460);
            this.Controls.Add(this.PicBoxClose);
            this.Controls.Add(this.dgvSell);
            this.Controls.Add(this.PnlItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtNamaSupp);
            this.Controls.Add(this.TxtKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSell";
            this.Load += new System.EventHandler(this.FormSell_Load);
            this.PnlItem.ResumeLayout(false);
            this.PnlItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlItem;
        private System.Windows.Forms.TextBox TxtNamaBarang;
        private System.Windows.Forms.TextBox TxtHarga;
        private System.Windows.Forms.ComboBox CmboBox;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.TextBox TxtNamaSupp;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private System.Windows.Forms.PictureBox PicBoxClose;
    }
}