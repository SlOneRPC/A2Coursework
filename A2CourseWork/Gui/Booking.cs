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
namespace A2CourseWork.Gui
{
    public partial class Booking : Form
    {
        Database db;
        decimal Nokids;
        int booked=0;
        Customer cust = new Customer();
        List<Kid> kids = new List<Kid>();
        List<List<string>> dates = new List<List<string>>();

        //dates
        string startdate = null;
        string enddate = null;


        public Booking()
        {
            db = new Database();
            InitializeComponent();
            db.connect();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MiscFunctions.exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        System.Drawing.Point lastclick;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void homepbx_Click(object sender, EventArgs e)
        {
            if (!book3pnl.Visible)
            {
                Menu home = new Menu();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please complete booking before returning to home");
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (CustomerRequirements())
            {
                //create customer object
                cust.Forename = Fnametxt.Text;
                cust.Surname = Snametxt.Text;
                cust.TeleNo = teleNotxt.Text;
                cust.Postcode = posttxt.Text;
                cust.Address = addresstxt.Text;


                //hide customer show kid
                book1pnl.Visible = false;
                book2pnl.Visible = true;
                book3pnl.Visible = true;

                //setup dates for DOB
                DOBpicker.MinDate = DateTime.Now.AddMonths(-48);
                DOBpicker.MaxDate = DateTime.Now.AddMonths(-6);
                //DOBpicker.MinDate = 

                Nokids = KidsNo.Value;
                if (booked == Nokids - 1)
                {
                    btnnext.Text = "Add";
                }
                btncheckout.Enabled = false;
                
            }
            else
            {
                errorlabellbl.Visible = true;
            }
        }

        private void OnNewkid()
        {
            ChildFnametxt.Text = "";
            childSnametxt.Text = "";
            DOBpicker.ResetText();
            KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
        }

        private bool CustomerRequirements()
        {
            bool error = false;
            if(Fnametxt.Text == "")
            {
                Error1txt.Visible = true;
                error = true;
            }
            if(Snametxt.Text == "")
            {
                error2txt.Visible = true;
                error = true;
            }
            if (teleNotxt.TextLength != 11)
            {
                error3txt.Visible = true;
                error = true;
            }
            else
            {
                foreach (char c in teleNotxt.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        error3txt.Visible = true;
                        error = true;
                        MessageBox.Show("Telephone number must only contain numbers!");
                        break;
                    }
                }
            }
            string postcode = posttxt.Text.Replace(" ", String.Empty);
            if(postcode.Length > 8 || postcode.Length < 7)
            {
                error4txt.Visible = true;
                MessageBox.Show("Postcode does not meet UK requirements");
                error = true;
            }
            if(addresstxt.Text == "")
            {
                error5txt.Visible = true;
                error = true;
            }
            if(KidsNo.Value < 1 || (KidsNo.Value % 1) != 0)
            {
                error6txt.Visible = true;
                error = true;
            }
            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (childrequirements())
            {
                //create a kid object (New method)
                Kid child = new Kid();
                child.Forename = ChildFnametxt.Text;
                child.Surname = childSnametxt.Text;
                child.DOB = DOBpicker.Value.ToShortDateString();
                kids.Add(child);

                booked += 1;
                Kidslist.Items.Add(ChildFnametxt.Text + " " + childSnametxt.Text);
                btncheckout.Enabled = true;

                if (booked != Nokids)
                {
                    OnNewkid();
                }
                BookingCalendar.MinDate = DateTime.Now;
                book3pnl.Visible = false;
                book2pnl.Visible = false;
                book4pnl.Visible = true;
            }
        }

        private bool childrequirements()
        {
            bool error = false;
            if(ChildFnametxt.Text == "")
            {
                Cerror1.Visible = true;
                error = true;
            }
            if(childSnametxt.Text == "")
            {
                Cerror2.Visible = true;
                error = true;
            }
            if (error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            if(booked != Nokids)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to checkout without booking all kids?", "Booking", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    savetodb();
                }
            }
            else
            {
                savetodb();
            }
        }

        private void savetodb()
        {
            //add customer to Database
            BookingDB book = new BookingDB(db);
            book.Addcustomer(cust.Forename, cust.Surname, cust.TeleNo, cust.Postcode, cust.Address);

            //add all the kids to db
            int i = 0;
            foreach (Kid child in kids)
            {
                book.Addkid(child.Forename, child.Surname, child.DOB, cust.Forename);
                List<string> date = dates[i];
                book.AddDates(date[0], date[1], child.Forename, date[2],Convert.ToInt32(date[3]), Convert.ToInt32(date[4]), Convert.ToInt32(date[5]), Convert.ToInt32(date[6]), Convert.ToInt32(date[7]));
                i++;
            }

            MessageBox.Show("Booking completed");
            Menu next = new Gui.Menu();
            this.Hide();
            next.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            Timer.Start();
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            MiscFunctions.buttonhover(this);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            leave();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            leave();
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            leave();
        }

        private void leave()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Booking will be lost?", "Leave Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrecheMenu form = new CrecheMenu();
                form.Show();
                this.Hide();
            }
        }

        int count = 0;
        private void btnsavedate_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                startdate = BookingCalendar.SelectionRange.Start.ToShortDateString();
                BookingCalendar.MinDate = BookingCalendar.SelectionRange.Start;
                BookingCalendar.ResetText();
                datelbl.Text = "Please select the End Date";

                //days
                book4pnl.Size = new Size(538, 325);
                datestitlelbl.Location = new Point(224, 10);

                btnsavedate.Size = new Size(483, 51);
                btnsavedate.Location = new Point(40, 265);
                populatedayslist();
            }
            else
            {
                enddate = BookingCalendar.SelectionRange.Start.ToShortDateString();

                //calculate age
                int months = DateTime.Now.Month - Convert.ToDateTime(kids[kids.Count - 1].DOB).Month;
                int years = DateTime.Now.Year - Convert.ToDateTime(kids[kids.Count - 1].DOB).Year;
                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                if(years > 0)
                {
                    months += (years * 12);
                }

                string groupName = "";
                //calculate group
                if (months > 5 && months < 19)
                {
                    groupName = "Baby";
                }
                else if(months >= 18 && months <= 30)
                {
                    groupName = "Toddlers";
                }
                else if(months >=30 && months <= 48)
                {
                    groupName = "Children";
                }
                else
                {
                    MessageBox.Show("Error - Invalid group name");
                    return;
                }
                //add dates to list
                List<string> date = new List<string>();
                date.Add(startdate);
                date.Add(enddate);
                date.Add(groupName);
                for(int i = 0; i < dayslistbx.Items.Count; i++)
                {
                    if (dayslistbx.GetItemChecked(i))
                    {
                        date.Add("1");
                    }
                    else
                    {
                        date.Add("0");
                    }
                }
                dates.Add(date);

                //reset for new kid
                count = -1;
                datelbl.Text = "Please select the Start Date";
                book4pnl.Size = new Size(273, 325);
                datestitlelbl.Location = new Point(106, 5);
                btnsavedate.Size = new Size(233, 51);
                btnsavedate.Location = new Point(26, 259);


                if (booked == Nokids)
                {
                    KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
                    book4pnl.Visible = false;
                    book3pnl.Location = new Point(408, 65);
                    book3pnl.Visible = true;
                }
                else
                {
                    book4pnl.Visible = false;
                    book2pnl.Visible = true;
                    book3pnl.Visible = true;
                }
            }
            count++;
        }

        private void populatedayslist()
        {
            dayslistbx.Items.Clear();
            dayslistbx.Items.Add("Monday");
            dayslistbx.Items.Add("Tuesday");
            dayslistbx.Items.Add("Wednesday");
            dayslistbx.Items.Add("Thursday");
            dayslistbx.Items.Add("Friday");
            for (int i = 0; i < dayslistbx.Items.Count; i++)
            {
                dayslistbx.SetItemChecked(i,true);
            }
        }
    }
}
