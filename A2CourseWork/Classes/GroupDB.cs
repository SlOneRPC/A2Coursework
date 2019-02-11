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

        public int getANum()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Groups WHERE GroupId = 1";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(2);
            }
            db.Rdr.Close();
            return amount;
        }

        public int getBNum()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Groups WHERE GroupId = 2";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(2);
            }
            db.Rdr.Close();
            return amount;
        }

        public int getCNum()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Groups WHERE GroupId = 3";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(2);
            }
            db.Rdr.Close();
            return amount;
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

        public void updateGroupNumbers(int A,int B,int C)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupAmount = {A} WHERE GroupId = 1";
            db.Cmd.ExecuteNonQuery();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupAmount = {B} WHERE GroupId = 2";
            db.Cmd.ExecuteNonQuery();

            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Groups SET GroupAmount = {C} WHERE GroupId = 3";
            db.Cmd.ExecuteNonQuery();
        }

        public List<int> numineachgroup()
        {
            List<int> groupNums = new List<int>();
            for(int i = 1; i <= 3;i++)
            {
                db.Cmd = db.Conn.CreateCommand();
                db.Cmd.CommandText = $"SELECT COUNT(*) FROM Booking WHERE GroupId = {i}";
                db.Rdr = db.Cmd.ExecuteReader();
                int current = 0;
                if (db.Rdr.Read())
                {
                    current = db.Rdr.GetInt32(0);
                }
                groupNums.Add(current);
                db.Rdr.Close();
            }
            return groupNums;
        }
    }
}
