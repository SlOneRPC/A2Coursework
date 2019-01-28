using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2CourseWork.Objects;
using System.Data.SqlClient;
namespace A2CourseWork.Classes
{
    class KidsDB
    {
        private Database db;
        public KidsDB(Database db)
        {
            this.db = db;
        }

        public List<Kid> getallkids()
        {
            List<Kid> kids = new List<Kid>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Kids";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                kids.Add(getkidfromreader(db.Rdr));
            }
            db.Rdr.Close();
            return kids;
        }

        public Kid getSpecificKid(string KidForename)
        {
            Kid child = new Kid();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"SELECT * FROM Kids WHERE ForeName = '{KidForename}'";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                child = getkidfromreader(db.Rdr);
            }
            db.Rdr.Close();
            return child;
        }

        private Kid getkidfromreader(SqlDataReader reader)
        {
            Kid child = new Kid();
            child.Kidid = reader.GetInt32(0);
            child.ParentID = reader.GetInt32(1);
            child.Forename = reader.GetString(2);
            child.Surname = reader.GetString(3);
            child.DOB = reader.GetString(4);
            return child;
        }
    }
}

