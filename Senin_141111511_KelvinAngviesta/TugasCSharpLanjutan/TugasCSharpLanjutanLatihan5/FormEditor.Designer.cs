namespace TugasCSharpLanjutanLatihan5
{
    partial class FormEditor
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Background Color");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tema", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.PanelWarna = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CmboxBackGround = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelWarna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelWarna
            // 
            this.PanelWarna.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelWarna.Controls.Add(this.label2);
            this.PanelWarna.Controls.Add(this.label1);
            this.PanelWarna.Controls.Add(this.pictureBox1);
            this.PanelWarna.Controls.Add(this.CmboxBackGround);
            this.PanelWarna.Controls.Add(this.button1);
            this.PanelWarna.Location = new System.Drawing.Point(128, 0);
            this.PanelWarna.Name = "PanelWarna";
            this.PanelWarna.Size = new System.Drawing.Size(249, 177);
            this.PanelWarna.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeTema";
            treeNode1.Text = "Background Color";
            treeNode2.Name = "Tema";
            treeNode2.Text = "Tema";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(131, 177);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // CmboxBackGround
            // 
            this.CmboxBackGround.FormattingEnabled = true;
            this.CmboxBackGround.Location = new System.Drawing.Point(8, 28);
            this.CmboxBackGround.Name = "CmboxBackGround";
            this.CmboxBackGround.Size = new System.Drawing.Size(121, 21);
            this.CmboxBackGround.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(174, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choice 1 Then Click Ok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Or Click Image And Choice";
            // 
            // FormEditor
            // 
            this.AccessibleName = "FormEditor";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 177);
            this.Controls.Add(this.PanelWarna);
            this.Controls.Add(this.treeView1);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.PanelWarna.ResumeLayout(false);
            this.PanelWarna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWarna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox CmboxBackGround;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}