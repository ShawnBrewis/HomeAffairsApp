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
        RegisterForm userRegForm = new RegisterForm();
        LoginForm userLogin = new LoginForm();
        BirthForm userBirthForm = new BirthForm();
        MarriageForm userMarriage = new MarriageForm();
        DeathForm userDeath = new DeathForm();

        //Create BirthCertificate object
        BirthCertificate myBirthCert = new BirthCertificate();

        //Create new marriage certificate object
        MarriageCertificate myMarriageCert = new MarriageCertificate();

        //Create new death certificate object
        DeathCertificate myDeathCert = new DeathCertificate();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //--Show Forms--//
            userLogin.ShowDialog();
            userRegForm.ShowDialog();
            lblName.Text = userRegForm.txtBxFirstName.Text;
            

            //Assign values to the BirthCertificate object
            myBirthCert.FirstName = userRegForm.getFirstName();
            myBirthCert.LastName = userRegForm.getLastName();
            myBirthCert.Address = userRegForm.getAddress();
            myBirthCert.City = userRegForm.getCity();
            myBirthCert.Province = userRegForm.getProvince();
            myBirthCert.BirthDate = userRegForm.getBirthDate();
            myBirthCert.Gender = userRegForm.getRadioBtnGender();
            try
            {
                myBirthCert.TelHome = int.Parse(userRegForm.getTelHome());
                myBirthCert.TelWork = int.Parse(userRegForm.getTelWrk());
                myBirthCert.TelHomeCode = int.Parse(userRegForm.getTelHomeCode());
                myBirthCert.TelWrkCode = int.Parse(userRegForm.getTelWrkCode());
            }
            catch (FormatException)
            {
            }
            catch (OverflowException)
            {
            }


            //Assign values to the death certificate object
            myDeathCert.FirstName = userRegForm.getFirstName();
            myDeathCert.LastName = userRegForm.getLastName();
            myDeathCert.Address = userRegForm.getAddress();
            myDeathCert.City = userRegForm.getCity();
            myDeathCert.Province = userRegForm.getProvince();
            try
            {
                myDeathCert.TelHome = int.Parse(userRegForm.getTelHome());
                myDeathCert.TelWork = int.Parse(userRegForm.getTelWrk());
                myDeathCert.TelHomeCode = int.Parse(userRegForm.getTelHomeCode());
                myDeathCert.TelWrkCode = int.Parse(userRegForm.getTelWrkCode());
            }
            catch (FormatException)
            {
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number too large");
            }

            MessageBox.Show("" + myBirthCert.generateIDNumber());

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
            //Set values to the form
            userBirthForm.setApplicantSurname(myBirthCert.LastName);
            userBirthForm.setApplicantForename(myBirthCert.FirstName);
            userBirthForm.setApplicantAddress(myBirthCert.Address + ", " + myBirthCert.City + ", " + myBirthCert.Province);
            userBirthForm.setApplicantTelHome(myBirthCert.TelHome);
            userBirthForm.setApplicantTelHomeCode(myBirthCert.TelHomeCode);
            userBirthForm.setApplicantTelWrk(myBirthCert.TelWork);
            userBirthForm.setApplicantTelWrkCode(myBirthCert.TelWrkCode);
            userBirthForm.getPersonForename().ToString();
            userBirthForm.ShowDialog();
        }

        private void btnMarriage_Click(object sender, EventArgs e)
        {
            //Assign values to the Marriage certificate object
            myMarriageCert.HusbandName = userMarriage.getHusbandName();
            myMarriageCert.HusbandIDnumber = userMarriage.getHusbandIDnum();
            myMarriageCert.HusbandDOB = userMarriage.getHusbandDOB();
            myMarriageCert.WifeName = userMarriage.getWifeName();
            myMarriageCert.WifeIDnumber = userMarriage.getWifeID();
            myMarriageCert.WifeDOB = userMarriage.getWifeDOB();
            myMarriageCert.MarriageDate = userMarriage.getMarriageDate();
            myMarriageCert.MarriageChurch = userMarriage.getMarriageChurch();
            myMarriageCert.MarriagePlace = userMarriage.getMarriagePlace();
            myMarriageCert.MarriageOfficer = userMarriage.getMarriageOfficer();

            //Get values from parent object
            myMarriageCert.FirstName = userRegForm.getFirstName();
            myMarriageCert.LastName = userRegForm.getLastName();
            myMarriageCert.Address = userRegForm.getAddress();
            myMarriageCert.City = userRegForm.getCity();
            myMarriageCert.Province = userRegForm.getProvince();
            try
            {
                myMarriageCert.TelHome = int.Parse(userRegForm.getTelHome());
                myMarriageCert.TelWork = int.Parse(userRegForm.getTelWrk());
            }
            catch (FormatException)
            {
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number too large");
            }

            ///////////////////////////////////////////////////////////////////////

            //Set values to the form
            userMarriage.setApplicantName(myMarriageCert.FirstName + ", " + myMarriageCert.LastName);
            userMarriage.setApplicantTelHome(myMarriageCert.TelHome);
            userMarriage.setApplicantTelWrk(myMarriageCert.TelWork);
            userMarriage.setApplicantAddress(myMarriageCert.Address + ", " + myMarriageCert.City + ", " + myMarriageCert.Province);
            userMarriage.ShowDialog();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            userDeath.setApplicantSurname(myDeathCert.LastName);
            userDeath.setApplicantTelHome(myDeathCert.TelHome);
            userDeath.setApplicantTelWrk(myDeathCert.TelWork);
            userDeath.setApplicantTelHomeCode(myDeathCert.TelHomeCode);
            userDeath.setApplicantTelWrkCode(myDeathCert.TelWrkCode);
            userDeath.setApplicantInitials(myDeathCert.FirstName + "" + myDeathCert.LastName);
            userDeath.setApplicantResidentualAddress(myDeathCert.Address);
            userDeath.setApplicantPOstalAddress("sames as above");
            userDeath.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

            //Assign values to the object
            myBirthCert.FatherForename = userBirthForm.getFatherForename();
            myBirthCert.FatherSurname = userBirthForm.getFatherSurname();
            myBirthCert.MotherForename = userBirthForm.getMotherForename();
            myBirthCert.MotherMaiden = userBirthForm.getMotherSurname();
            myBirthCert.PersonIDnumber = userBirthForm.getPersonID().ToString();
            myBirthCert.PersonSurname = userBirthForm.getPersonSurname().ToString();
            myBirthCert.PersonForename = userBirthForm.getPersonForename().ToString();
            myBirthCert.PersonMaidenName = userBirthForm.getPersonMaiden().ToString();
            myBirthCert.PersonCityBirth = userBirthForm.getPersonTown().ToString();
            ///////////////////////////////////////////////////////////////////////////
            MessageBox.Show(myBirthCert.ToString());

        }
    }
}
