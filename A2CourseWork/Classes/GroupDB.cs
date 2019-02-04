using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Classes
{
    class GroupDB
    {
        Database db;
        public GroupDB(Database db)
        {
            this.db = db;
        }

        public List<string> getgroupnames()
        {
            List<string> groupNames = new List<string>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Groups";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                groupNames.Add(db.Rdr.GetString(1));
            }
            db.Rdr.Close();
            return groupNames;
        }

        public void updateGroupNames(string groupA,string GroupB,string GroupC)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupName = '{groupA}' WHERE GroupId = 1";
            db.Cmd.ExecuteNonQuery();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupName = '{GroupB}' WHERE GroupId = 2";
            db.Cmd.ExecuteNonQuery();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupName = '{GroupC}' WHERE GroupId = 2";
            db.Cmd.ExecuteNonQuery();
        }
    }
}
