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

        public User()
        {
        }

        public User(string aBirthdate, string aFirstName, string aLastName, string aAddress, string aProvince, string aCity)
        {
            birthDate = aBirthdate;
            firstName = aFirstName;
            aLastName = lastName;
            aAddress = address;
            province = aProvince;
            city = aCity;
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

        private int generateIDNumber()
        {
            int idNumber = 0;
            return idNumber;
        }
    }
}
