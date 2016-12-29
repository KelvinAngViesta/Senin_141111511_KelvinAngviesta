namespace Latihan_POS.FormLihatAll
{
    partial class FormViewCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewCust));
            this.DgViewCust = new System.Windows.Forms.DataGridView();
            this.KodeCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlamatCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HpCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datenow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCust)).BeginInit();
            this.SuspendLayout();
            // 
            // DgViewCust
            // 
            this.DgViewCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeCust,
            this.NamaCust,
            this.AlamatCust,
            this.HpCust,
            this.EmailCust,
            this.Datenow,
            this.DateUpdate});
            this.DgViewCust.Location = new System.Drawing.Point(5, 7);
            this.DgViewCust.Name = "DgViewCust";
            this.DgViewCust.Size = new System.Drawing.Size(704, 208);
            this.DgViewCust.TabIndex = 1;
            // 
            // KodeCust
            // 
            this.KodeCust.HeaderText = "Kode Customer";
            this.KodeCust.Name = "KodeCust";
            this.KodeCust.ReadOnly = true;
            // 
            // NamaCust
            // 
            this.NamaCust.HeaderText = "Nama Customer";
            this.NamaCust.Name = "NamaCust";
            // 
            // AlamatCust
            // 
            this.AlamatCust.HeaderText = "Alamat Customer";
            this.AlamatCust.Name = "AlamatCust";
            // 
            // HpCust
            // 
            this.HpCust.HeaderText = "HP-Customer";
            this.HpCust.Name = "HpCust";
            // 
            // EmailCust
            // 
            this.EmailCust.HeaderText = "E-mail Customer";
            this.EmailCust.Name = "EmailCust";
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
            // FormViewCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 222);
            this.Controls.Add(this.DgViewCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewCust";
            this.Load += new System.EventHandler(this.FormViewCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlamatCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn HpCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datenow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpdate;
    }
}