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

        public Booking getalldates()
        {
            Booking bookings = new Booking();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT * FROM Dates";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                bookings.Mondays.Add(Convert.ToDateTime(db.Rdr.GetString(1)));
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
            booking.Monday = reader.GetByte(3);
            booking.Tuesday = reader.GetByte(4);
            booking.Wednesday = reader.GetByte(5);
            booking.Thursday = reader.GetByte(6);
            booking.Friday = reader.GetByte(7);
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
                db.Cmd.CommandText = $"INSERT INTO Dates(BookingId,Monday) VALUES({bookingid},{monday.ToShortDateString()})";
                doquery();
            }
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

        private int getgroupID(string groupname)
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
            catch (Exception)
            {
                MessageBox.Show("Error - Could not execute query");
            }
        }
    }
}
