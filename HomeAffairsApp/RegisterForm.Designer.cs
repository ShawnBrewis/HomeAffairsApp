namespace HomeAffairsApp
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.cmBxYear = new System.Windows.Forms.ComboBox();
            this.cmBxMonth = new System.Windows.Forms.ComboBox();
            this.cmBxDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmBxCity = new System.Windows.Forms.ComboBox();
            this.cmBxProvince = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth:";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(147, 37);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtBxFirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(147, 78);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(129, 20);
            this.txtBxLastName.TabIndex = 5;
            this.txtBxLastName.TextChanged += new System.EventHandler(this.txtBxLastName_TextChanged);
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(147, 119);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(129, 20);
            this.txtBxAddress.TabIndex = 6;
            // 
            // cmBxYear
            // 
            this.cmBxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxYear.FormattingEnabled = true;
            this.cmBxYear.Location = new System.Drawing.Point(147, 244);
            this.cmBxYear.Name = "cmBxYear";
            this.cmBxYear.Size = new System.Drawing.Size(51, 21);
            this.cmBxYear.TabIndex = 7;
            this.cmBxYear.SelectedIndexChanged += new System.EventHandler(this.cmBxYear_SelectedIndexChanged);
            // 
            // cmBxMonth
            // 
            this.cmBxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxMonth.FormattingEnabled = true;
            this.cmBxMonth.Location = new System.Drawing.Point(204, 244);
            this.cmBxMonth.Name = "cmBxMonth";
            this.cmBxMonth.Size = new System.Drawing.Size(42, 21);
            this.cmBxMonth.TabIndex = 8;
            this.cmBxMonth.SelectedIndexChanged += new System.EventHandler(this.cmBxMonth_SelectedIndexChanged);
            // 
            // cmBxDay
            // 
            this.cmBxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmBxDay.Location = new System.Drawing.Point(252, 244);
            this.cmBxDay.Name = "cmBxDay";
            this.cmBxDay.Size = new System.Drawing.Size(42, 21);
            this.cmBxDay.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Province:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(147, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 35);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(252, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "(yyyy/mm/dd)";
            // 
            // cmBxCity
            // 
            this.cmBxCity.FormattingEnabled = true;
            this.cmBxCity.Items.AddRange(new object[] {
            "Cape Town",
            "Durban",
            "Johannesburg",
            "Pretoria",
            "Soweto",
            "Port Elizabeth",
            "Pietermaritzburg",
            "Benoni",
            "Vereeniging",
            "Bloemfontein",
            "Newcastle",
            "East London",
            "Welkom",
            "Botshabelo",
            "Kimberley",
            "Witbank",
            "Carltonville",
            "Klerksdorp",
            "Rustenburg",
            "Potchefstroom",
            "Nelspruit",
            "George",
            "King Williams Town",
            "Nigel",
            "Pietersburg"});
            this.cmBxCity.Location = new System.Drawing.Point(147, 160);
            this.cmBxCity.Name = "cmBxCity";
            this.cmBxCity.Size = new System.Drawing.Size(129, 21);
            this.cmBxCity.TabIndex = 17;
            // 
            // cmBxProvince
            // 
            this.cmBxProvince.FormattingEnabled = true;
            this.cmBxProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape "});
            this.cmBxProvince.Location = new System.Drawing.Point(147, 202);
            this.cmBxProvince.Name = "cmBxProvince";
            this.cmBxProvince.Size = new System.Drawing.Size(129, 21);
            this.cmBxProvince.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email Address:";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(147, 324);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBxEmail.TabIndex = 20;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(147, 286);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 21;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(217, 285);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Gender:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 443);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmBxProvince);
            this.Controls.Add(this.cmBxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmBxDay);
            this.Controls.Add(this.cmBxMonth);
            this.Controls.Add(this.cmBxYear);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.ComboBox cmBxYear;
        private System.Windows.Forms.ComboBox cmBxMonth;
        private System.Windows.Forms.ComboBox cmBxDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmBxCity;
        private System.Windows.Forms.ComboBox cmBxProvince;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxEmail;
        public System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label9;
    }
}