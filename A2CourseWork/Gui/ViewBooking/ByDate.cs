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
        DateTime current;
        double revenue;
        private DataTable table;
        private Database db;
        public ByDate()
        {
            InitializeComponent();
            titlelbl.Text = "Woodside Community - creche - View";
            db = new Database();
            db.connect();
            panel2.BringToFront();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //if()
        }

        //populate the years combo box with 5 years
        private void populateyearscbx()
        {
            yearcbx.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                yearcbx.Items.Add(DateTime.Now.Year + i -1);
            }
            yearcbx.SelectedIndex = 1;
        }

        //populate months combo with all 12 months 
        private void populatemonthscbx(bool currentyear)
        {
            monthscbx.Items.Clear();
            for (int i = 0; i < 12; i++)
            {
                monthscbx.Items.Add(months[i]);
            }
            monthscbx.SelectedIndex = 0;
        }

        //populate week buttons depending on the amount of weeks in the months
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
                    mondays.Add(date.Day);//grab monday dates for viewing
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
            weeklbl.Text = "Week: " + selected.ToString();
            current = new DateTime(now.Year, now.Month, mondays[selected-1]);
            createTableforKids(current);
            createTableforBooking(current);
        }
        //on index change update months/weeks accordingly
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
            populateweekbtns(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year - 1, monthscbx.SelectedIndex + 1, 1));
        }
        //on month change update weeks accordingly
        private void monthscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = monthscbx.SelectedIndex + 1;
            populateweekbtns(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year - 1, x, 1));
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
            monthscbx.SelectedIndex = DateTime.Now.Month - 1;
        }
        //create a table for the details about kids/parents booked in that week
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
                table.Rows.Add(current[0] + " " + current[1],current[2] + " " + current[3],current[4],MiscFunctions.getgroupfromage(current[4]));
            }
            KidsView.DataSource = table;
        }
        //create table to show the bookings for that week
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
                table.Rows.Add(current[0] + " " + current[1]);
            }
            amountlbl.Text = "Booking amount: " + data.Count.ToString();
            PricesDB pdb = new PricesDB(db);
            revenue = data.Count * pdb.getBase();
            revenuelbl.Text = "Estimated revenue: £" + (data.Count*pdb.getBase()).ToString();
            WeekView.DataSource = table;
            WeekView.AllowUserToAddRows = false;
            int x = 0;
            foreach(DataGridViewRow row in WeekView.Rows) //need to loop through the rows in order to color the cells accordingly
            {
                List<string> current = data[x];
                for (int i = 0; i <5; i++)
                {
                    if (current[i + 2] == "1")
                    {
                        row.Cells[i+1].Style.BackColor = Color.LimeGreen;//green for booked
                    }
                    else
                    {
                        row.Cells[i+1].Style.BackColor = Color.Red;//red for not booked
                    }
                }
                x++;
            }
            WeekView.Enabled = false;
        }

        private void week2rbtn_CheckedChanged(object sender, EventArgs e)
        {
            int x = monthscbx.SelectedIndex + 1;
            populateweekbtns(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year - 1, x, 1));
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ViewMenu menu = new ViewMenu();
            this.Hide();
            menu.Show();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            GeneratedReport form = new GeneratedReport(current,revenue);
            form.Show();
        }
    }
}
