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
    public partial class DeathForm : Form
    {
        public DeathForm()
        {
            InitializeComponent();
        }

        public void setApplicantSurname(string aSurname)
        {
            txtBxApplicantSurname.Text = aSurname;
        }

        public void setApplicantInitials(string aInitials)
        {
            txtBxApplicantInitials.Text = aInitials;
        }

        public void setApplicantIDnumber(string aID)
        {
            txtBxApplicantID.Text = aID;
        }

        public void setApplicantResidentualAddress(string aResAddress)
        {
            txtBxApplicantResAddress.Text = aResAddress;
        }

        public void setApplicantPOstalAddress(string aPostal)
        {
            txtBxApplicantPostal.Text = aPostal;
        }

        public void setApplicantPostalCode(string aPostalCode)
        {
            txtBxApplicantPostalCode.Text = aPostalCode;
        }

        public void setApplicantTelHome(int aTelHome)
        {
            txtBxApplicantTelHome.Text = aTelHome.ToString();
        }

        public void setApplicantTelWrk(int aTelWrk)
        {
            txtBxApplicantTelWrk.Text = aTelWrk.ToString();
        }

        public void setApplicantTelHomeCode(int aTelHomeCode)
        {
            txtBxApplicantHomeCode.Text = aTelHomeCode.ToString();
        }

        public void setApplicantTelWrkCode(int aTelWrkCode)
        {
            txtBxApplicantWrkCode.Text = aTelWrkCode.ToString();
        }

        public string getDeceasedID()
        {
            return txtPersonDeceasedID.Text;
        }

        public string getDeceasedSurname()
        {
            return txtPersonDeceasedSurname.Text;
        }

        public string getDeceasedMaiden()
        {
            return txtBxPersonDeceasedMaiden.Text;
        }

        public string getDeceasedForename()
        {
            return txtBxPersonDeceasedForename.Text;
        }

        public string getDeceasedPlaceOfBirth()
        {
            return txtBxPersonDeceasedPOB.Text;
        }

        public string getDeceasedDOD()
        {
            return txtBxPersonDeceasedDOD.Text;
        }

        public string getDeceasedTown()
        {
            return txtBxPersonDeceasedTown.Text;
        }


        private void DeathForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
