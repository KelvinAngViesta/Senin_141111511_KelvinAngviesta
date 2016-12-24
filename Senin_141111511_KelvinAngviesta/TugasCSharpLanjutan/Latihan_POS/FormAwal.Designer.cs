namespace Latihan_POS
{
    partial class FormAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAwal));
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.custToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // custToolStripMenuItem
            // 
            this.custToolStripMenuItem.Name = "custToolStripMenuItem";
            this.custToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.custToolStripMenuItem.Text = "Customer";
            // 
            // PicBox2
            // 
            this.PicBox2.Image = ((System.Drawing.Image)(resources.GetObject("PicBox2.Image")));
            this.PicBox2.Location = new System.Drawing.Point(448, 122);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(129, 130);
            this.PicBox2.TabIndex = 10;
            this.PicBox2.TabStop = false;
            this.PicBox2.MouseLeave += new System.EventHandler(this.PicBox2_MouseLeave);
            this.PicBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // PicBox
            // 
            this.PicBox.Image = ((System.Drawing.Image)(resources.GetObject("PicBox.Image")));
            this.PicBox.Location = new System.Drawing.Point(298, 122);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(129, 130);
            this.PicBox.TabIndex = 9;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            this.PicBox.MouseLeave += new System.EventHandler(this.PicBox_MouseLeave);
            this.PicBox.MouseHover += new System.EventHandler(this.PicBox_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 55);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PicBox1
            // 
            this.PicBox1.Image = ((System.Drawing.Image)(resources.GetObject("PicBox1.Image")));
            this.PicBox1.Location = new System.Drawing.Point(150, 122);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(129, 130);
            this.PicBox1.TabIndex = 4;
            this.PicBox1.TabStop = false;
            this.PicBox1.Click += new System.EventHandler(this.PicBox1_Click);
            this.PicBox1.MouseLeave += new System.EventHandler(this.PicBox1_MouseLeave);
            this.PicBox1.MouseHover += new System.EventHandler(this.PicBox1_MouseHover);
            // 
            // FormAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 499);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAwal";
            this.Load += new System.EventHandler(this.FormAwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custToolStripMenuItem;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.PictureBox PicBox2;
    }
}

