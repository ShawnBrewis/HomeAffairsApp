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
    public partial class BirthForm : Form
    {
        public BirthForm()
        {
            InitializeComponent();
        }

        public void setApplicantSurname(string aSurname)
        {
            txtBxApplicantSurname.Text = aSurname;
        }

        public void setApplicantForename(string aForename)
        {
            txtBxApplicantForename.Text = aForename;
        }

        public void setApplicantAddress(string aAddress)
        {
            txtBxApplicantPostal.Text = aAddress;
        }

        public void setApplicantTelWrk(int aTelWrk)
        {
            txtBxApplicantTelWrk.Text = aTelWrk.ToString();
        }

        public void setApplicantTelWrkCode(int aTelWrkCode)
        {
            txtBxApplicantWrkCode.Text = aTelWrkCode.ToString();
        }

        public void setApplicantTelHome(int aTelHome)
        {
            txtBxApplicantTelHome.Text = aTelHome.ToString();
        }

        public void setApplicantTelHomeCode(int aTelHomeCode)
        {
            txtBxApplicantHomeCode.Text = aTelHomeCode.ToString();
        }

        public string getPersonID()
        {
           return txtBxPersonID.Text;
        }

        public string getPersonSurname()
        {
            return txtPersonSurname.Text;
        }

        public string getPersonForename()
        {
            return txtBxPersonForename.Text;
        }

        public string getPersonMaiden()
        {
            return txtBxPersonMaiden.Text;
        }

        public string getPersonDOB()
        {
            return txtBxPersonDOB.Text;
        }

        public string getPersonTown()
        {
            return txtBxPersonTown.Text;
        }

        public string getFatherSurname()
        {
            return txtBxFatherSurname.Text;
        }

        public string getFatherForename()
        {
            return txtBxFatherForename.Text;
        }

        public string getMotherSurname()
        {
            return txtBxMotherMaiden.Text;
        }

        public string getMotherForename()
        {
            return txtBxMotherForename.Text;
        }

        private void BirthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
