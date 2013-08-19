using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAffairsApp
{
    class DeathCertificate : User
    {
        private string deceasedID;
        private string deceasedSurname;
        private string deceasedMaiden;
        private string deceasedForename;
        private string deceasedDOB;
        private string deceasedPlaceOfBirth;
        private string deceasedDateOfDeath;
        private string deceasedTownOfDeath;

        public string DeceasedID
        {
            get { return deceasedID; }
            set { deceasedID = value; }
        }

        public string DeceasedSurname
        {
            get { return deceasedSurname; }
            set { deceasedSurname = value; }
        }

        public string DeceasedMaiden
        {
            get { return deceasedMaiden; }
            set { deceasedMaiden = value; }
        }

        public string DeceasedForename
        {
            get { return deceasedForename; }
            set { deceasedForename = value; }
        }

        public string DeceasedDOB
        {
            get { return deceasedDOB; }
            set { deceasedDOB = value; }
        }

        public string DeceasedPlaceOfBirth
        {
            get { return deceasedPlaceOfBirth; }
            set { deceasedPlaceOfBirth = value; }
        }
        public string DeceasedDateOfDeath
        {
            get { return deceasedDateOfDeath; }
            set { deceasedDateOfDeath = value; }
        }

        public string DeceasedTownOfDeath
        {
            get { return deceasedTownOfDeath; }
            set { deceasedTownOfDeath = value; }
        }
    }
}
