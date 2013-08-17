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
        //-- Create Form Objects --//
        RegisterForm myRegForm = new RegisterForm();
        LoginForm myLogin = new LoginForm();
        BirthForm userBirth = new BirthForm();
        MarriageForm userMarriage = new MarriageForm();
        DeathForm userDeath = new DeathForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
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
            BirthCertificate myCert = new BirthCertificate();
            
        }

        private void btnMarriage_Click(object sender, EventArgs e)
        {
            userMarriage.ShowDialog();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            userDeath.ShowDialog();
        }
    }
}
