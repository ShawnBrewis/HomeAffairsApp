using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAffairsApp
{
    class User
    {
        private string birthDate;
        private string firstName;
        private string lastName;
        private string address;
        private string province;
        private string city;
        private string gender;
        private int telHome;
        private int telWork;
        private int telHomeCode;
        private int telWrkCode;        
        private string email;
        private string password;

        public User()
        {
        }

        public User(string aBirthdate, string aFirstName, string aLastName, string aAddress, string aProvince, string aCity, string aGender, 
            int aTelHome, int aTelWrk, int aTelHomeCode, int aTelWrkCode, string aEmail, string aPassword)
        {
            birthDate = aBirthdate;
            firstName = aFirstName;
            aLastName = lastName;
            aAddress = address;
            province = aProvince;
            city = aCity;
            aGender = gender;
            aEmail = email;
            aPassword = password;
            aTelHome = telHome;
            aTelWrk = telWork;
            aTelHomeCode = telHomeCode;
            aTelWrkCode = telWrkCode;
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
       
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int TelHome
        {
            get { return telHome; }
            set { telHome = value; }
        }

        public int TelWork
        {
            get { return telWork; }
            set { telWork = value; }
        }

        public int TelHomeCode
        {
            get { return telHomeCode; }
            set { telHomeCode = value; }
        }

        public int TelWrkCode
        {
            get { return telWrkCode; }
            set { telWrkCode = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int generateIDNumber()
        {
            int idNumber = 0;
            return idNumber;
        }
    }
}
