using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A2CourseWork.Classes
{
    class BookingDB
    {
        Database db;
        public BookingDB(Database db)
        {
            this.db = db;

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

        public void AddDates(string startdate,string endate,string childname,string groupname,int Mon,int Tues,int Wed,int Thur,int Friday)
        {
            int childId = getchildID(childname);
            int groupId = getgroupID(groupname);
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Booking(ChildId,GroupId,StartDate,EndDate) VALUES( '" + childId + "','" + groupId + "','" + startdate + "','" + endate + "')";
            doquery();
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
