using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CourseWork.Classes
{
    class PricesDB
    {
        Database db;
        public PricesDB(Database db)
        {
            this.db = db;
        }

        public int getBase()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Prices";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(0);
            }
            db.Rdr.Close();
            return amount;
        }

        public int getMinDiscount()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Prices";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(1);
            }
            db.Rdr.Close();
            return amount;
        }

        public int getMedDiscount()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Prices";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(2);
            }
            db.Rdr.Close();
            return amount;
        }

        public int getMaxDiscount()
        {
            int amount = 0;
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Prices";
            db.Rdr = db.Cmd.ExecuteReader();
            if (db.Rdr.Read())
            {
                amount = db.Rdr.GetInt32(3);
            }
            db.Rdr.Close();
            return amount;
        }

        public void updateValues(int baseAmount,int min,int med,int max)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = $"UPDATE Prices Set base = {baseAmount},MinDiscount = {min}, MedDiscount = {med}, MaxDiscount ={max}";
            db.Cmd.ExecuteNonQuery();
        }

    }
}
