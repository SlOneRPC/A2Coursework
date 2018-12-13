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

        private List<int> mondays = new List<int>();
        private List<string> days = new List<string>();

        public Booking(List<int> mondays,List<string> days)
        {
            this.mondays = mondays;
            this.days = days;
        }

        public List<int> Mondays
        {
            get { return mondays; }
            set { mondays = value; }
        }

        public List<string> Days
        {
            get { return days; }
            set { days = value; }
        }
    }
}
