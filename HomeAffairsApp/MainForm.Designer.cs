namespace HomeAffairsApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marriageCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deathCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birthCertificateToolStripMenuItem,
            this.marriageCertificateToolStripMenuItem,
            this.deathCertificateToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formsToolStripMenuItem.Text = "Forms";
            this.formsToolStripMenuItem.Click += new System.EventHandler(this.formsToolStripMenuItem_Click);
            // 
            // birthCertificateToolStripMenuItem
            // 
            this.birthCertificateToolStripMenuItem.Name = "birthCertificateToolStripMenuItem";
            this.birthCertificateToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.birthCertificateToolStripMenuItem.Text = "Birth Certificate";
            // 
            // marriageCertificateToolStripMenuItem
            // 
            this.marriageCertificateToolStripMenuItem.Name = "marriageCertificateToolStripMenuItem";
            this.marriageCertificateToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.marriageCertificateToolStripMenuItem.Text = "Marriage Certificate";
            // 
            // deathCertificateToolStripMenuItem
            // 
            this.deathCertificateToolStripMenuItem.Name = "deathCertificateToolStripMenuItem";
            this.deathCertificateToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deathCertificateToolStripMenuItem.Text = "Death Certificate";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dept. Home Affairs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birthCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marriageCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deathCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

