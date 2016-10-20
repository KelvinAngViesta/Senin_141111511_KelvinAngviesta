namespace TugasCSharpLanjutanLatihan4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LblFileName = new System.Windows.Forms.Label();
            this.BtnSaveEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFileToolStripMenuItem.Image")));
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileToolStripMenuItem.Image")));
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 421);
            this.richTextBox1.TabIndex = 3;
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
            this.tsbbtnBold.Click += new System.EventHandler(this.tsbbtnBold_Click);
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
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(26, 22);
            this.toolStripLabel2.Text = "Size";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "TstBtnBackColor";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(12, 484);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(54, 13);
            this.LblFileName.TabIndex = 4;
            this.LblFileName.Text = "File Name";
            // 
            // BtnSaveEdit
            // 
            this.BtnSaveEdit.Location = new System.Drawing.Point(321, 479);
            this.BtnSaveEdit.Name = "BtnSaveEdit";
            this.BtnSaveEdit.Size = new System.Drawing.Size(117, 23);
            this.BtnSaveEdit.TabIndex = 5;
            this.BtnSaveEdit.Text = "Save Pada Saat Edit";
            this.BtnSaveEdit.UseVisualStyleBackColor = true;
            this.BtnSaveEdit.Click += new System.EventHandler(this.BtnSaveEdit_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 503);
            this.Controls.Add(this.BtnSaveEdit);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Note Pad ++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox CmbboxSize;
        private System.Windows.Forms.ToolStripButton tsbbtnBold;
        private System.Windows.Forms.ToolStripButton tsbbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbbtnUnderline;
        private System.Windows.Forms.ToolStripComboBox CmbboxFont;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.Button BtnSaveEdit;
    }
}

