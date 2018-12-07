using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace A2CourseWork.Classes
{
    class Database
    {
        public Database() { }
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader rdr;
        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }

        public bool connect()
        {
            string local = Application.StartupPath;
            SqlConnectionStringBuilder scStrBuild = new SqlConnectionStringBuilder();
            scStrBuild.DataSource = "(LocalDB)\\MSSQLLocalDB";
            scStrBuild.AttachDBFilename = local + "\\CrecheData.mdf";
            scStrBuild.IntegratedSecurity = true;
            conn = new SqlConnection(scStrBuild.ToString());

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                return false;
            }
            catch (SqlException)
            {
                Console.WriteLine("sqlexception - connection falied!");
                Console.WriteLine("Contact system admin");
                return false;
            }
        }

        public bool isopen()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
