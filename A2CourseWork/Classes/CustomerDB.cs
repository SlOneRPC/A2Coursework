using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2CourseWork.Objects;
using System.Data.SqlClient;
namespace A2CourseWork.Classes
{
    class CustomerDB
    {
        Database db;
        public CustomerDB(Database db)
        {
            this.db = db;
        }

        public List<Customer> getallcustomers()
        {
            List<Customer> customers = new List<Customer>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "SELECT * FROM Customer";
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                customers.Add(getcustomerfromreader(db.Rdr));
            }
            db.Rdr.Close();
            return customers;
        }

        private Customer getcustomerfromreader(SqlDataReader reader)
        {
            Customer current = new Customer();
            current.CustId = reader.GetInt32(0);
            current.Forename = reader.GetString(1);
            current.Surname = reader.GetString(2);
            current.TeleNo = reader.GetString(3);
            current.Address = reader.GetString(4);
            current.Postcode = reader.GetString(5);
            return current;
        }
    }
}
