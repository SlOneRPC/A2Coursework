using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2CourseWork.Objects;
using System.Data.SqlClient;
namespace A2CourseWork.Classes
{
    class StaffDB
    {
        Database db;
        public StaffDB(Database db)
        {
            this.db = db;
        }

        public List<StaffMember> getallstaff()
        {
            List<StaffMember> results = new List<StaffMember>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Staff";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getstaffFromReader(db.Rdr));
            }
            db.Rdr.Close();
            return results;
        }

        public StaffMember getstaffFromReader(SqlDataReader reader)
        {
            StaffMember member = new StaffMember();
            member.StaffId = reader.GetInt32(0);
            member.Forename = reader.GetString(1);
            member.Surname = reader.GetString(2);
            member.TeleNo = reader.GetString(3);
            member.Address = reader.GetString(4);
            member.Postcode = reader.GetString(5);
            return member;
        }

        public void addstaffmember(string forename,string surname,string teleno,string postcode,string address)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Staff(Forename,Surname,TeleNo,Address,Postcode) VALUES('" + forename+ "','" + surname + "', '" + teleno + "', '" + address + "', '" + postcode + "')";
            db.Cmd.ExecuteNonQuery();
        }

        public void updatestaffmember(string oldForename, string forename, string surname, string teleno, string postcode, string address)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "UPDATE Staff SET Forename = '" + forename + "',Surname = '" + surname + "',TeleNo = '" + teleno + "', Postcode = '" + postcode + "',Address = '" + address + "' WHERE Forename = '" + oldForename +"'";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
