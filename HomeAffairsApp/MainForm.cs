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
            myBirthCert.Email = userRegForm.getEmail();
            myBirthCert.Password = userRegForm.getPassword();
            myBirthCert.FatherForename = userBirthForm.getFatherForename();
            myBirthCert.FatherSurname = userBirthForm.getFatherSurname();
            myBirthCert.MotherForename = userBirthForm.getMotherForename();
            myBirthCert.MotherMaiden = userBirthForm.getMotherSurname();
            myBirthCert.PersonIDnumber = userBirthForm.getPersonID();
            myBirthCert.PersonSurname = userBirthForm.getPersonSurname();
            myBirthCert.PersonForename = userBirthForm.getPersonForename();
            myBirthCert.PersonMaidenName = userBirthForm.getPersonMaiden();
            myBirthCert.PersonCityBirth = userBirthForm.getPersonTown();
            /////////////////////////////////////////////////////////////////////////////////////////

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
            ///////////////////////////////////////////////////////////////////////



            
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
            userBirthForm.setApplicantSurname(myBirthCert.LastName);
            userBirthForm.setApplicantForename(myBirthCert.FirstName);
            userBirthForm.setApplicantAddress(myBirthCert.Address + ", " + myBirthCert.City + ", " + myBirthCert.Province);
            userBirthForm.setApplicantTelHome(myBirthCert.TelHome);
            userBirthForm.setApplicantTelHomeCode(myBirthCert.TelHomeCode);
            userBirthForm.setApplicantTelWrk(myBirthCert.TelWork);
            userBirthForm.setApplicantTelWrkCode(myBirthCert.TelWrkCode);
            userBirthForm.ShowDialog();
        }

        private void btnMarriage_Click(object sender, EventArgs e)
        {
            userMarriage.setApplicantName(myMarriageCert.FirstName + ", " + myMarriageCert.LastName);
            userMarriage.setApplicantTelHome(myMarriageCert.TelHome);
            userMarriage.setApplicantTelWrk(myMarriageCert.TelWork);
            userMarriage.setApplicantAddress(myMarriageCert.Address + ", " + myMarriageCert.City + ", " + myMarriageCert.Province);
            userMarriage.ShowDialog();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            userDeath.ShowDialog();
        }
    }
}
