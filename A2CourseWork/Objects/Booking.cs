using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Objects
{
    class Booking
    {
        public Booking() { }

        private List<DateTime> mondays = new List<DateTime>();
        private List<int> days = new List<int>();

        public Booking(List<DateTime> mondays,List<int> days)
        {
            this.mondays = mondays;
            this.days = days;
        }

        public List<DateTime> Mondays
        {
            get { return mondays; }
            set { mondays = value; }
        }

        public List<int> Days
        {
            get { return days; }
            set { days = value; }
        }
    }
}
