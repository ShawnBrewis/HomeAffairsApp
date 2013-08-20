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
    public partial class MarriageForm : Form
    {
        public MarriageForm()
        {
            InitializeComponent();
        }

        public void setApplicantName(string aName)
        {
            txtBxApplicantName.Text = aName;
        }

        public void setApplicantAddress(string aAddress)
        {
            txtBxApplicantAddress.Text = aAddress;
        }

        public void setApplicantPostalCode(int aPostalCode)
        {
            txtBxApplicantPostalCode.Text = aPostalCode.ToString();
        }

        public void setApplicantTelHome(int aTelHome)
        {
            txtBxApplicantTelHome.Text = aTelHome.ToString();
        }

        public void setApplicantTelWrk(int aTelWrk)
        {
            txtBxApplicantTelWrk.Text = aTelWrk.ToString();
        }

        public string getHusbandName()
        {
            return txtBxHusbandName.Text;
        }

        public string getHusbandIDnum()
        {
            return txtBxHusbandID.Text;
        }

        public string getHusbandDOB()
        {
            return txtBxHusbandDOB.Text;
        }

        public string getWifeName()
        {
            return txtBxWifeName.Text;
        }

        public string getWifeID()
        {
            return txtBxWifeID.Text;
        }

        public string getWifeDOB()
        {
            return txtBxWifeDOB.Text;
        }

        public string getMarriageDate()
        {
            return txtBxMarriageDate.Text;
        }

        public string getMarriagePlace()
        {
            return txtBxMarriagePlace.Text;
        }

        public string getMarriageChurch()
        {
            return txtBxMarriageChurch.Text;
        }

        public string getMarriageOfficer()
        {
            return txtBxMarriageOfficer.Text;
        }

        private void MarriageForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
