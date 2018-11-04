using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Objects
{
    class StaffMember
    {
        

        private int staffid;
        private string forename;
        private string surname;
        private string teleNo;
        private string address;
        private string postcode;

        //default constructor
        public StaffMember()
        {
            staffid = 0;
            forename = "";
            surname = "";
            teleNo = "";
            address = "";
            postcode = "";
        }
        //custom constructor
        public StaffMember(int StaffId,string Forename,string Surname,string TeleNo,string Address,string Postcode)
        {
            this.staffid = StaffId;
            this.forename = Forename;
            this.surname = Surname;
            this.teleNo = TeleNo;
            this.address = Address;
            this.postcode = Postcode;
        }

        // Get / Setters
        public int StaffId
        {
            get { return staffid; }
            set { staffid = value; }
        }

        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string TeleNo
        {
            get { return teleNo; }
            set { teleNo = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

    }
}
