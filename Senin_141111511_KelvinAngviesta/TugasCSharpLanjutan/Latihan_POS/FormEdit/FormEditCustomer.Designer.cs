namespace Latihan_POS.FormEdit
{
    partial class FormEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCustomer));
            this.TxtIdBarang = new System.Windows.Forms.TextBox();
            this.BtnCari = new System.Windows.Forms.Button();
            this.CmboBoxItem = new System.Windows.Forms.ComboBox();
            this.TxtKodeEditCust = new System.Windows.Forms.TextBox();
            this.TxtNamaEditCust = new System.Windows.Forms.TextBox();
            this.TxtAlamatEditCust = new System.Windows.Forms.TextBox();
            this.TxtEditEmailCust = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtEditHp = new System.Windows.Forms.TextBox();
            this.PnlEditCust = new System.Windows.Forms.Panel();
            this.PicBoxClose = new System.Windows.Forms.PictureBox();
            this.PnlEditBarang = new System.Windows.Forms.Panel();
            this.TxtEditBarangId = new System.Windows.Forms.TextBox();
            this.TxtKodeBrgEdit = new System.Windows.Forms.TextBox();
            this.TxtNamaEditBrg = new System.Windows.Forms.TextBox();
            this.TxtJmlahBrgEdit = new System.Windows.Forms.TextBox();
            this.TxtHargaHppEdit = new System.Windows.Forms.TextBox();
            this.TxtHargaJualEdit = new System.Windows.Forms.TextBox();
            this.BtnSimpanEditBarang = new System.Windows.Forms.Button();
            this.BtnCancelEdit = new System.Windows.Forms.Button();
            this.PnlEditSuppl = new System.Windows.Forms.Panel();
            this.TxtKodeSupp = new System.Windows.Forms.TextBox();
            this.TxtNamaSupp = new System.Windows.Forms.TextBox();
            this.TxtAlamatSupp = new System.Windows.Forms.TextBox();
            this.TxtNoHpSupp = new System.Windows.Forms.TextBox();
            this.TxtEmailSupp = new System.Windows.Forms.TextBox();
            this.BtnSmpanEditSupp = new System.Windows.Forms.Button();
            this.BtnCancelSupp = new System.Windows.Forms.Button();
            this.PnlEditCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).BeginInit();
            this.PnlEditBarang.SuspendLayout();
            this.PnlEditSuppl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIdBarang
            // 
            this.TxtIdBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdBarang.Location = new System.Drawing.Point(193, 81);
            this.TxtIdBarang.Multiline = true;
            this.TxtIdBarang.Name = "TxtIdBarang";
            this.TxtIdBarang.Size = new System.Drawing.Size(156, 23);
            this.TxtIdBarang.TabIndex = 0;
            // 
            // BtnCari
            // 
            this.BtnCari.BackColor = System.Drawing.Color.Yellow;
            this.BtnCari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCari.Location = new System.Drawing.Point(275, 142);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 26);
            this.BtnCari.TabIndex = 1;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = false;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // CmboBoxItem
            // 
            this.CmboBoxItem.BackColor = System.Drawing.Color.White;
            this.CmboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBoxItem.FormattingEnabled = true;
            this.CmboBoxItem.Items.AddRange(new object[] {
            "Barang",
            "Customer",
            "Supplier"});
            this.CmboBoxItem.Location = new System.Drawing.Point(192, 113);
            this.CmboBoxItem.Name = "CmboBoxItem";
            this.CmboBoxItem.Size = new System.Drawing.Size(157, 21);
            this.CmboBoxItem.TabIndex = 3;
            // 
            // TxtKodeEditCust
            // 
            this.TxtKodeEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKodeEditCust.Enabled = false;
            this.TxtKodeEditCust.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKodeEditCust.Location = new System.Drawing.Point(195, 8);
            this.TxtKodeEditCust.Multiline = true;
            this.TxtKodeEditCust.Name = "TxtKodeEditCust";
            this.TxtKodeEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtKodeEditCust.TabIndex = 4;
            // 
            // TxtNamaEditCust
            // 
            this.TxtNamaEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaEditCust.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaEditCust.Location = new System.Drawing.Point(195, 41);
            this.TxtNamaEditCust.Multiline = true;
            this.TxtNamaEditCust.Name = "TxtNamaEditCust";
            this.TxtNamaEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtNamaEditCust.TabIndex = 5;
            // 
            // TxtAlamatEditCust
            // 
            this.TxtAlamatEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAlamatEditCust.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlamatEditCust.Location = new System.Drawing.Point(194, 74);
            this.TxtAlamatEditCust.Multiline = true;
            this.TxtAlamatEditCust.Name = "TxtAlamatEditCust";
            this.TxtAlamatEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtAlamatEditCust.TabIndex = 6;
            // 
            // TxtEditEmailCust
            // 
            this.TxtEditEmailCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEditEmailCust.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditEmailCust.Location = new System.Drawing.Point(193, 140);
            this.TxtEditEmailCust.Multiline = true;
            this.TxtEditEmailCust.Name = "TxtEditEmailCust";
            this.TxtEditEmailCust.Size = new System.Drawing.Size(156, 23);
            this.TxtEditEmailCust.TabIndex = 7;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.Yellow;
            this.BtnSimpan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Location = new System.Drawing.Point(195, 175);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 26);
            this.BtnSimpan.TabIndex = 3;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(274, 175);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtEditHp
            // 
            this.TxtEditHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEditHp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditHp.Location = new System.Drawing.Point(194, 107);
            this.TxtEditHp.Multiline = true;
            this.TxtEditHp.Name = "TxtEditHp";
            this.TxtEditHp.Size = new System.Drawing.Size(156, 23);
            this.TxtEditHp.TabIndex = 9;
            // 
            // PnlEditCust
            // 
            this.PnlEditCust.BackColor = System.Drawing.Color.Transparent;
            this.PnlEditCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlEditCust.BackgroundImage")));
            this.PnlEditCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlEditCust.Controls.Add(this.TxtEditHp);
            this.PnlEditCust.Controls.Add(this.BtnCancel);
            this.PnlEditCust.Controls.Add(this.BtnSimpan);
            this.PnlEditCust.Controls.Add(this.TxtEditEmailCust);
            this.PnlEditCust.Controls.Add(this.TxtAlamatEditCust);
            this.PnlEditCust.Controls.Add(this.TxtNamaEditCust);
            this.PnlEditCust.Controls.Add(this.TxtKodeEditCust);
            this.PnlEditCust.Location = new System.Drawing.Point(1, 174);
            this.PnlEditCust.Name = "PnlEditCust";
            this.PnlEditCust.Size = new System.Drawing.Size(382, 232);
            this.PnlEditCust.TabIndex = 2;
            // 
            // PicBoxClose
            // 
            this.PicBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxClose.Image")));
            this.PicBoxClose.Location = new System.Drawing.Point(358, 0);
            this.PicBoxClose.Name = "PicBoxClose";
            this.PicBoxClose.Size = new System.Drawing.Size(27, 30);
            this.PicBoxClose.TabIndex = 13;
            this.PicBoxClose.TabStop = false;
            this.PicBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            this.PicBoxClose.MouseLeave += new System.EventHandler(this.PicBoxClose_MouseLeave);
            this.PicBoxClose.MouseHover += new System.EventHandler(this.PicBoxClose_MouseHover);
            // 
            // PnlEditBarang
            // 
            this.PnlEditBarang.BackColor = System.Drawing.Color.Transparent;
            this.PnlEditBarang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlEditBarang.BackgroundImage")));
            this.PnlEditBarang.Controls.Add(this.PnlEditSuppl);
            this.PnlEditBarang.Controls.Add(this.BtnCancelEdit);
            this.PnlEditBarang.Controls.Add(this.BtnSimpanEditBarang);
            this.PnlEditBarang.Controls.Add(this.TxtHargaJualEdit);
            this.PnlEditBarang.Controls.Add(this.TxtHargaHppEdit);
            this.PnlEditBarang.Controls.Add(this.TxtJmlahBrgEdit);
            this.PnlEditBarang.Controls.Add(this.TxtNamaEditBrg);
            this.PnlEditBarang.Controls.Add(this.TxtKodeBrgEdit);
            this.PnlEditBarang.Controls.Add(this.TxtEditBarangId);
            this.PnlEditBarang.Location = new System.Drawing.Point(1, 174);
            this.PnlEditBarang.Name = "PnlEditBarang";
            this.PnlEditBarang.Size = new System.Drawing.Size(382, 232);
            this.PnlEditBarang.TabIndex = 14;
            // 
            // TxtEditBarangId
            // 
            this.TxtEditBarangId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEditBarangId.Enabled = false;
            this.TxtEditBarangId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditBarangId.Location = new System.Drawing.Point(194, 4);
            this.TxtEditBarangId.Multiline = true;
            this.TxtEditBarangId.Name = "TxtEditBarangId";
            this.TxtEditBarangId.Size = new System.Drawing.Size(153, 23);
            this.TxtEditBarangId.TabIndex = 0;
            // 
            // TxtKodeBrgEdit
            // 
            this.TxtKodeBrgEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKodeBrgEdit.Enabled = false;
            this.TxtKodeBrgEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKodeBrgEdit.Location = new System.Drawing.Point(194, 38);
            this.TxtKodeBrgEdit.Multiline = true;
            this.TxtKodeBrgEdit.Name = "TxtKodeBrgEdit";
            this.TxtKodeBrgEdit.Size = new System.Drawing.Size(153, 23);
            this.TxtKodeBrgEdit.TabIndex = 1;
            this.TxtKodeBrgEdit.Text = "Kode Tidak Dapat diEdit";
            // 
            // TxtNamaEditBrg
            // 
            this.TxtNamaEditBrg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaEditBrg.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaEditBrg.Location = new System.Drawing.Point(194, 71);
            this.TxtNamaEditBrg.Multiline = true;
            this.TxtNamaEditBrg.Name = "TxtNamaEditBrg";
            this.TxtNamaEditBrg.Size = new System.Drawing.Size(153, 23);
            this.TxtNamaEditBrg.TabIndex = 2;
            // 
            // TxtJmlahBrgEdit
            // 
            this.TxtJmlahBrgEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtJmlahBrgEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtJmlahBrgEdit.Location = new System.Drawing.Point(194, 103);
            this.TxtJmlahBrgEdit.Multiline = true;
            this.TxtJmlahBrgEdit.Name = "TxtJmlahBrgEdit";
            this.TxtJmlahBrgEdit.Size = new System.Drawing.Size(153, 23);
            this.TxtJmlahBrgEdit.TabIndex = 3;
            // 
            // TxtHargaHppEdit
            // 
            this.TxtHargaHppEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHargaHppEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHargaHppEdit.Location = new System.Drawing.Point(194, 136);
            this.TxtHargaHppEdit.Multiline = true;
            this.TxtHargaHppEdit.Name = "TxtHargaHppEdit";
            this.TxtHargaHppEdit.Size = new System.Drawing.Size(153, 23);
            this.TxtHargaHppEdit.TabIndex = 4;
            // 
            // TxtHargaJualEdit
            // 
            this.TxtHargaJualEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHargaJualEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHargaJualEdit.Location = new System.Drawing.Point(193, 169);
            this.TxtHargaJualEdit.Multiline = true;
            this.TxtHargaJualEdit.Name = "TxtHargaJualEdit";
            this.TxtHargaJualEdit.Size = new System.Drawing.Size(153, 23);
            this.TxtHargaJualEdit.TabIndex = 5;
            // 
            // BtnSimpanEditBarang
            // 
            this.BtnSimpanEditBarang.BackColor = System.Drawing.Color.Yellow;
            this.BtnSimpanEditBarang.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpanEditBarang.Location = new System.Drawing.Point(195, 203);
            this.BtnSimpanEditBarang.Name = "BtnSimpanEditBarang";
            this.BtnSimpanEditBarang.Size = new System.Drawing.Size(75, 26);
            this.BtnSimpanEditBarang.TabIndex = 15;
            this.BtnSimpanEditBarang.Text = "Simpan";
            this.BtnSimpanEditBarang.UseVisualStyleBackColor = false;
            this.BtnSimpanEditBarang.Click += new System.EventHandler(this.BtnSimpanEditBarang_Click);
            // 
            // BtnCancelEdit
            // 
            this.BtnCancelEdit.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancelEdit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelEdit.Location = new System.Drawing.Point(276, 203);
            this.BtnCancelEdit.Name = "BtnCancelEdit";
            this.BtnCancelEdit.Size = new System.Drawing.Size(75, 26);
            this.BtnCancelEdit.TabIndex = 16;
            this.BtnCancelEdit.Text = "Cancel";
            this.BtnCancelEdit.UseVisualStyleBackColor = false;
            this.BtnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // PnlEditSuppl
            // 
            this.PnlEditSuppl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlEditSuppl.BackgroundImage")));
            this.PnlEditSuppl.Controls.Add(this.BtnCancelSupp);
            this.PnlEditSuppl.Controls.Add(this.BtnSmpanEditSupp);
            this.PnlEditSuppl.Controls.Add(this.TxtEmailSupp);
            this.PnlEditSuppl.Controls.Add(this.TxtNoHpSupp);
            this.PnlEditSuppl.Controls.Add(this.TxtAlamatSupp);
            this.PnlEditSuppl.Controls.Add(this.TxtNamaSupp);
            this.PnlEditSuppl.Controls.Add(this.TxtKodeSupp);
            this.PnlEditSuppl.Location = new System.Drawing.Point(1, -219);
            this.PnlEditSuppl.Name = "PnlEditSuppl";
            this.PnlEditSuppl.Size = new System.Drawing.Size(382, 232);
            this.PnlEditSuppl.TabIndex = 17;
            // 
            // TxtKodeSupp
            // 
            this.TxtKodeSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKodeSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKodeSupp.Location = new System.Drawing.Point(193, 39);
            this.TxtKodeSupp.Multiline = true;
            this.TxtKodeSupp.Name = "TxtKodeSupp";
            this.TxtKodeSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtKodeSupp.TabIndex = 0;
            // 
            // TxtNamaSupp
            // 
            this.TxtNamaSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNamaSupp.Location = new System.Drawing.Point(193, 72);
            this.TxtNamaSupp.Multiline = true;
            this.TxtNamaSupp.Name = "TxtNamaSupp";
            this.TxtNamaSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtNamaSupp.TabIndex = 1;
            // 
            // TxtAlamatSupp
            // 
            this.TxtAlamatSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAlamatSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlamatSupp.Location = new System.Drawing.Point(193, 104);
            this.TxtAlamatSupp.Multiline = true;
            this.TxtAlamatSupp.Name = "TxtAlamatSupp";
            this.TxtAlamatSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtAlamatSupp.TabIndex = 2;
            // 
            // TxtNoHpSupp
            // 
            this.TxtNoHpSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNoHpSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoHpSupp.Location = new System.Drawing.Point(193, 136);
            this.TxtNoHpSupp.Multiline = true;
            this.TxtNoHpSupp.Name = "TxtNoHpSupp";
            this.TxtNoHpSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtNoHpSupp.TabIndex = 3;
            // 
            // TxtEmailSupp
            // 
            this.TxtEmailSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmailSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailSupp.Location = new System.Drawing.Point(193, 167);
            this.TxtEmailSupp.Multiline = true;
            this.TxtEmailSupp.Name = "TxtEmailSupp";
            this.TxtEmailSupp.Size = new System.Drawing.Size(156, 23);
            this.TxtEmailSupp.TabIndex = 4;
            // 
            // BtnSmpanEditSupp
            // 
            this.BtnSmpanEditSupp.BackColor = System.Drawing.Color.Yellow;
            this.BtnSmpanEditSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSmpanEditSupp.Location = new System.Drawing.Point(193, 202);
            this.BtnSmpanEditSupp.Name = "BtnSmpanEditSupp";
            this.BtnSmpanEditSupp.Size = new System.Drawing.Size(75, 26);
            this.BtnSmpanEditSupp.TabIndex = 15;
            this.BtnSmpanEditSupp.Text = "Simpan";
            this.BtnSmpanEditSupp.UseVisualStyleBackColor = false;
            this.BtnSmpanEditSupp.Click += new System.EventHandler(this.BtnSmpanEditSupp_Click);
            // 
            // BtnCancelSupp
            // 
            this.BtnCancelSupp.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancelSupp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelSupp.Location = new System.Drawing.Point(276, 202);
            this.BtnCancelSupp.Name = "BtnCancelSupp";
            this.BtnCancelSupp.Size = new System.Drawing.Size(75, 26);
            this.BtnCancelSupp.TabIndex = 16;
            this.BtnCancelSupp.Text = "Cancel";
            this.BtnCancelSupp.UseVisualStyleBackColor = false;
            this.BtnCancelSupp.Click += new System.EventHandler(this.BtnCancelSupp_Click);
            // 
            // FormEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 495);
            this.Controls.Add(this.PnlEditBarang);
            this.Controls.Add(this.PicBoxClose);
            this.Controls.Add(this.CmboBoxItem);
            this.Controls.Add(this.PnlEditCust);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.TxtIdBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditAll";
            this.Load += new System.EventHandler(this.FormEditCustomer_Load);
            this.PnlEditCust.ResumeLayout(false);
            this.PnlEditCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).EndInit();
            this.PnlEditBarang.ResumeLayout(false);
            this.PnlEditBarang.PerformLayout();
            this.PnlEditSuppl.ResumeLayout(false);
            this.PnlEditSuppl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdBarang;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.ComboBox CmboBoxItem;
        private System.Windows.Forms.TextBox TxtKodeEditCust;
        private System.Windows.Forms.TextBox TxtNamaEditCust;
        private System.Windows.Forms.TextBox TxtAlamatEditCust;
        private System.Windows.Forms.TextBox TxtEditEmailCust;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtEditHp;
        private System.Windows.Forms.Panel PnlEditCust;
        private System.Windows.Forms.PictureBox PicBoxClose;
        private System.Windows.Forms.Panel PnlEditBarang;
        private System.Windows.Forms.TextBox TxtHargaJualEdit;
        private System.Windows.Forms.TextBox TxtHargaHppEdit;
        private System.Windows.Forms.TextBox TxtJmlahBrgEdit;
        private System.Windows.Forms.TextBox TxtNamaEditBrg;
        private System.Windows.Forms.TextBox TxtKodeBrgEdit;
        private System.Windows.Forms.TextBox TxtEditBarangId;
        private System.Windows.Forms.Button BtnCancelEdit;
        private System.Windows.Forms.Button BtnSimpanEditBarang;
        private System.Windows.Forms.Panel PnlEditSuppl;
        private System.Windows.Forms.Button BtnSmpanEditSupp;
        private System.Windows.Forms.TextBox TxtEmailSupp;
        private System.Windows.Forms.TextBox TxtNoHpSupp;
        private System.Windows.Forms.TextBox TxtAlamatSupp;
        private System.Windows.Forms.TextBox TxtNamaSupp;
        private System.Windows.Forms.TextBox TxtKodeSupp;
        private System.Windows.Forms.Button BtnCancelSupp;
    }
}