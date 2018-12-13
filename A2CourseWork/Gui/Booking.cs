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


        List<int> mondays = new List<int>();
        List<int> fridays = new List<int>();
        List<int> bookeddates = new List<int>();
        List<bool> btnbooks = new List<bool>();
        List<string> bookeddays = new List<string>();
        List<Objects.Booking> datesbooked = new List<Objects.Booking>();


        //exsisting user
        Customer existingcustomer = null;
        Kid existingkid = null;


        public Booking(Customer existingcustomer,Kid existingkid)
        {
            db = new Database();
            InitializeComponent();
            db.connect();
            this.existingcustomer = existingcustomer;
            this.existingkid = existingkid;
            if(existingcustomer != null)
            {
                book1pnl.Visible = false;
            }
            if(existingkid != null && !book1pnl.Visible)
            {
                DOBpicker.MinDate = DateTime.Now.AddMonths(-48);
                DOBpicker.MaxDate = DateTime.Now.AddMonths(-6);
                initaliseweeks(DateTime.Now);
                populatemonthscbx(true);
                populateyearscbx();
                book6pnl.Visible = true;
            }
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


                if(existingkid != null)
                {
                    //hide customer show booking
                    book1pnl.Visible = false;
                    book4pnl.Visible = true;
                }
                else
                {
                    //hide customer show kid
                    book1pnl.Visible = false;
                    book2pnl.Visible = true;
                    book3pnl.Visible = true;
                }


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

                book3pnl.Visible = false;
                book2pnl.Visible = false;
                initaliseweeks(DateTime.Now);
                populatemonthscbx(true);
                populateyearscbx();
                book6pnl.Visible = true;
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
            if(existingcustomer == null)
            {
                book.Addcustomer(cust.Forename, cust.Surname, cust.TeleNo, cust.Postcode, cust.Address);
            }
            else
            {
                cust = existingcustomer;
            }


            if(existingkid == null)
            {
                //add all the kids to db
                int i = 0;
                foreach (Kid child in kids)
                {
                    book.Addkid(child.Forename, child.Surname, child.DOB, cust.Forename);
                    List<string> date = dates[i];
                    List<int> Dates = datesbooked[i].Mondays;
                    List<string> Days = datesbooked[i].Days;
                    //book.AddDates(date[0], date[1], child.Forename, date[2], Convert.ToInt32(date[3]), Convert.ToInt32(date[4]), Convert.ToInt32(date[5]), Convert.ToInt32(date[6]), Convert.ToInt32(date[7]));
                    i++;
                }
            }
            else
            {
                List<string> date = dates[0];
                book.AddDates(date[0], date[1], existingkid.Forename, date[2], Convert.ToInt32(date[3]), Convert.ToInt32(date[4]), Convert.ToInt32(date[5]), Convert.ToInt32(date[6]), Convert.ToInt32(date[7]));
            }


            MessageBox.Show("Booking completed");
            CrecheMenu next = new Gui.CrecheMenu();
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

        private void btnsavedate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dayslistbx.Items.Count; i++)
            {
                if (dayslistbx.GetItemChecked(i))
                {
                    bookeddays.Add("1");
                }
                else
                {
                    bookeddays.Add("0");
                }
            }
            Objects.Booking book = new Objects.Booking();
            book.Days = bookeddays;
            book.Mondays = bookeddates;
            datesbooked.Add(book);
            bookeddates = new List<int>();
            bookeddays = new List<string>();

            //next
            if (booked == Nokids || existingkid != null)
            {
                if (existingkid != null)
                {
                    KidsBookedlbl.Text = "Number of Kids Booked: 1";
                    Kidslist.Items.Add(existingkid.Forename + " " + existingkid.Surname);
                }
                else
                {
                    KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
                }
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
                dayslistbx.SetItemChecked(i, true);
            }
        }

        private void initaliseweeks(DateTime now)
        {
            extrapnl.Visible = false;
            book6pnl.Size = new Size(823, 424);
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
                else if(date.DayOfWeek == DayOfWeek.Friday)
                {
                    fridays.Add(date.Day);
                }
            }

            for (int x = 0; x <= mondays.Count-1; x++)
            {
                string day1 = "";
                string day2 = "";

                if(x == fridays.Count)
                {
                    if(x == mondays.Count)
                    {
                        day1 = Convert.ToString(mondays[x - 1]);
                    }
                    else
                    {
                        day1 = Convert.ToString(mondays[x]);
                    }
                    day2 = "Next Month";
                    extrapnl.Visible = true;
                    book6pnl.Size = new Size(823, 493);
                }
                else if (mondays[x] > fridays[x])
                {
                    day1 = Convert.ToString(mondays[x]);
                    if (x == fridays.Count - 1)
                    {
                        day2 = "Next Month";
                    }
                    else
                    {
                        day2 = Convert.ToString(fridays[x + 1]);
                    }
                }
                else
                {
                    day1 = Convert.ToString(mondays[x]);
                    day2 = Convert.ToString(fridays[x]);
                }
        
                string text =  day1 + "-" + day2;
                switch (x)
                {
                    case 0:
                        week1btn.Text = "Week 1: " + text;
                        break;
                    case 1:
                        week2btn.Text = "Week 2: " + text;
                        break;
                    case 2:
                        week3btn.Text = "Week 3: " + text;
                        break;
                    case 3:
                        week4btn.Text = "Week 4: " + text;
                        break;
                    case 4:
                        week5btn.Text = "Week 5: " + text;
                        break;
                }
            }

            btnbooks = new List<bool>();
            for(int i = 0; i<= mondays.Count-1; i++)
            {
                if (bookeddates.Contains(mondays[i]))
                {
                    btnbooks.Add(true);
                }
                else
                {
                    btnbooks.Add(false);
                }
            }
            List<Button> bookingbuttons = new List<Button>() { week1btn, week2btn, week3btn, week4btn };
            if(mondays.Count-1 == 4)
            {
                bookingbuttons.Add(week5btn);
            }
            int y = 0;
            foreach(Button b in bookingbuttons)
            {
                buttons(b, y);
                y++;
            }
        }

        private void populatemonthscbx(bool currentyear)
        {
            monthscbx.Items.Clear();
            List<string> months = new List<string>() { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
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
            monthtitlelbl.Text = monthscbx.Text + " " + yearcbx.Text;
        }

        private void populateyearscbx()
        {
            yearcbx.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                yearcbx.Items.Add(DateTime.Now.Year+i);
            }
            yearcbx.SelectedIndex = 0;
        }

        private void buttons(Button current, int index)
        {
            if (btnbooks[index])
            {
                current.BackColor = Color.LimeGreen;
                current.Text = current.Text + " [Booked]";
            }
            else
            {
                current.BackColor = Color.Silver;
            }
        }

        private void buttonsclicked(Button current,int index)
        {
            if (!btnbooks[index])
            {
                bookeddates.Add(mondays[index]);
                current.BackColor = Color.LimeGreen;
                current.Text = current.Text + " [Booked]";
                btnbooks[index] = true;
            }
            else
            {
                bookeddates.Remove(mondays[index]);
                current.BackColor = Color.Silver;
                current.Text = current.Text.Remove(current.Text.Length - 9);
                btnbooks[index] = false;
            }
        }

        private void week1btn_Click(object sender, EventArgs e)
        {
            buttonsclicked(week1btn, 0);
        }

        private void week2btn_Click(object sender, EventArgs e)
        {
            buttonsclicked(week2btn, 1);
        }

        private void week3btn_Click(object sender, EventArgs e)
        {
            buttonsclicked(week3btn, 2);
        }

        private void week4btn_Click(object sender, EventArgs e)
        {
            buttonsclicked(week4btn, 3);
        }

        private void week5btn_Click(object sender, EventArgs e)
        {
            buttonsclicked(week5btn, 4);
        }
        bool intialy = true;
        private void yearcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!intialy)
            {
                if (yearcbx.Text == DateTime.Now.Year.ToString())
                {
                    populatemonthscbx(true);
                }
                else
                {
                    populatemonthscbx(false);
                }
                initaliseweeks(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year, monthscbx.SelectedIndex + 1, 1));
            }
            else
            {
                intialy = false;
            }
           
        }
        bool initalm = true;
        private void monthscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (initalm)
            {
                initalm = false;
            }
            else
            {
                x = monthscbx.SelectedIndex + 1;
                initaliseweeks(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year + 0, x, DateTime.Now.Day));
            }
            monthtitlelbl.Text = monthscbx.Text + " " + yearcbx.Text;
        }
    }
}
