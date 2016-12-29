namespace Latihan_POS.FormLihatAll
{
    partial class FormViewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewSupplier));
            this.DgViewSupp = new System.Windows.Forms.DataGridView();
            this.KodeSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlamatSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HpSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datenow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // DgViewSupp
            // 
            this.DgViewSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgViewSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeSup,
            this.NamSup,
            this.AlamatSup,
            this.HpSup,
            this.EmailSup,
            this.Datenow,
            this.DateUpdate});
            this.DgViewSupp.Location = new System.Drawing.Point(6, 5);
            this.DgViewSupp.Name = "DgViewSupp";
            this.DgViewSupp.Size = new System.Drawing.Size(696, 208);
            this.DgViewSupp.TabIndex = 2;
            // 
            // KodeSup
            // 
            this.KodeSup.HeaderText = "Kode Supplier";
            this.KodeSup.Name = "KodeSup";
            this.KodeSup.ReadOnly = true;
            // 
            // NamSup
            // 
            this.NamSup.HeaderText = "Nama Supplier";
            this.NamSup.Name = "NamSup";
            // 
            // AlamatSup
            // 
            this.AlamatSup.HeaderText = "Alamat Supplier";
            this.AlamatSup.Name = "AlamatSup";
            // 
            // HpSup
            // 
            this.HpSup.HeaderText = "HP-Supplier";
            this.HpSup.Name = "HpSup";
            // 
            // EmailSup
            // 
            this.EmailSup.HeaderText = "E-mail Supplier";
            this.EmailSup.Name = "EmailSup";
            // 
            // Datenow
            // 
            this.Datenow.HeaderText = "DateTime";
            this.Datenow.Name = "Datenow";
            // 
            // DateUpdate
            // 
            this.DateUpdate.HeaderText = "DateTime Update";
            this.DateUpdate.Name = "DateUpdate";
            // 
            // FormViewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 222);
            this.Controls.Add(this.DgViewSupp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewSupplier";
            this.Load += new System.EventHandler(this.FormViewSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewSupp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlamatSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn HpSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datenow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpdate;
    }
}