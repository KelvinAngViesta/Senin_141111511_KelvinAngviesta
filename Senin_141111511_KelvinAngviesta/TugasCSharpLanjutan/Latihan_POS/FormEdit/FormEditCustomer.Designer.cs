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
            this.PnlEditCust = new System.Windows.Forms.Panel();
            this.TxtIdEditCust = new System.Windows.Forms.TextBox();
            this.TxtKodeEditCust = new System.Windows.Forms.TextBox();
            this.TxtAlamatEditCust = new System.Windows.Forms.TextBox();
            this.TxtNamaEditCust = new System.Windows.Forms.TextBox();
            this.TxtEditEmailCust = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtEditHp = new System.Windows.Forms.TextBox();
            this.PnlEditCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIdBarang
            // 
            this.TxtIdBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdBarang.Location = new System.Drawing.Point(192, 136);
            this.TxtIdBarang.Multiline = true;
            this.TxtIdBarang.Name = "TxtIdBarang";
            this.TxtIdBarang.Size = new System.Drawing.Size(156, 23);
            this.TxtIdBarang.TabIndex = 0;
            // 
            // BtnCari
            // 
            this.BtnCari.BackColor = System.Drawing.Color.Yellow;
            this.BtnCari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCari.Location = new System.Drawing.Point(274, 165);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 26);
            this.BtnCari.TabIndex = 1;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = false;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
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
            this.PnlEditCust.Controls.Add(this.TxtIdEditCust);
            this.PnlEditCust.Location = new System.Drawing.Point(1, 191);
            this.PnlEditCust.Name = "PnlEditCust";
            this.PnlEditCust.Size = new System.Drawing.Size(382, 232);
            this.PnlEditCust.TabIndex = 2;
            // 
            // TxtIdEditCust
            // 
            this.TxtIdEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIdEditCust.Enabled = false;
            this.TxtIdEditCust.Location = new System.Drawing.Point(191, 9);
            this.TxtIdEditCust.Multiline = true;
            this.TxtIdEditCust.Name = "TxtIdEditCust";
            this.TxtIdEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtIdEditCust.TabIndex = 3;
            // 
            // TxtKodeEditCust
            // 
            this.TxtKodeEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKodeEditCust.Location = new System.Drawing.Point(191, 40);
            this.TxtKodeEditCust.Multiline = true;
            this.TxtKodeEditCust.Name = "TxtKodeEditCust";
            this.TxtKodeEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtKodeEditCust.TabIndex = 4;
            // 
            // TxtAlamatEditCust
            // 
            this.TxtAlamatEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAlamatEditCust.Location = new System.Drawing.Point(191, 104);
            this.TxtAlamatEditCust.Multiline = true;
            this.TxtAlamatEditCust.Name = "TxtAlamatEditCust";
            this.TxtAlamatEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtAlamatEditCust.TabIndex = 6;
            // 
            // TxtNamaEditCust
            // 
            this.TxtNamaEditCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNamaEditCust.Location = new System.Drawing.Point(192, 71);
            this.TxtNamaEditCust.Multiline = true;
            this.TxtNamaEditCust.Name = "TxtNamaEditCust";
            this.TxtNamaEditCust.Size = new System.Drawing.Size(156, 23);
            this.TxtNamaEditCust.TabIndex = 5;
            // 
            // TxtEditEmailCust
            // 
            this.TxtEditEmailCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEditEmailCust.Location = new System.Drawing.Point(191, 172);
            this.TxtEditEmailCust.Multiline = true;
            this.TxtEditEmailCust.Name = "TxtEditEmailCust";
            this.TxtEditEmailCust.Size = new System.Drawing.Size(156, 23);
            this.TxtEditEmailCust.TabIndex = 7;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.Yellow;
            this.BtnSimpan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Location = new System.Drawing.Point(198, 201);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 26);
            this.BtnSimpan.TabIndex = 3;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(273, 201);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TxtEditHp
            // 
            this.TxtEditHp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEditHp.Location = new System.Drawing.Point(191, 138);
            this.TxtEditHp.Multiline = true;
            this.TxtEditHp.Name = "TxtEditHp";
            this.TxtEditHp.Size = new System.Drawing.Size(156, 23);
            this.TxtEditHp.TabIndex = 9;
            // 
            // FormEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 495);
            this.Controls.Add(this.PnlEditCust);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.TxtIdBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditCustomer";
            this.PnlEditCust.ResumeLayout(false);
            this.PnlEditCust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdBarang;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Panel PnlEditCust;
        private System.Windows.Forms.TextBox TxtEditEmailCust;
        private System.Windows.Forms.TextBox TxtAlamatEditCust;
        private System.Windows.Forms.TextBox TxtNamaEditCust;
        private System.Windows.Forms.TextBox TxtKodeEditCust;
        private System.Windows.Forms.TextBox TxtIdEditCust;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.TextBox TxtEditHp;
    }
}