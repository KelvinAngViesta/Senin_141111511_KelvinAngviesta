namespace ProblemVolleyBall
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(120, 35);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(110, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(120, 61);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(110, 20);
            this.Txt2.TabIndex = 1;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(72, 9);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(96, 13);
            this.Lbl1.TabIndex = 2;
            this.Lbl1.Text = "Volley Ball Problem";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(12, 38);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(81, 13);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Score Team A :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score Team B :";
            // 
            // TxtHasil
            // 
            this.TxtHasil.Location = new System.Drawing.Point(120, 142);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.ReadOnly = true;
            this.TxtHasil.Size = new System.Drawing.Size(110, 20);
            this.TxtHasil.TabIndex = 5;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(12, 145);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(104, 13);
            this.Lbl3.TabIndex = 6;
            this.Lbl3.Text = "Hasil Kemungkinan :";
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(120, 101);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(110, 23);
            this.BtnHitung.TabIndex = 7;
            this.BtnHitung.Text = "Hasil";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 183);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "VolleyBall_Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Button BtnHitung;
    }
}

