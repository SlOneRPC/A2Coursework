using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2CourseWork.Objects;
using System.Data.SqlClient;
namespace A2CourseWork.Classes
{
    class BookingDB
    {
        Database db;
        public BookingDB(Database db)
        {
            this.db = db;

        }

        public Booking getalldates(string childname)
        {
            int id = getBookingID(childname);
            Booking bookings = new Booking();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT Monday FROM Dates WHERE BookingId={id}";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                string date = db.Rdr.GetString(0);
                bookings.Mondays.Add(Convert.ToDateTime(date));
            }
            db.Rdr.Close();
            return bookings;
        }

        public List<custBooking> getallbookingsforkid(string childname)
        {
            int id = getchildID(childname);
            List<custBooking> bookings = new List<custBooking>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT * FROM Booking WHERE ChildId = {id}";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                bookings.Add(getbookingfromreader(db.Rdr));
            }
            return bookings;
        }

        private custBooking getbookingfromreader(SqlDataReader reader)
        {
            custBooking booking = new custBooking();
            booking.Id = reader.GetInt32(0);
            booking.ChildId = reader.GetInt32(1);
            booking.GroupId = reader.GetInt32(2);
            booking.Monday = reader.GetInt32(3);
            booking.Tuesday = reader.GetInt32(4);
            booking.Wednesday = reader.GetInt32(5);
            booking.Thursday = reader.GetInt32(6);
            booking.Friday = reader.GetInt32(7);
            return booking;
        }

        public void Addcustomer(string ForeName,string Surname, string TeleNo, string postcode,string address)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Customer(Forename,Surname,TeleNo,Postcode,Address) VALUES( '" + ForeName + "','" + Surname + "','" + TeleNo + "','" + postcode + "','" + address + "')";
            doquery();
        }

        public void Addkid(string Forename,string Surname,string DOB,string parentName)
        {
            int id = getcutID(parentName);
            if(id == -1)
            {
                MessageBox.Show("Error - Could not get CustID");
            }
            else
            {
                db.Cmd = db.Conn.CreateCommand();
                db.Cmd.CommandText = "INSERT INTO kids(ForeName,Surname,DOB,ParentId) VALUES( '" + Forename + "','" + Surname + "','" + DOB + "','" + id + "')";
                doquery();
            }
        }

        public void AddBooking(string childname,string groupname,int Mon,int Tues,int Wed,int Thur,int Friday)
        {
            int childId = getchildID(childname);
            int groupId = getgroupID(groupname);
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Booking(ChildId,GroupId,Monday,Tuesday,Wednesday,Thursday,Friday) VALUES( '" + childId + "','" + groupId + "','" + Mon + "','" + Tues + "','" + Wed + "','" + Thur + "','" + Friday + "')";
            doquery();
        }

        public void AddDate(List<DateTime> mondays,string childForename)
        {
            int bookingid = getBookingID(childForename);
            foreach(DateTime monday in mondays)
            {
                db.Cmd = db.Conn.CreateCommand();
                string shortmonday = monday.ToShortDateString();
                db.Cmd.CommandText = $"INSERT INTO Dates(BookingId,Monday) VALUES({bookingid},'{shortmonday}')";
                doquery();
            }
        }

        public void removeDate(List<DateTime> mondays, string childForename)
        {
            int bookingid = getBookingID(childForename);
            foreach (DateTime monday in mondays)
            {
                db.Cmd = db.Conn.CreateCommand();
                string shortmonday = monday.ToShortDateString();
                db.Cmd.CommandText = $"DELETE FROM Dates WHERE BookingId = {bookingid} AND Monday = '{shortmonday}'";
                doquery();
            }
        }

        public int GetBookingSlot(DateTime searchdate, int groupid)
        {
            int counter = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT COUNT(*) FROM Booking INNER JOIN Dates ON Booking.BookingID = Dates.BookingId WHERE Dates.Monday = '{searchdate.ToShortDateString()}' AND Booking.GroupId = {groupid}";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                counter = db.Rdr.GetInt32(0);
            }
            db.Rdr.Close();
            return counter;
        }


        private int getchildID(string childname)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Kids WHERE ForeName = '" + childname + "'";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                db.Rdr.Close();
                return id;
            }
            db.Rdr.Close();
            return -1;
        }

        public int getgroupID(string groupname)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Groups WHERE GroupName = '" + groupname + "'";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                db.Rdr.Close();
                return id;
            }
            db.Rdr.Close();
            return -1;
        }

        private int getcutID(string parentName)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customer WHERE ForeName = '" + parentName +"'";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                db.Rdr.Close();
                return id;
            }
            db.Rdr.Close();
            return -1;
        }

        private int getBookingID(string childname)
        {
            int childid = getchildID(childname);
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Booking WHERE ChildId = " + childid + "";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                db.Rdr.Close();
                return id;
            }
            db.Rdr.Close();
            return -1;
        }

        private void doquery()
        {
            try
            {
                db.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - Could not execute query");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
