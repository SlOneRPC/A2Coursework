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

        

    

    }
}
