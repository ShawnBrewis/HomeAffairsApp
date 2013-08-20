using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HomeAffairsApp
{
    public partial class LoginForm : Form
    {
        public int successfulLogin = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void getLoginConfirmation()
        {
            int login =  successfulLogin;
        }

        public void loginFormShow()
        {
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string details;
            //string[] userValues = new string[100];
            try
            {
                StreamReader userDetails = new StreamReader("Login.txt");
                details = userDetails.ReadLine();
                userDetails.Close();
                string[] userValues = details.Split('%');

                if (txtUserName.Text != userValues[0] || txtBxPassword.Text != userValues[14])
                {
                    MessageBox.Show("Incorrect User name and Password");
                }
                else
                {
                    successfulLogin = 1;
                    this.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File does not exsist");
            }

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void showForm()
        {
           this.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
