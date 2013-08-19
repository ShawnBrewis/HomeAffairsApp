namespace HomeAffairsApp
{
    partial class ReportForm
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
            this.grpBxOutput = new System.Windows.Forms.GroupBox();
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.grpBxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxOutput
            // 
            this.grpBxOutput.Controls.Add(this.txtBxOutput);
            this.grpBxOutput.Location = new System.Drawing.Point(71, 31);
            this.grpBxOutput.Name = "grpBxOutput";
            this.grpBxOutput.Size = new System.Drawing.Size(467, 408);
            this.grpBxOutput.TabIndex = 0;
            this.grpBxOutput.TabStop = false;
            this.grpBxOutput.Text = "Output";
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(12, 17);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.Size = new System.Drawing.Size(443, 375);
            this.txtBxOutput.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 467);
            this.Controls.Add(this.grpBxOutput);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.grpBxOutput.ResumeLayout(false);
            this.grpBxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOutput;
        public System.Windows.Forms.TextBox txtBxOutput;
    }
}