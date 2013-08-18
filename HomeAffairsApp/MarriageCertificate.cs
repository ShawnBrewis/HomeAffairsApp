using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAffairsApp
{
    class MarriageCertificate : User
    {
        private string husbandName;
        private string husbandIDnumber;
        private string husbandDOB;
        private string wifeName;
        private string wifeIDnumber;
        private string wifeDOB;
        private string marriageDate;
        private string marriageChurch;
        private string marriagePlace;
        private string marriageOfficer;

        public MarriageCertificate()
        {
        }

        public string HusbandName
        {
            get { return husbandName; }
            set { husbandName = value; }
        }

        public string HusbandIDnumber
        {
            get { return husbandIDnumber; }
            set { husbandIDnumber = value; }
        }

        public string HusbandDOB
        {
            get { return husbandDOB; }
            set { husbandDOB = value; }
        }

        public string WifeName
        {
            get { return wifeName; }
            set { wifeName = value; }
        }

        public string WifeIDnumber
        {
            get { return wifeIDnumber; }
            set { wifeIDnumber = value; }
        }

        public string WifeDOB
        {
            get { return wifeDOB; }
            set { wifeDOB = value; }
        }

        public string MarriageDate
        {
            get { return marriageDate; }
            set { marriageDate = value; }
        }

        public string MarriageChurch
        {
            get { return marriageChurch; }
            set { marriageChurch = value; }
        }

        public string MarriagePlace
        {
            get { return marriagePlace; }
            set { marriagePlace = value; }
        }

        public string MarriageOfficer
        {
            get { return marriageOfficer; }
            set { marriageOfficer = value; }
        }
    }
}
