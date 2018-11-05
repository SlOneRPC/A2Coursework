using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Objects
{
    class Kid
    {
        public Kid() { }
        private int kidid;
        private int parentID;
        private string forename;
        private string surname;
        private string dob;

        public Kid(int Kidid,int ParentID,string Forename,string Surname,string DOB)
        {
            kidid = Kidid;
            parentID = ParentID;
            forename = Forename;
            surname = Surname;
        }

        public int Kidid
        {
            get { return kidid; }
            set { kidid = value; }
        }

        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
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

        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}
