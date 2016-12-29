namespace Latihan_POS.FormLihatAll
{
    partial class FormViewDataBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewDataBarang));
            this.PicBoxCust = new System.Windows.Forms.PictureBox();
            this.PicBoxCost = new System.Windows.Forms.PictureBox();
            this.PicBoxSupp = new System.Windows.Forms.PictureBox();
            this.PicBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxCust
            // 
            this.PicBoxCust.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCust.Image")));
            this.PicBoxCust.Location = new System.Drawing.Point(24, 38);
            this.PicBoxCust.Name = "PicBoxCust";
            this.PicBoxCust.Size = new System.Drawing.Size(91, 28);
            this.PicBoxCust.TabIndex = 0;
            this.PicBoxCust.TabStop = false;
            this.PicBoxCust.Click += new System.EventHandler(this.PicBoxCust_Click);
            // 
            // PicBoxCost
            // 
            this.PicBoxCost.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCost.Image")));
            this.PicBoxCost.Location = new System.Drawing.Point(121, 38);
            this.PicBoxCost.Name = "PicBoxCost";
            this.PicBoxCost.Size = new System.Drawing.Size(113, 28);
            this.PicBoxCost.TabIndex = 1;
            this.PicBoxCost.TabStop = false;
            this.PicBoxCost.Click += new System.EventHandler(this.PicBoxCost_Click);
            // 
            // PicBoxSupp
            // 
            this.PicBoxSupp.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxSupp.Image")));
            this.PicBoxSupp.Location = new System.Drawing.Point(240, 38);
            this.PicBoxSupp.Name = "PicBoxSupp";
            this.PicBoxSupp.Size = new System.Drawing.Size(108, 28);
            this.PicBoxSupp.TabIndex = 2;
            this.PicBoxSupp.TabStop = false;
            this.PicBoxSupp.Click += new System.EventHandler(this.PicBoxSupp_Click);
            // 
            // PicBoxClose
            // 
            this.PicBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxClose.Image")));
            this.PicBoxClose.Location = new System.Drawing.Point(704, 4);
            this.PicBoxClose.Name = "PicBoxClose";
            this.PicBoxClose.Size = new System.Drawing.Size(27, 30);
            this.PicBoxClose.TabIndex = 14;
            this.PicBoxClose.TabStop = false;
            this.PicBoxClose.Click += new System.EventHandler(this.PicBoxClose_Click);
            this.PicBoxClose.MouseLeave += new System.EventHandler(this.PicBoxClose_MouseLeave);
            this.PicBoxClose.MouseHover += new System.EventHandler(this.PicBoxClose_MouseHover);
            // 
            // FormViewDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 499);
            this.Controls.Add(this.PicBoxClose);
            this.Controls.Add(this.PicBoxSupp);
            this.Controls.Add(this.PicBoxCost);
            this.Controls.Add(this.PicBoxCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewDataBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormViewDataBarang";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxCust;
        private System.Windows.Forms.PictureBox PicBoxCost;
        private System.Windows.Forms.PictureBox PicBoxSupp;
        private System.Windows.Forms.PictureBox PicBoxClose;
    }
}