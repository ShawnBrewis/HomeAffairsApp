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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.cmBxYear = new System.Windows.Forms.ComboBox();
            this.cmBxMonth = new System.Windows.Forms.ComboBox();
            this.cmBxDay = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmBxCity = new System.Windows.Forms.ComboBox();
            this.cmBxProvince = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxRepeatPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(100, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(100, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(100, 122);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(100, 247);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(71, 13);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Date Of Birth:";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(185, 37);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(129, 20);
            this.txtBxFirstName.TabIndex = 4;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(185, 78);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(129, 20);
            this.txtBxLastName.TabIndex = 5;
            this.txtBxLastName.TextChanged += new System.EventHandler(this.txtBxLastName_TextChanged);
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(185, 119);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(129, 20);
            this.txtBxAddress.TabIndex = 6;
            // 
            // cmBxYear
            // 
            this.cmBxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxYear.FormattingEnabled = true;
            this.cmBxYear.Location = new System.Drawing.Point(185, 244);
            this.cmBxYear.Name = "cmBxYear";
            this.cmBxYear.Size = new System.Drawing.Size(51, 21);
            this.cmBxYear.TabIndex = 7;
            this.cmBxYear.SelectedIndexChanged += new System.EventHandler(this.cmBxYear_SelectedIndexChanged);
            // 
            // cmBxMonth
            // 
            this.cmBxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxMonth.FormattingEnabled = true;
            this.cmBxMonth.Location = new System.Drawing.Point(242, 244);
            this.cmBxMonth.Name = "cmBxMonth";
            this.cmBxMonth.Size = new System.Drawing.Size(42, 21);
            this.cmBxMonth.TabIndex = 8;
            this.cmBxMonth.SelectedIndexChanged += new System.EventHandler(this.cmBxMonth_SelectedIndexChanged);
            // 
            // cmBxDay
            // 
            this.cmBxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmBxDay.Location = new System.Drawing.Point(290, 244);
            this.cmBxDay.Name = "cmBxDay";
            this.cmBxDay.Size = new System.Drawing.Size(42, 21);
            this.cmBxDay.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(100, 163);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(100, 205);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(52, 13);
            this.lblProvince.TabIndex = 11;
            this.lblProvince.Text = "Province:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(155, 436);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 35);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 436);
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
            this.label7.Location = new System.Drawing.Point(338, 247);
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
            this.cmBxCity.Location = new System.Drawing.Point(185, 160);
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
            this.cmBxProvince.Location = new System.Drawing.Point(185, 202);
            this.cmBxProvince.Name = "cmBxProvince";
            this.cmBxProvince.Size = new System.Drawing.Size(129, 21);
            this.cmBxProvince.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 328);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(209, 325);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBxEmail.TabIndex = 20;
            this.txtBxEmail.TextChanged += new System.EventHandler(this.txtBxEmail_TextChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(185, 286);
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
            this.rbFemale.Location = new System.Drawing.Point(255, 285);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(100, 287);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(100, 356);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password:";
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(100, 384);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(94, 13);
            this.lblRepeatPassword.TabIndex = 25;
            this.lblRepeatPassword.Text = "Repeat Password:";
            this.lblRepeatPassword.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(209, 353);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(200, 20);
            this.txtBxPassword.TabIndex = 26;
            this.txtBxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBxRepeatPw
            // 
            this.txtBxRepeatPw.Location = new System.Drawing.Point(209, 381);
            this.txtBxRepeatPw.Name = "txtBxRepeatPw";
            this.txtBxRepeatPw.Size = new System.Drawing.Size(201, 20);
            this.txtBxRepeatPw.TabIndex = 27;
            this.txtBxRepeatPw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 509);
            this.Controls.Add(this.txtBxRepeatPw);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmBxProvince);
            this.Controls.Add(this.cmBxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmBxDay);
            this.Controls.Add(this.cmBxMonth);
            this.Controls.Add(this.cmBxYear);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.ComboBox cmBxYear;
        private System.Windows.Forms.ComboBox cmBxMonth;
        private System.Windows.Forms.ComboBox cmBxDay;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmBxCity;
        private System.Windows.Forms.ComboBox cmBxProvince;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBxEmail;
        public System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxRepeatPw;
    }
}