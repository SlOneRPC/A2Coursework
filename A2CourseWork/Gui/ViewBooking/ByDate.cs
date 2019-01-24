using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2CourseWork.Classes;
using A2CourseWork.Objects;
namespace A2CourseWork.Gui.ViewBooking
{
    public partial class ByDate : Default
    {
        List<int> mondays = new List<int>();
        List<int> fridays = new List<int>();
        List<string> months = new List<string>() { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        
        private DataTable table;
        private Database db;
        public ByDate()
        {
            InitializeComponent();
            titlelbl.Text = "Woodside Community - creche - View";
            db = new Database();
            db.connect();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //if()
        }


        private void populateyearscbx()
        {
            yearcbx.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                yearcbx.Items.Add(DateTime.Now.Year + i);
            }
            yearcbx.SelectedIndex = 0;
        }

        private void populatemonthscbx(bool currentyear)
        {
            monthscbx.Items.Clear();
            if (currentyear)
            {
                for (int i = DateTime.Now.Month - 1; i < 12; i++)
                {
                    //if(bookeddays.Contains(mondays[i]))
                    monthscbx.Items.Add(months[i]);
                }
                monthscbx.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    monthscbx.Items.Add(months[i]);
                }
                monthscbx.SelectedIndex = 0;
            }
        }

        private void populateweekbtns(DateTime now)
        {
            DateTime startdate = new DateTime(now.Year, now.Month, 1);
            DateTime enddate = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
            mondays = new List<int>();
            fridays = new List<int>();
            for (DateTime date = startdate; date <= enddate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    mondays.Add(date.Day);
                }
            }
            if (mondays.Count <= 4)
            {
                week5rbtn.Visible = false;
                week5rbtn.Enabled = false;
            }
            else
            {
                week5rbtn.Visible = true;
                week5rbtn.Enabled = true;
            }
            int selected = 1;
            if (week2rbtn.Checked)
            {
                selected = 2;
            }
            else if (week3rbtn.Checked)
            {
                selected = 3;
            }
            else if (week4rbtn.Checked)
            {
                selected = 4;
            }
            else if (week5rbtn.Checked)
            {
                selected = 5;

            }
            DateTime current = new DateTime(now.Year, now.Month, mondays[selected]);
            createTableforKids(current);
            createTableforBooking(current);
        }

        private void yearcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearcbx.Text == DateTime.Now.Year.ToString())
            {
                populatemonthscbx(true);
            }
            else
            {
                populatemonthscbx(false);
            }
            populateweekbtns(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year, monthscbx.SelectedIndex + 1, 1));
        }

        private void monthscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = monthscbx.SelectedIndex + 1;
            populateweekbtns(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year + 0, x, DateTime.Now.Day));
        }

        private void ByDate_Load(object sender, EventArgs e)
        {
            populateyearscbx();
            if (DateTime.Now.Year.ToString() == yearcbx.Text)
            {
                populatemonthscbx(true);
            }
            else
            {
                populatemonthscbx(false);
            }
            populateweekbtns(DateTime.Now);
        }

        private void createTableforKids(DateTime now)
        {
            table = new DataTable();
            table.Columns.Add("Parent Name");
            table.Columns.Add("Kid Name");
            table.Columns.Add("Kid DOB");
            table.Columns.Add("Kid Group");
            MiscDB miscdb = new MiscDB(db);
            List<List<string>> data = miscdb.BookingDetails(now);

            foreach(List<string> current in data)
            {
                table.Rows.Add(current[0],current[1],current[2]);
            }
            KidsView.DataSource = table;
        }

        private void createTableforBooking(DateTime now)
        {
            table = new DataTable();
            table.Columns.Add("Kid Name");
            table.Columns.Add("Mon");
            table.Columns.Add("Tues");
            table.Columns.Add("Weds");
            table.Columns.Add("Thurs");
            table.Columns.Add("Friday");

            MiscDB miscdb = new MiscDB(db);
            List<List<string>> data = miscdb.BookingDays(now);
            foreach (List<string> current in data)
            {
                table.Rows.Add(current[0] + " " + current[1],current[2],current[3],current[4],current[5],current[6]);
            }
            WeekView.DataSource = table;
        }
    }
}
