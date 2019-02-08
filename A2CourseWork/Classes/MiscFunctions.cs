using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A2CourseWork.Classes
{
    class MiscFunctions
    {
        public static void buttonhover(Form form)
        {
            foreach (Button b in form.Controls.OfType<Button>())
            {
                b.MouseEnter += (s, g) => b.Cursor = Cursors.Hand;
                b.MouseLeave += (s, g) => b.Cursor = Cursors.Arrow;
            }
        }

        public static void exit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void nextform(Form newform)
        {
            
        }

        private static int calculateAge(string DOB)
        {
            int months = DateTime.Now.Month - Convert.ToDateTime(DOB).Month;
            int years = DateTime.Now.Year - Convert.ToDateTime(DOB).Year;
            if (months < 0)
            {
                years--;
                months += 12;
            }
            if (years > 0)
            {
                months += (years * 12);
            }
            return months;
        }

        public static string getgroupfromage(string DOB)
        {
            int months = calculateAge(DOB);
            string groupName = "";
            //calculate group
            Database db = new Database();
            db.connect();
            GroupDB gdb = new GroupDB(db);
            List<string> names = gdb.getgroupnames();

            if (months < 19)
            {
                groupName = names[0];
            }
            else if (months >= 18 && months <= 30)
            {
                groupName = names[1];
            }
            else if (months >= 30 && months <= 48)
            {
                groupName = names[2];
            }
            else
            {
                MessageBox.Show("Error - Invalid group name");
                return "";
            }
            return groupName;
        }

        public static bool CheckAvalability(DateTime currentDate,Database db,string DOB)
        {
            string group = getgroupfromage(DOB);
            BookingDB bookDB = new BookingDB(db);
            int groupID = bookDB.getgroupID(group);
            int bookingscount = bookDB.GetBookingSlot(currentDate, groupID);
            bool overbooked = false;
            GroupDB gdb = new GroupDB(db);
            if(groupID == 1)
            {
                if (bookingscount > gdb.getANum())
                {
                    overbooked = true;
                }
            }
            else if(groupID == 2)
            {
                if(bookingscount > gdb.getBNum())
                {
                    overbooked = true;
                }
            }
            else if(groupID == 3)
            {
                if(bookingscount > gdb.getCNum())
                {
                    overbooked = true;
                }
            }
            return overbooked;
        }

        public static bool checkStaffAvaliability(Database db, string DOB)
        {
            string group = getgroupfromage(DOB);
            BookingDB bookDB = new BookingDB(db);
            int groupID = bookDB.getgroupID(group);
            StaffDB staffdb = new StaffDB(db);
            int staffNum = staffdb.countStaffbyid(groupID);
            if(staffNum < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string AddOrdinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }

        }

    }
}
