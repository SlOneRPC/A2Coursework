using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Classes
{
    class BookingDB
    {
        Database db;
        public BookingDB(Database db)
        {
            this.db = db;

        }

        public void Addcustomer(string ForeName,string Surname, string TeleNo, string postcode)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Customer(Forename,Surname,TeleNo,Postcode) VALUES( '" + ForeName + "','" + Surname + "','" + TeleNo + "','" + postcode + "')";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
