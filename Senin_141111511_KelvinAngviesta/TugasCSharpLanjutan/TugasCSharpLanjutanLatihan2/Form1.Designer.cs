namespace TugasCSharpLanjutanLatihan2
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LblTanggal = new System.Windows.Forms.Label();
            this.LblBulan = new System.Windows.Forms.Label();
            this.NuPTanggal = new System.Windows.Forms.NumericUpDown();
            this.NuPBulan = new System.Windows.Forms.NumericUpDown();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NuPTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuPBulan)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(10, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 4;
            // 
            // LblTanggal
            // 
            this.LblTanggal.AutoSize = true;
            this.LblTanggal.Location = new System.Drawing.Point(36, 16);
            this.LblTanggal.Name = "LblTanggal";
            this.LblTanggal.Size = new System.Drawing.Size(52, 13);
            this.LblTanggal.TabIndex = 5;
            this.LblTanggal.Text = "Tanggal :";
            // 
            // LblBulan
            // 
            this.LblBulan.AutoSize = true;
            this.LblBulan.Location = new System.Drawing.Point(43, 52);
            this.LblBulan.Name = "LblBulan";
            this.LblBulan.Size = new System.Drawing.Size(43, 13);
            this.LblBulan.TabIndex = 6;
            this.LblBulan.Text = "Bulan  :";
            
            // 
            // NuPTanggal
            // 
            this.NuPTanggal.Location = new System.Drawing.Point(109, 14);
            this.NuPTanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NuPTanggal.Name = "NuPTanggal";
            this.NuPTanggal.Size = new System.Drawing.Size(39, 20);
            this.NuPTanggal.TabIndex = 7;
            // 
            // NuPBulan
            // 
            this.NuPBulan.Location = new System.Drawing.Point(109, 50);
            this.NuPBulan.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NuPBulan.Name = "NuPBulan";
            this.NuPBulan.Size = new System.Drawing.Size(39, 20);
            this.NuPBulan.TabIndex = 8;
            this.NuPBulan.ValueChanged += new System.EventHandler(this.NuPBulan_ValueChanged);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(196, 11);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(96, 23);
            this.BtnTambah.TabIndex = 9;
            this.BtnTambah.Text = "Tambah Libur";
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(196, 47);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(96, 23);
            this.BtnHapus.TabIndex = 10;
            this.BtnHapus.Text = "Hapus Libur";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 400);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.NuPBulan);
            this.Controls.Add(this.NuPTanggal);
            this.Controls.Add(this.LblBulan);
            this.Controls.Add(this.LblTanggal);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NuPTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuPBulan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LblTanggal;
        private System.Windows.Forms.Label LblBulan;
        private System.Windows.Forms.NumericUpDown NuPTanggal;
        private System.Windows.Forms.NumericUpDown NuPBulan;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnHapus;
    }
}

