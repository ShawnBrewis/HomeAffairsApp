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
    public partial class RegisterForm : Form
    {
        private string gender;

        public RegisterForm()
        {
            InitializeComponent();          
        }

        //Getters
        public string getFirstName()
        {
            return txtBxFirstName.Text;
        }

        public string getLastName()
        {
            return txtBxLastName.Text;
        }

        public string getAddress()
        {
            return txtBxAddress.Text;
        }

        public string getProvince()
        {
            if (cmBxProvince.SelectedItem == null)
            {
                cmBxProvince.SelectedIndex = 0;
            }
            return cmBxProvince.SelectedItem.ToString();
        }

        public string getCity()
        {
            if (cmBxCity.SelectedItem == null)
            {

                cmBxCity.SelectedIndex = 0;
            }
            
              return cmBxCity.SelectedItem.ToString();
            
        }

        public string getBirthDate()
        {
            if (cmBxYear.SelectedItem == null || cmBxMonth.SelectedItem == null || cmBxDay.SelectedItem == null)
            {
                cmBxYear.SelectedIndex = 0;
                cmBxMonth.SelectedIndex = 0;
                cmBxDay.SelectedIndex = 0;
            }
            return cmBxYear.SelectedItem.ToString() + "" + cmBxMonth.SelectedItem.ToString() + "" + cmBxDay.SelectedItem.ToString();
        }

        public string getRadioBtnGender()
        {
            if (rbFemale.Checked == true)
            {
                gender = "Female";
                return gender;
            }
            else
            {
                gender = "Male";
                return gender;
            }
        }

        public string getEmail()
        {
            return txtBxEmail.Text.ToString();
        }

        public string getPassword()
        {
            return txtBxPassword.Text.ToString();
        }

        public string getTelHome()
        {
            return txtBxTelHome.Text.ToString();
        }

        public string getTelWrk()
        {
            return txtBxTelWrk.Text.ToString();
        }

        public string getTelHomeCode()
        {
            return txtBxTelCodeHome.Text.ToString();
        }

        public string getTelWrkCode()
        {
            return txtBxTelCodeWrk.Text.ToString();
        }

        public void showForm()
        {
            this.ShowDialog();
        }
        
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ResetMyDate();
        }

        private void cmBxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable to store the month (+1 because the index starts at zero
            //and I need it to start at 1)
            int month = cmBxMonth.SelectedIndex + 1;

            int days = 0;

            if (cmBxYear.Text.ToString() != "")
            {
                //Variable for the days based on the year and month selected
                days = System.DateTime.DaysInMonth(int.Parse(cmBxYear.Text.ToString()), month);

            }
            else
            {
                MessageBox.Show("Please select a year first");
                ResetMyDate();
            }
            
            //First clear the items in the combo box
            cmBxDay.Items.Clear();

            //then loop to add the days
            for (int i = 1; i <= days; i++)
            {
                cmBxDay.Items.Add(i);
            }
        }

        //Setters
        public void setName(string aName)
        {
            txtBxFirstName.Text = aName;
        }

        public void setLastname(string aLastName)
        {
            txtBxLastName.Text = aLastName;
        }

        public void setAddress(string aAddress)
        {
            txtBxAddress.Text = aAddress;
        }

        public void setCity(string aCity)
        {
            cmBxCity.SelectedIndex = int.Parse(aCity);
        }
        public void setProvince(string aPrivince)
        {
            cmBxProvince.SelectedIndex = int.Parse(aPrivince);
        }

        public void setDay(string aDay)
        {
            cmBxDay.SelectedItem = aDay;
        }

        public void setMonth(string aMonth)
        {
            cmBxMonth.SelectedItem = aMonth;
        }

        public void setYear(string aYear)
        {
            cmBxYear.SelectedItem = aYear;
        }

        public void setRadioMale(bool aMale)
        {
            rbMale.Checked = aMale;
        }

        public void setRadioFemale(bool aFemale)
        {
            rbFemale.Checked = aFemale;
        }

        public void setTelHome(string aTelHome)
        {
            txtBxTelHome.Text = aTelHome;
        }

        public void setTelWork(string aTelWork)
        {
            txtBxTelWrk.Text = aTelWork;
        }

        public void setTelHomeCode(string aTelHomeCode)
        {
            txtBxTelCodeHome.Text = aTelHomeCode;
        }

        public void setTelWorkCode(string aTelWrkCode)
        {
            txtBxTelCodeWrk.Text = aTelWrkCode;
        }

        public void setEmail(string aEmail)
        {
            txtBxEmail.Text = aEmail;
        }

        private void ResetMyDate()
        {   
            //First clear the combo box's before populating them
            cmBxMonth.Items.Clear();
            cmBxYear.Items.Clear();
            cmBxDay.Items.Clear();

            //Variable to hold the current year
            string year = DateTime.Now.Year.ToString();

            //Convert the string into an int and store it in the variable
            int thisYear = int.Parse(year);

            //Loop from 1900 to the current year
            for (int i = 1900; i <= thisYear; i++)
            {
                //Add the items to the combo box
                cmBxYear.Items.Add(i);
            }

            //Add the 12 months of the year
            for (int i = 1; i <= 12; i++)
            {
                cmBxMonth.Items.Add(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm userLogin = new LoginForm();
            //userLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBxFirstName.Text == "" || txtBxLastName.Text == "" || txtBxAddress.Text == "" ||
                txtBxEmail.Text == "" || cmBxDay.Items.ToString() == "" || cmBxMonth.Items.ToString() == "" ||
                cmBxYear.Items.ToString() == "" || cmBxCity.SelectedItem == null || rbMale.Enabled == false || rbFemale.Enabled == false)
            {
                MessageBox.Show("Error: Please fill all the fields before clicking on 'Register'");
            }
            else
            {
                //Create a new file and write values from the form
                try
                {
                    StreamWriter loginCreate = new StreamWriter("Login.txt");
                    loginCreate.WriteLine(txtBxFirstName.Text + "%" + txtBxLastName.Text + "%" + txtBxAddress.Text + "%" +
                        cmBxCity.SelectedIndex.ToString() + "%" + cmBxProvince.SelectedIndex.ToString() + "%" +
                        cmBxYear.SelectedIndex.ToString() + "%" + cmBxMonth.SelectedIndex.ToString() + "%" + cmBxDay.SelectedIndex.ToString() +
                        "%" + rbMale.Checked + "%" + rbFemale.Checked + "%" + txtBxTelHome.Text + "%" + txtBxTelCodeHome.Text + "%" + txtBxTelWrk.Text +
                        "%" + txtBxTelCodeWrk.Text + "%" + txtBxPassword.Text);
                    loginCreate.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        private void txtBxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmBxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmBxDay.Text = "";
            cmBxMonth.Text = "";
        }

        private void txtBxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxTelHome_TextChanged(object sender, EventArgs e)
        {
            if (txtBxTelHome.Text == null)
            {
                txtBxTelHome.Text = "";
            }
            else
            {
                try
                {
                    int.Parse(txtBxTelHome.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric value");
                    txtBxTelHome.ClearUndo();
                }
            }
        }

        private void txtBxTelWrk_TextChanged(object sender, EventArgs e)
        {
            if (txtBxTelWrk.Text == "")
            {
                txtBxTelWrk.Text = "";
            }
            else
            {
                try
                {
                    int.Parse(txtBxTelWrk.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric value");
                    txtBxTelWrk.ClearUndo();
                }
            }
        }

        private void txtBxTelCodeHome_TextChanged(object sender, EventArgs e)
        {
            if (txtBxTelCodeHome.Text == "")
            {
                txtBxTelCodeHome.Text = "";
            }
            else
            {
                try
                {
                    int.Parse(txtBxTelCodeHome.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric value");
                    txtBxTelCodeHome.ClearUndo();
                }
            }
        }

        private void txtBxTelCodeWrk_TextChanged(object sender, EventArgs e)
        {
            if (txtBxTelCodeWrk.Text == "")
            {
                txtBxTelCodeWrk.Text = "";
            }
            else
            {
                try
                {
                    int.Parse(txtBxTelCodeWrk.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric value");
                    txtBxTelCodeWrk.ClearUndo();
                }
            }
        }
    }
}
