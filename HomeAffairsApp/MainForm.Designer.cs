﻿namespace HomeAffairsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birthCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marriageCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deathCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBirth = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMarriage = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.picBxRightHand = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightHand)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
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
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnBirth
            // 
            this.btnBirth.Location = new System.Drawing.Point(51, 31);
            this.btnBirth.Name = "btnBirth";
            this.btnBirth.Size = new System.Drawing.Size(141, 82);
            this.btnBirth.TabIndex = 1;
            this.btnBirth.Text = "Birth Certificate";
            this.btnBirth.UseVisualStyleBackColor = true;
            this.btnBirth.Click += new System.EventHandler(this.btnBirth_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnMarriage);
            this.groupBox1.Controls.Add(this.btnID);
            this.groupBox1.Controls.Add(this.btnBirth);
            this.groupBox1.Location = new System.Drawing.Point(416, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Official Documents";
            // 
            // btnMarriage
            // 
            this.btnMarriage.Location = new System.Drawing.Point(51, 207);
            this.btnMarriage.Name = "btnMarriage";
            this.btnMarriage.Size = new System.Drawing.Size(141, 82);
            this.btnMarriage.TabIndex = 3;
            this.btnMarriage.Text = "Marriage Certificate";
            this.btnMarriage.UseVisualStyleBackColor = true;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(51, 119);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(141, 82);
            this.btnID.TabIndex = 2;
            this.btnID.Text = "ID Book";
            this.btnID.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(23, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Welcome";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(270, 258);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome To The South African Department of Home Affairs.\r\n\r\nPlease choose from on" +
    "e of the options on the right to register for a Birth Certificate, ID book or Ma" +
    "rriage Certificate.";
            // 
            // picBxRightHand
            // 
            this.picBxRightHand.Image = ((System.Drawing.Image)(resources.GetObject("picBxRightHand.Image")));
            this.picBxRightHand.Location = new System.Drawing.Point(311, 138);
            this.picBxRightHand.Name = "picBxRightHand";
            this.picBxRightHand.Size = new System.Drawing.Size(100, 47);
            this.picBxRightHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxRightHand.TabIndex = 4;
            this.picBxRightHand.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(671, 451);
            this.Controls.Add(this.picBxRightHand);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dept. Home Affairs";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRightHand)).EndInit();
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
        private System.Windows.Forms.Button btnBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMarriage;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox picBxRightHand;
        private System.Windows.Forms.Label lblName;
    }
}

