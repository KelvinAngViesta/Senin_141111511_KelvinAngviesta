namespace Latihan_POS.FormDeleteAll
{
    partial class FormDeleteAllItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteAllItem));
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.CmboBoxItem = new System.Windows.Forms.ComboBox();
            this.TxtKode = new System.Windows.Forms.TextBox();
            this.PicBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.BackColor = System.Drawing.Color.Yellow;
            this.BtnKeluar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeluar.Location = new System.Drawing.Point(276, 256);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(75, 26);
            this.BtnKeluar.TabIndex = 54;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = false;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Yellow;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(276, 224);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnCancel.TabIndex = 53;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.Yellow;
            this.BtnSimpan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Location = new System.Drawing.Point(197, 224);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 26);
            this.BtnSimpan.TabIndex = 52;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // CmboBoxItem
            // 
            this.CmboBoxItem.BackColor = System.Drawing.Color.White;
            this.CmboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBoxItem.FormattingEnabled = true;
            this.CmboBoxItem.Location = new System.Drawing.Point(194, 170);
            this.CmboBoxItem.Name = "CmboBoxItem";
            this.CmboBoxItem.Size = new System.Drawing.Size(157, 21);
            this.CmboBoxItem.TabIndex = 51;
            // 
            // TxtKode
            // 
            this.TxtKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtKode.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKode.Location = new System.Drawing.Point(195, 134);
            this.TxtKode.Multiline = true;
            this.TxtKode.Name = "TxtKode";
            this.TxtKode.Size = new System.Drawing.Size(156, 23);
            this.TxtKode.TabIndex = 50;
            // 
            // PicBoxClose
            // 
            this.PicBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxClose.Image")));
            this.PicBoxClose.Location = new System.Drawing.Point(342, 1);
            this.PicBoxClose.Name = "PicBoxClose";
            this.PicBoxClose.Size = new System.Drawing.Size(27, 30);
            this.PicBoxClose.TabIndex = 49;
            this.PicBoxClose.TabStop = false;
            this.PicBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            this.PicBoxClose.MouseLeave += new System.EventHandler(this.PicBoxClose_MouseLeave);
            this.PicBoxClose.MouseHover += new System.EventHandler(this.PicBoxClose_MouseHover);
            // 
            // FormDeleteAllItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(368, 495);
            this.Controls.Add(this.BtnKeluar);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.CmboBoxItem);
            this.Controls.Add(this.TxtKode);
            this.Controls.Add(this.PicBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeleteAllItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDeleteAllItem";
            this.Load += new System.EventHandler(this.FormDeleteAllItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.ComboBox CmboBoxItem;
        private System.Windows.Forms.TextBox TxtKode;
        private System.Windows.Forms.PictureBox PicBoxClose;
    }
}