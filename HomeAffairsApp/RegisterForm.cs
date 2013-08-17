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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

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
            return cmBxProvince.SelectedItem.ToString();
        }

        public string getCity()
        {
            return cmBxCity.SelectedItem.ToString();
        }

        public string getBirthDate()
        {
            return cmBxYear.SelectedItem.ToString() + "" + cmBxMonth.SelectedItem.ToString() + "" + cmBxDay.SelectedItem.ToString();
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
            this.Hide(); 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtBxFirstName.Text == "" || txtBxLastName.Text == "" || txtBxAddress.Text == "" ||
                txtBxEmail.Text == "" || cmBxDay.Items.ToString() == "" || cmBxMonth.Items.ToString() == "" ||
                cmBxYear.Items.ToString() == "" || cmBxCity.Items.ToString() == "" || rbMale.Enabled == false || rbFemale.Enabled == false)
            {
                MessageBox.Show("Error: Please fill all the fields before clicking on 'Register'");
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
    }
}
