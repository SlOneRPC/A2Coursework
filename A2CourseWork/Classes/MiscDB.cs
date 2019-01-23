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
            db.Cmd.CommandText = $"SELECT Customer.ForeName, Kids.ForeName,Kids.DOB FROM Kids RIGHT JOIN Customer ON Kids.ParentId = Customer.CustId RIGHT JOIN Booking ON Kids.ChildId = Booking.ChildId RIGHT JOIN Dates ON Booking.BookingID = Dates.BookingId WHERE Dates.Monday = '{date.ToShortDateString()}'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                current = new List<string>();
                current.Add(db.Rdr.GetString(0));
                current.Add(db.Rdr.GetString(1));
                current.Add(db.Rdr.GetString(2));
                details.Add(current);
            }
            db.Rdr.Close();
            return details;
        }
    }
}
