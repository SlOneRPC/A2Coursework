using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Objects
{
    public class Customer
    {
        private int custId;
        private string forename;
        private string surname;
        private string teleNo;
        private string address;
        private string postcode;

        public Customer() { }

        public Customer(int CustId,string Forename,string Surname,string TeleNo,string Address,string Postcode)
        {
            this.custId = CustId;
            this.forename = Forename;
            this.surname = Surname;
            this.teleNo = TeleNo;
            this.address = Address;
            this.postcode = Postcode;
        }

        public int CustId
        {
            get { return custId; }
            set { custId = value; }
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
