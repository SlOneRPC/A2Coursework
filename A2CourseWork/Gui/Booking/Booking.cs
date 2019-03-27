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
using A2CourseWork.CustExpections;
namespace A2CourseWork.Gui
{
    public partial class Booking : Default
    {
        #region definitions
        //============== Definitions ==============
        Database db;
        decimal Nokids;
        int booked=0;
        Kid child;
        List<bool> overbooked = new List<bool>();
        List<bool> oldDate = new List<bool>();
        List<bool> understaffed = new List<bool>();
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
            //estabilsh db connection
            db = new Database();
            db.connect();
            InitializeComponent();
            this.existingcustomer = existingcustomer;
            this.existingkid = existingkid;
            //if customer already exist we dont need to create a new one
            if(existingcustomer != null)
            {
                book1pnl.Visible = false;
            }
            //if kid already exist we do not need to create a new one
            if(existingkid != null && !book1pnl.Visible)
            {
                BookingDB bookingdb = new BookingDB(db);
                alreadybooked = bookingdb.getalldates(existingkid.Forename, existingkid.Surname).Mondays;
                foreach (DateTime booking in alreadybooked)
                {
                    calculatePrice(booking, false);
                }
                //setup dates for DOB
                DOBpicker.MinDate = DateTime.Now.AddMonths(-48);
                DOBpicker.MaxDate = DateTime.Now.AddMonths(-6);
                //setup booking
                populatemonthscbx(true);
                populateyearscbx();
                initaliseweeks(DateTime.Now);
                book6pnl.Visible = true;
            }
            else
            {
                //if existing customer but no existing kid
                book2pnl.Visible = true;
                book3pnl.Visible = true;
                //setup dates for DOB
                DOBpicker.MinDate = DateTime.Now.AddMonths(-48);
                DOBpicker.MaxDate = DateTime.Now.AddMonths(-6);
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        #region Form
        //prompt the user in order to close the form
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
        //back button changes depending on the panel visible
        private void btnback_Click(object sender, EventArgs e)
        {
            if (book1pnl.Visible)
            {
                leave();
            }
            else if (book2pnl.Visible)
            {
                if(existingcustomer != null)
                {
                    leave();
                    return;
                }
                else if (booked > 0)
                {
                    MessageBox.Show("You cannot go back after completing a booking!");
                    return;
                }
                book2pnl.Visible = false;
                book3pnl.Visible = false;
                book1pnl.Visible = true;
            }
            else if (book6pnl.Visible)
            {
                if (existingkid != null)
                {
                    leave();
                    return;
                }
                kids.Remove(child);
                Kidslist.Items.RemoveAt(Kidslist.Items.Count-1);
                booked -= 1;
                book6pnl.Visible = false;
                book2pnl.Visible = true;
                book3pnl.Visible = true;
            }
            else if (book4pnl.Visible)
            {
                book4pnl.Visible = false;
                book6pnl.Visible = true;
            }
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
            if (CustomerRequirements() && checkLength())
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
                // if customer does not meet requirements show error
                errorlabellbl.Visible = true;
            }
        }
        //next kid clear previous data
        private void OnNewkid()
        {
            ChildFnametxt.Text = "";
            childSnametxt.Text = "";
            DOBpicker.ResetText();
            KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
        }

        private bool checkLength()
        {
            try
            {
                if (!MiscFunctions.insureValid(Fnametxt.Text.Length, 30))
                {
                    Error1txt.Visible = true;
                    throw new LengthException("First name is too long! Max lenght 30 characters");
                }
                else if (!MiscFunctions.insureValid(Snametxt.Text.Length, 30))
                {
                    error2txt.Visible = true;
                    throw new LengthException("Second name is too long! Max lenght 30 characters");
                }
                else if (!MiscFunctions.insureValid(addresstxt.Text.Length, 50))
                {
                    error5txt.Visible = true;
                    throw new LengthException("Address is too long! Max lenght 50 characters");
                }
                else
                {
                    return true;
                }
            }
            catch (LengthException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //check customer requirements
        private bool CustomerRequirements()
        {
            clearerrors();
            bool error = false;
            string Message = "";
            if(Fnametxt.Text == "")
            {
                Message = "Missing Forename";
                Error1txt.Visible = true;
                error = true;
            }
            if(Snametxt.Text == "")
            {
                Message = "Missing Surname";
                error2txt.Visible = true;
                error = true;
            }
            if (teleNotxt.TextLength != 11)
            {
                Message = "Telephone Number is not 11 digits";
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
                        Message = "Telephone Number must on contain numbers";
                        break;
                    }
                }
            }
            string postcode = posttxt.Text.Replace(" ", String.Empty);
            if(postcode.Length > 8 || postcode.Length < 6)
            {
                error4txt.Visible = true;
                Message = "Postcode does not meet UK requirements";
                error = true;
            }
            if(addresstxt.Text == "")
            {
                Message = "Address is empty";
                error5txt.Visible = true;
                error = true;
            }
            if(KidsNo.Value < 1 || (KidsNo.Value % 1) != 0)
            {
                Message = "You must be booking at least one child";
                error6txt.Visible = true;
                error = true;
            }
            if (error)
            {
                try
                {
                    //custom expection
                    throw new RequirementsException(Message);
                }
                catch(RequirementsException e)
                {
                    MessageBox.Show(e.Message);
                }
                return false;
            }
            else
            {
                return true;
            }

        }

        private void clearerrors()
        {
            Error1txt.Visible = false;
            error2txt.Visible = false;
            error3txt.Visible = false;
            error4txt.Visible = false;
            error5txt.Visible = false;
            error6txt.Visible = false;
        }

        #endregion

        #region Child Booking
        //============== Child Booking ==============
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (childrequirements() && checkLength2())
            {
                //create a kid object
                child = new Kid();
                child.Forename = ChildFnametxt.Text;
                child.Surname = childSnametxt.Text;
                child.DOB = DOBpicker.Value.ToShortDateString();
                kids.Add(child);

                //add 1 to booked amount
                booked += 1;
                Kidslist.Items.Add(ChildFnametxt.Text + " " + childSnametxt.Text);
                btncheckout.Enabled = true;

                if (booked != Nokids) // if all kids havent been booked clear data
                {
                    OnNewkid();
                }

                //hide kid show booking
                book3pnl.Visible = false;
                book2pnl.Visible = false;
                populatemonthscbx(true);
                populateyearscbx();
                db.Conn.Close();
                db.connect();
                initaliseweeks(DateTime.Now);
                book6pnl.Visible = true;
            }
        }

        private bool checkLength2()
        {
            try
            {
                if (!MiscFunctions.insureValid(ChildFnametxt.Text.Length,30))
                {
                    throw new LengthException("Child Forename too long, Max lenght 30 characters");
                }
                else if (!MiscFunctions.insureValid(childSnametxt.Text.Length, 30))
                {
                    throw new LengthException("Child Surname too long, Max lenght 30 characters");
                }
                else
                {
                    return true;
                }
            }
            catch(LengthException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        private bool childrequirements()
        {
            bool error = false;
            string message = "";
            if(ChildFnametxt.Text == "")
            {
                message = "Missing Forename";
                Cerror1.Visible = true;
                error = true;
            }
            else if(childSnametxt.Text == "")
            {
                message = "Missing Surname";
                Cerror2.Visible = true;
                error = true;
            }
            else if(DOBpicker.Value > DateTime.Now.AddMonths(-6))
            {
                message = "DOB is invalid";
                error = true;
            }
            if (error)
            {
                try
                {
                    throw new RequirementsException(message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        //allow user to checkout with only one kid booked
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
            if(existingcustomer == null) //if no existing customer
            {
                book.Addcustomer(cust.Forename, cust.Surname, cust.TeleNo, cust.Postcode, cust.Address);
            }
            else
            {
                cust = existingcustomer;
            }

            if(existingkid !=null) // if existing kid
            {
                foreach(DateTime date in finishedbookings[0].Mondays)
                {
                    if (alreadybooked.Contains(date))
                    {
                        finishedbookings[0].Mondays.Remove(date);
                        book.UpdateDate(date, existingkid.Forename, existingkid.Surname);
                    }
                }
                book.AddDate(finishedbookings[0].Mondays, existingkid.Forename, existingkid.Surname); // add dates to db
                if(Dates2Remove.Count > 0)
                {
                    book.removeDate(Dates2Remove, existingkid.Forename, existingkid.Surname); //remove dates that have been unbooked 
                }
            }
            else //else add new kids/bookings
            {
                int i = 0;
                foreach(Kid child in kids)
                {
                    book.Addkid(child.Forename, child.Surname, child.DOB, cust.Forename,cust.Surname);
                    book.AddBooking(child.Forename, MiscFunctions.getgroupfromage(child.DOB), finishedbookings[i].Days[0], finishedbookings[i].Days[1], finishedbookings[i].Days[2], finishedbookings[i].Days[3], finishedbookings[i].Days[4], child.Surname);
                    book.AddDate(finishedbookings[i].Mondays, child.Forename, child.Surname);
                    if (Dates2Remove.Count > 0)
                    {
                        book.removeDate(Dates2Remove, child.Forename,child.Surname);
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

        //get check days for saving to the database
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
                FinalPrice.Text = "Total Price: £" + (currentprice * (1 - currentDiscount/100)).ToString("00.00");
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
        //populate days of the week for booking
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
        //get the mondays throughout the month and then check avaliability
        private void initaliseweeks(DateTime now)
        {
            extrapnl.Visible = false;
            book6pnl.Size = new Size(823, 424);
            DateTime startdate = new DateTime(now.Year, now.Month, 1);
            DateTime enddate = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
            mondays = new List<int>();
            fridays = new List<int>();
            for (DateTime date = startdate; date <= enddate; date = date.AddDays(1)) //grab mondays in the months through a loop
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

            for (int x = 0; x <= mondays.Count-1; x++) // create a string in format week (number) start date - end date
            {
                string day1 = "";
                string day2 = "";

                if(x == fridays.Count)
                {
                    if(x == mondays.Count)
                    {
                        day1 = MiscFunctions.AddOrdinal(mondays[x - 1]);
                    }
                    else
                    {
                        day1 = MiscFunctions.AddOrdinal(mondays[x]);
                    }
                    day2 = "Next Month";
                    extrapnl.Visible = true;
                    book6pnl.Size = new Size(823, 493);
                }
                else if (mondays[x] > fridays[x])
                {
                    day1 = MiscFunctions.AddOrdinal(mondays[x]);
                    if (x == fridays.Count - 1)
                    {
                        day2 = "Next Month";
                    }
                    else
                    {
                        day2 = MiscFunctions.AddOrdinal(fridays[x + 1]);
                    }
                }
                else
                {
                    day1 = MiscFunctions.AddOrdinal(mondays[x]);
                    day2 = MiscFunctions.AddOrdinal(fridays[x]);
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
            int currentMonth = months.IndexOf(monthscbx.Text) + 1;
            oldDate = new List<bool>();
            understaffed = new List<bool>();
            for (int i = 0; i<= mondays.Count-1; i++)
            {
                DateTime current = new DateTime(Convert.ToInt32(yearcbx.Text), currentMonth, mondays[i]);
                bool Currentoverbooked = false;
                if (!alreadybooked.Contains(current)) //overbook check
                    Currentoverbooked = MiscFunctions.CheckAvalability(current, db, DOB, kids,finishedbookings);
                overbooked.Add(Currentoverbooked);

                if (current > DateTime.Now) // dont allow old dates to be bookable
                    oldDate.Add(false);
                else
                    oldDate.Add(true);

                bool missingstaff = MiscFunctions.checkStaffAvaliability(db, DOB);// missing staff check
                understaffed.Add(missingstaff);
                if ((bookeddates.Contains(current) || (alreadybooked.Contains(current) && !Dates2Remove.Contains(current))) && !Currentoverbooked && current > DateTime.Now && !missingstaff)
                {
                    btnbooks.Add(true);
                }
                else
                {
                    btnbooks.Add(false);
                }
            }
            List<Button> bookingbuttons = new List<Button>() { week1btn, week2btn, week3btn, week4btn };
            if(mondays.Count-1 == 4) // if there is 5 weeks in the months and into next month then create a 5th button
            {
                bookingbuttons.Add(week5btn);
            }
            int y = 0;
            foreach(Button b in bookingbuttons) //populate booking buttons for a month
            {
                buttons(b, y);
                y++;
            }
        }
        //populate the month combobox with the months in that year that are not before todays month
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
                //DateTime now = DateTime.Now;
                //DateTime startdate = new DateTime(now.Year, now.Month, 1);
                //DateTime enddate = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
                //int counter = 0;
                //for (DateTime date = startdate; date <= enddate; date = date.AddDays(1)) //grab mondays in the months through a loop
                //{
                //    if (date.DayOfWeek == DayOfWeek.Monday && date > now)
                //    {
                //        counter++;
                //    }
                //}
                //if (counter == 0)
                //{
                //    monthscbx.Items.RemoveAt(0);
                //}
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
        //populate 5 years ahead as bookable range
        private void populateyearscbx()
        {
            yearcbx.Items.Clear();
            for (int i = 0; i < 5; i++)//easy range change here
            {
                yearcbx.Items.Add(DateTime.Now.Year+i);
            }
            yearcbx.SelectedIndex = 0;
        }

        #region Buttons
        //set addition button text, enable state and color depending on avaliablity of the week
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
                if (oldDate[index])
                {
                    current.BackColor = Color.FromArgb(64, 64, 64);
                    current.Enabled = false;
                }
                else if(understaffed[index])
                {
                    current.BackColor = Color.FromArgb(255, 128, 128);
                    current.Text = current.Text + " [No staff avaliable]";
                    current.Enabled = false;
                }
                else if (overbooked[index])
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
        // on the button click event add/remove the date depending on the state
        // add/remove addtion costs for added weeks
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
                    btnfinished.Enabled = true;
                    Dates2Remove.Add(selecteddate);
                }
                calculatePrice(selecteddate, true);
                current.BackColor = Color.Silver;
                current.Text = current.Text.Remove(current.Text.Length - 9);
                btnbooks[index] = false;
                if(bookeddates.Count<1 && Dates2Remove.Count<1)
                    btnfinished.Enabled = false;
            }

            totalpricelbl.Text = "Total Price: £" + (currentprice * (1 - currentDiscount/100)).ToString("00.00");
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
                int x = months.IndexOf(monthscbx.Text);
                initaliseweeks(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year, x+1, 1));
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
                x = months.IndexOf(monthscbx.Text);
                initaliseweeks(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year + 0, x+1, DateTime.Now.Day));
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
        //calculate price and apply the discount depending how far in the future the booking is made for
        private void calculatePrice(DateTime bookeddate,bool remove)
        {
            PricesDB pdb = new PricesDB(db);
            int baserate = pdb.getBase();
            if (remove) // check if we should remove the applied discount and remove base price
            {
                if (bookeddate > DateTime.Now.AddMonths(3) && bookeddate < DateTime.Now.AddMonths(6) && currentDiscount != 5)
                {
                    bool keep = false;
                    foreach(DateTime date in bookeddates) //check for other dates that are within the discount range
                    {
                        if(date > DateTime.Now.AddMonths(3) && date < DateTime.Now.AddMonths(6))
                        {
                            keep = true;
                        }
                    }
                    if (!keep)
                    {
                        currentDiscount = pdb.getMinDiscount();
                    }
                }
                else if (bookeddate >= DateTime.Now.AddMonths(6))
                {
                    bool keep = false;
                    foreach (DateTime date in bookeddates) //check for other dates that are within the discount range
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
                            currentDiscount = pdb.getMinDiscount();
                        }
                        else
                        {
                            pdb.getMedDiscount();
                        }
                    }
                }
                currentprice -= baserate;
            }
            else
            {
                if (bookeddate > DateTime.Now.AddMonths(3) && bookeddate < DateTime.Now.AddMonths(6) && currentDiscount != 5)
                {
                    currentDiscount = pdb.getMedDiscount(); //medium discount applied
                }
                else if (bookeddate >= DateTime.Now.AddMonths(6))
                {
                    currentDiscount = pdb.getMaxDiscount(); //max discount applied
                }
                else
                {
                    currentDiscount = pdb.getMinDiscount(); //min discount applied
                }
                currentprice += baserate;
            }
            totalpricelbl.Visible = true;
            totalpricelbl.Text = "Total Price: £" + (currentprice * (1 - currentDiscount / 100) ).ToString("00.00");//calculate cost and display on a label
        }

        #region otherrequirements
        //on text change even check for requirement errors
        private void Fnametxt_TextChanged(object sender, EventArgs e)
        {
            if (Fnametxt.Text.Length > 25)
            {
                try
                {
                    throw new RequirementsException("Forename length has reached the max!");
                }
                catch (RequirementsException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            foreach (char c in Fnametxt.Text)
            {
                if (char.IsDigit(c))
                {
                    try
                    {
                        throw new RequirementsException("Forename should not contain numbers!");
                    }
                    catch (RequirementsException ex)
                    {
                        MessageBox.Show(ex.Message);
                        Fnametxt.Text = "";
                    }
                    break;
                }
            }
        }
        //on text change even check for requirement errors
        private void Snametxt_TextChanged(object sender, EventArgs e)
        {

            if (Snametxt.Text.Length > 25)
            {
                try
                {
                    throw new RequirementsException("Surname length has reached the max!");
                }
                catch (RequirementsException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            foreach (char c in Snametxt.Text)
            {
                if (char.IsDigit(c))
                {
                    try
                    {
                        throw new RequirementsException("Surname should not contain numbers!");
                    }
                    catch (RequirementsException ex)
                    {
                        MessageBox.Show(ex.Message);
                        Snametxt.Text = "";
                    }
                    break;
                }
            }
        }

        //on text change even check for requirement errors
        private void teleNotxt_TextChanged(object sender, EventArgs e)
        {
            if (teleNotxt.Text.Length > 11)
            {
                try
                {
                    throw new RequirementsException("Telephone number should only be 11 numbers!");
                }
                catch (RequirementsException ex)
                {
                    MessageBox.Show(ex.Message);
                    teleNotxt.Text = teleNotxt.Text.Remove(11);
                }
            }
        }

        #endregion otherrequirements
        //open staff window but keep this window open
        private void btnstaff_Click(object sender, EventArgs e)
        {
            AddEditStaff staff = new AddEditStaff();
            staff.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            int x = months.IndexOf(monthscbx.Text);
            initaliseweeks(new DateTime(yearcbx.SelectedIndex + DateTime.Now.Year + 0, x + 1, DateTime.Now.Day));
        }
    }
}
