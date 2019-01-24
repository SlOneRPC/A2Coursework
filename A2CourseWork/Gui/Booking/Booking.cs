﻿using System;
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
        #region definitions
        //============== Definitions ==============
        Database db;
        decimal Nokids;
        int booked=0;
        List<bool> overbooked = new List<bool>();
        Customer cust = new Customer();
        List<Kid> kids = new List<Kid>();
        List<List<string>> dates = new List<List<string>>();
        int currentprice = 0;
        double currentDiscount = 0;

        List<int> mondays = new List<int>();
        List<int> fridays = new List<int>();
        List<DateTime> bookeddates = new List<DateTime>();
        List<DateTime> alreadybooked = new List<DateTime>();
        List<DateTime> Dates2Remove = new List<DateTime>();
        List<bool> btnbooks = new List<bool>();
        List<int> bookeddays = new List<int>();
        List<Objects.Booking> finishedbookings = new List<Objects.Booking>();

        List<string> months = new List<string>() { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        //exsisting user
        Customer existingcustomer = null;
        Kid existingkid = null;
        #endregion

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
                BookingDB bookingdb = new BookingDB(db);
                alreadybooked = bookingdb.getalldates(existingkid.Forename).Mondays;
                foreach(DateTime booking in alreadybooked)
                {
                    calculatePrice(booking, false);
                }
                DOBpicker.MinDate = DateTime.Now.AddMonths(-48);
                DOBpicker.MaxDate = DateTime.Now.AddMonths(-6);
                populatemonthscbx(true);
                populateyearscbx();
                initaliseweeks(DateTime.Now);
                book6pnl.Visible = true;
            }
            else
            {
                book2pnl.Visible = true;
                book3pnl.Visible = true;
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            MiscFunctions.buttonhover(this);
        }

        #region Form
        //============== Bookin Form ==============
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

        private void Timer_Tick(object sender, EventArgs e)
        {

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

        #endregion

        #region Customer booking
        //============== Customer Booking ==============
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
            if(postcode.Length > 8 || postcode.Length < 6)
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

        #endregion

        #region Child Booking
        //============== Child Booking ==============
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
                populatemonthscbx(true);
                populateyearscbx();
                initaliseweeks(DateTime.Now);
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

        #endregion

        #region checkout
        //============== Checkout ==============

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

            if(existingkid !=null)
            {
                //book.AddBooking(existingkid.Forename, MiscFunctions.getgroupfromage(existingkid.DOB), finishedbookings[0].Days[0], finishedbookings[0].Days[1], finishedbookings[0].Days[2], finishedbookings[0].Days[3], finishedbookings[0].Days[4]);
                book.AddDate(finishedbookings[0].Mondays, existingkid.Forename);
                if(Dates2Remove.Count > 0)
                {
                    book.removeDate(Dates2Remove, existingkid.Forename);
                }
            }
            else
            {
                int i = 0;
                foreach(Kid child in kids)
                {
                    book.Addkid(child.Forename, child.Surname, child.DOB, cust.Forename);
                    book.AddBooking(child.Forename, MiscFunctions.getgroupfromage(child.DOB), finishedbookings[i].Days[0], finishedbookings[i].Days[1], finishedbookings[i].Days[2], finishedbookings[i].Days[3], finishedbookings[i].Days[4]);
                    book.AddDate(finishedbookings[i].Mondays, child.Forename);
                    if (Dates2Remove.Count > 0)
                    {
                        book.removeDate(Dates2Remove, child.Forename);
                    }
                    i++;
                }
            }



            MessageBox.Show("Booking completed");
            CrecheMenu next = new Gui.CrecheMenu();
            this.Hide();
            next.Show();
        }

        #endregion

        #region DateBooking

        private void btnsavedate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dayslistbx.Items.Count; i++)
            {
                if (dayslistbx.GetItemChecked(i))
                {
                    bookeddays.Add(1);
                }
                else
                {
                    bookeddays.Add(0);
                }
            }
            Objects.Booking book = new Objects.Booking();
            book.Days = bookeddays;
            book.Mondays = bookeddates;
            finishedbookings.Add(book);
            bookeddates = new List<DateTime>();
            bookeddays = new List<int>();

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
                FinalPrice.Text = "Total Price: £" + Convert.ToString(currentprice * (1 - currentDiscount));
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
        #endregion

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
            string currentmonth = monthscbx.Text;
            int MonthNo = months.FindIndex(a => a.StartsWith(currentmonth));
            BookingDB bookingdb = new BookingDB(db);
            btnbooks = new List<bool>();
            string DOB = "";
            if(existingkid != null)
            {
                DOB = existingkid.DOB;
            }
            else
            {
                DOB = kids[kids.Count - 1].DOB;
            }
            overbooked = new List<bool>();
            for(int i = 0; i<= mondays.Count-1; i++)
            {
                DateTime current = new DateTime(Convert.ToInt32(yearcbx.Text), MonthNo+1, mondays[i]);
                bool Currentoverbooked = false;
                if (!alreadybooked.Contains(current))
                    Currentoverbooked = MiscFunctions.CheckAvalability(current, db, DOB);
                overbooked.Add(Currentoverbooked);
                if ((bookeddates.Contains(current) || (alreadybooked.Contains(current) && !Dates2Remove.Contains(current))) && !Currentoverbooked)
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

        #region Buttons

        private void buttons(Button current, int index)
        {
            if (btnbooks[index])
            {
                current.BackColor = Color.LimeGreen;
                current.Text = current.Text + " [Booked]";
                current.Enabled = true;
            }
            else
            {
                if (overbooked[index])
                {
                    current.BackColor = Color.FromArgb(255, 128, 128);
                    current.Text = current.Text + " [No Spaces avaliable]";
                    current.Enabled = false;
                }
                else
                {
                    current.BackColor = Color.Silver;
                    current.Enabled = true;
                }
            }
        }

        private void buttonsclicked(Button current,int index)
        {
            string currentmonth = monthscbx.Text;
            int MonthNo = months.FindIndex(a => a.StartsWith(currentmonth));
            if (!btnbooks[index])
            {
                DateTime selecteddate = new DateTime(Convert.ToInt32(yearcbx.Text), MonthNo + 1, mondays[index]);
                if (Dates2Remove.Contains(selecteddate))
                {
                    Dates2Remove.Remove(selecteddate);
                }
                else
                {
                    bookeddates.Add(selecteddate);
                }
                calculatePrice(selecteddate, false);
                current.BackColor = Color.LimeGreen;
                current.Text = current.Text + " [Booked]";
                btnbooks[index] = true;
                btnfinished.Enabled = true;
            }
            else
            {
                DateTime selecteddate = new DateTime(Convert.ToInt32(yearcbx.Text), MonthNo + 1, mondays[index]);
                if (bookeddates.Contains(selecteddate))
                {
                    bookeddates.Remove(selecteddate);
                }
                else
                {
                    Dates2Remove.Add(selecteddate);
                }
                calculatePrice(selecteddate, true);
                current.BackColor = Color.Silver;
                current.Text = current.Text.Remove(current.Text.Length - 9);
                btnbooks[index] = false;
                btnfinished.Enabled = false;
            }

            totalpricelbl.Text = "Total Price: " + currentprice * (1 - currentDiscount);
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

        #endregion

        #region index change
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
        #endregion

        private void btnfinished_Click(object sender, EventArgs e)
        {
            totalpricelbl.Visible = false;
            book6pnl.Visible = false;
            populatedayslist();
            book4pnl.Visible = true;
        }

        private void calculatePrice(DateTime bookeddate,bool remove)
        {
            if (remove)
            {
                if (bookeddate > DateTime.Now.AddMonths(3) && bookeddate < DateTime.Now.AddMonths(6) && currentDiscount != 5)
                {
                    bool keep = false;
                    foreach(DateTime date in bookeddates)
                    {
                        if(date > DateTime.Now.AddMonths(3) && date < DateTime.Now.AddMonths(6))
                        {
                            keep = true;
                        }
                    }
                    if (!keep)
                    {
                        currentDiscount = 0;
                    }
                }
                else if (bookeddate >= DateTime.Now.AddMonths(6))
                {
                    bool keep = false;
                    foreach (DateTime date in bookeddates)
                    {
                        if (date >= DateTime.Now.AddMonths(6))
                        {
                            keep = true;
                        }
                    }
                    if (!keep)
                    {
                        foreach (DateTime date in bookeddates)
                        {
                            if (date > DateTime.Now.AddMonths(3) && date < DateTime.Now.AddMonths(6))
                            {
                                keep = true;
                            }
                        }
                        if (!keep)
                        {
                            currentDiscount = 0;
                        }
                        else
                        {
                            currentDiscount = 0.03;
                        }
                    }
                }
                currentprice -= 15;
            }
            else
            {
                if (bookeddate > DateTime.Now.AddMonths(3) && bookeddate < DateTime.Now.AddMonths(6) && currentDiscount != 5)
                {
                    currentDiscount = 0.03;
                }
                else if (bookeddate >= DateTime.Now.AddMonths(6))
                {
                    currentDiscount = 0.05;
                }
                currentprice += 15;
            }
            totalpricelbl.Visible = true;
            totalpricelbl.Text = "Total Price: £" + Convert.ToString(currentprice * (1 - currentDiscount));
        }

    }
}