using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAffairsApp
{
    class BirthCertificate : User
    {
        //Variables for the Person (baby) concerned
        private string personIDnumber;
        private string personSurname;
        private string personMaidenName;
        private string personForename;
        private string personDOB;
        private string personCityBirth;
        private string fatherSurname;
        private string fatherForename;
        private string motherMaiden;
        private string motherForename;

        public BirthCertificate()
        {

        }

        public BirthCertificate(string aPerID, string aPerSur, string aPerMaid, string aPerFore, string aPerDOB, string aPerCity,
            string aFatherFore, string aFatherSur, string aMotherMaid, string aMotherFore)
        {
            personIDnumber = aPerID;
            personSurname = aPerSur;
            personMaidenName = aPerMaid;
            personForename = aPerFore;
            personDOB = aPerDOB;
            fatherSurname = aFatherSur;
            fatherForename = aFatherFore;
            motherMaiden = aMotherMaid;
            motherForename = aMotherFore;
        }


        public string PersonIDnumber
        {
            get { return personIDnumber; }
            set { personIDnumber = value; }
        }

        public string PersonSurname
        {
            get { return personSurname; }
            set { personSurname = value; }
        }

        public string PersonMaidenName
        {
            get { return personMaidenName; }
            set { personMaidenName = value; }
        }

        public string PersonForename
        {
            get { return personForename; }
            set { personForename = value; }
        }

        public string PersonDOB
        {
            get { return personDOB; }
            set { personDOB = value; }
        }

        public string PersonCityBirth
        {
            get { return personCityBirth; }
            set { personCityBirth = value; }
        }

        public string FatherSurname
        {
            get { return fatherSurname; }
            set { fatherSurname = value; }
        }

        public string FatherForename
        {
            get { return fatherForename; }
            set { fatherForename = value; }
        }

        public string MotherMaiden
        {
            get { return motherMaiden; }
            set { motherMaiden = value; }
        }

        public string MotherForename
        {
            get { return motherForename; }
            set { motherForename = value; }
        }

        public override string ToString()
        {
           return base.ToString() + "\n---------------- Form Details ---------------- " + "\nBaby ID number: " + personIDnumber + "\nBaby Surname: " + personSurname +
                "\nBaby maiden name (if a married woman): " + personMaidenName + "\nBaby date of birth:" + personDOB +
                "\nBaby birth place: " + personCityBirth + "\nFather Surname: " + fatherSurname + "\nFather first name: " + fatherForename +
                "\nMother maiden: " + motherMaiden + "\nMother forename: " + motherForename;
        }
    }
}
