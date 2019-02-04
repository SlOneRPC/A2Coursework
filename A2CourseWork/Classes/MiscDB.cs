using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Classes
{
    class MiscDB
    {
        Database db;
        public MiscDB(Database db)
        {
            this.db = db;
        }

        public List<List<string>> BookingDetails(DateTime date)
        {
            List<List<string>> details = new List<List<string>>();
            List<string> current = new List<string>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT Customer.ForeName,Customer.Surname, Kids.ForeName,Kids.Surname ,Kids.DOB FROM Kids RIGHT JOIN Customer ON Kids.ParentId = Customer.CustId RIGHT JOIN Booking ON Kids.ChildId = Booking.ChildId RIGHT JOIN Dates ON Booking.BookingID = Dates.BookingId WHERE Dates.Monday =  '{date.ToShortDateString()}'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                current = new List<string>();
                current.Add(db.Rdr.GetString(0));
                current.Add(db.Rdr.GetString(1));
                current.Add(db.Rdr.GetString(2));
                current.Add(db.Rdr.GetString(3));
                current.Add(db.Rdr.GetString(4));
                details.Add(current);
            }
            db.Rdr.Close();
            return details;
        }

        public List<List<string>> BookingDays(DateTime date)
        {
            List<List<string>> details = new List<List<string>>();
            List<string> current = new List<string>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT Kids.ForeName, Kids.Surname, Booking.Monday, Booking.Tuesday, Booking.Wednesday, Booking.Thursday, Booking.Friday FROM Kids INNER JOIN Booking ON Kids.ChildId = Booking.ChildId INNER JOIN Dates ON Booking.BookingID = Dates.BookingId WHERE Dates.Monday = '{date.ToShortDateString()}'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                current = new List<string>();
                current.Add(db.Rdr.GetString(0));
                current.Add(db.Rdr.GetString(1).ToString());
                current.Add(db.Rdr.GetInt32(2).ToString());
                current.Add(db.Rdr.GetInt32(3).ToString());
                current.Add(db.Rdr.GetInt32(4).ToString());
                current.Add(db.Rdr.GetInt32(5).ToString());
                current.Add(db.Rdr.GetInt32(6).ToString());
                details.Add(current);
            }
            db.Rdr.Close();
            return details;
        }

        public List<DateTime> BookingWeeksFromKid(string kidForename)
        {
            List<DateTime> details = new List<DateTime>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT Dates.Monday From Dates INNER JOIN Booking ON Dates.BookingId = Booking.BookingID INNER JOIN Kids ON Booking.ChildId = Kids.ChildId WHERE Kids.ForeName = '{kidForename}'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                details.Add(Convert.ToDateTime(db.Rdr.GetString(0)));
            }
            db.Rdr.Close();
            return details;
        }
    }
}
