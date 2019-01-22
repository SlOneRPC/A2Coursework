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
        private int mon;
        private int tues;
        private int weds;
        private int thur;
        private int friday;


        public custBooking(int id,int childid,int groupid,int monday,int tues,int weds,int thurs,int friday)
        {
            this.id = id;
            this.childid = childid;
            this.groupid = groupid;
            this.mon = monday;
            this.tues = tues;
            this.weds = weds;
            this.thur = thurs;
            this.friday = friday;
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

        public int Monday
        {
            get { return mon; }
            set { mon = value; }
        }

        public int Tuesday
        {
            get { return tues; }
            set { tues = value; }
        }

        public int Wednesday
        {
            get { return weds; }
            set { weds = value; }
        }

        public int Thursday
        {
            get { return thur; }
            set { thur = value; }
        }

        public int Friday
        {
            get { return friday; }
            set { friday = value; }
        }

    }
}
