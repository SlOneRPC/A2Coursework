using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Objects
{
    class custBooking
    {
        public custBooking() { }

        private int id;
        private int childid;
        private int groupid;
        private string startdate;
        private string enddate;

        public custBooking(int id,int childid,int groupid,string startdate,string enddate)
        {
            this.id = id;
            this.childid = childid;
            this.groupid = groupid;
            this.startdate = startdate;
            this.enddate = enddate;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ChildId
        {
            get { return childid; }
            set { childid = value; }
        }

        public int GroupId
        {
            get { return groupid; }
            set { groupid = value; }
        }

        public string Startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }

        public string Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }
    }
}
