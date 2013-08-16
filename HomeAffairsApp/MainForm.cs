using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeAffairsApp
{
    public partial class MainForm : Form
    {
        BirthForm userBirth = new BirthForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            //-- Create Form Objects --//
            RegisterForm myRegForm = new RegisterForm();
            LoginForm myLogin = new LoginForm();
            

            //--Show Forms--//
            myLogin.ShowDialog();
            myRegForm.ShowDialog();
            lblName.Text = myRegForm.txtBxFirstName.Text;
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBirth_Click(object sender, EventArgs e)
        {
            userBirth.ShowDialog();
        }
    }
}
