namespace TugasCSharpLanjutanLatihan3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CmbboxSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsbbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.CmbboxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 423);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // CmbboxSize
            // 
            this.CmbboxSize.DropDownHeight = 200;
            this.CmbboxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbboxSize.IntegralHeight = false;
            this.CmbboxSize.Name = "CmbboxSize";
            this.CmbboxSize.Size = new System.Drawing.Size(121, 25);
            this.CmbboxSize.SelectedIndexChanged += new System.EventHandler(this.CmbboxSize_SelectedIndexChanged);
            // 
            // tsbbtnBold
            // 
            this.tsbbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnBold.Image")));
            this.tsbbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnBold.Name = "tsbbtnBold";
            this.tsbbtnBold.Size = new System.Drawing.Size(23, 22);
            this.tsbbtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // tsbbtnItalic
            // 
            this.tsbbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnItalic.Image")));
            this.tsbbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnItalic.Name = "tsbbtnItalic";
            this.tsbbtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbbtnItalic.Text = "toolStripButton1";
            this.tsbbtnItalic.Click += new System.EventHandler(this.tsbbtnItalic_Click);
            // 
            // tsbbtnUnderline
            // 
            this.tsbbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbbtnUnderline.Image")));
            this.tsbbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnUnderline.Name = "tsbbtnUnderline";
            this.tsbbtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbbtnUnderline.Text = "toolStripButton1";
            this.tsbbtnUnderline.Click += new System.EventHandler(this.tsbbtnUnderline_Click);
            // 
            // CmbboxFont
            // 
            this.CmbboxFont.DropDownHeight = 200;
            this.CmbboxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbboxFont.IntegralHeight = false;
            this.CmbboxFont.Name = "CmbboxFont";
            this.CmbboxFont.Size = new System.Drawing.Size(121, 25);
            this.CmbboxFont.SelectedIndexChanged += new System.EventHandler(this.CmbboxFont_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.CmbboxSize,
            this.tsbbtnBold,
            this.tsbbtnItalic,
            this.tsbbtnUnderline,
            this.toolStripLabel1,
            this.CmbboxFont,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel2.Text = "Size";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "Font";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 449);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Note Pad ++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox CmbboxSize;
        private System.Windows.Forms.ToolStripButton tsbbtnBold;
        private System.Windows.Forms.ToolStripButton tsbbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbbtnUnderline;
        private System.Windows.Forms.ToolStripComboBox CmbboxFont;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

