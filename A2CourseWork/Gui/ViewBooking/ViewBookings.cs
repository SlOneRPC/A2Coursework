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
using A2CourseWork.Gui.ViewBooking;
namespace A2CourseWork.Gui
{
    public partial class ViewBookings : Default
    {
        Database db;
        List<Kid> kids = new List<Kid>();

        public ViewBookings()
        {
            db = new Database();
            InitializeComponent();
            db.connect();
            titlelbl.Text = "Woodside Community - Creche - Bookings";
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            initlistbox();
        }
        //exit button
        private void btnexit_Click(object sender, EventArgs e)
        {
            MiscFunctions.exit();
        }
        //minimize button
        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Dragable panel
        System.Drawing.Point lastclick;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ViewMenu menu = new ViewMenu();
            this.Hide();
            menu.Show();
        }
        //update the listbox with the kids
        private void initlistbox()
        {
            KidsDB kidsdbaccess = new KidsDB(db);
            kids = kidsdbaccess.getallkids();
            foreach(Kid child in kids)
            {
                kidslistbox.Items.Add(child.Forename + " " + child.Surname);
            }
            if(kids.Count > 0)
            {
                kidslistbox.SelectedIndex = 0;
            }
            else
            {
                btncheck.Enabled = false;
            }
        }
        //once the kid is selected setup the view
        private void btncheck_Click(object sender, EventArgs e)
        {
            bookingpnl1.Visible = false;
            bookingpnl2.Visible = true;
            fnamelbl.Text = "Forename: " + kids[kidslistbox.SelectedIndex].Forename;
            snamelbl.Text = "Surname: " + kids[kidslistbox.SelectedIndex].Surname;
            doblbl.Text = "DOB: " + kids[kidslistbox.SelectedIndex].DOB;
            agelbl.Text = "Age: " + calculateAge() + " months old";
            agegrouplbl.Text = "Age Group Name: " + MiscFunctions.getgroupfromage(kids[kidslistbox.SelectedIndex].DOB);

            //gather bookings
            List<custBooking> bookings = new List<custBooking>();
            BookingDB booking = new BookingDB(db);
            bookings = booking.getallbookingsforkid(kids[kidslistbox.SelectedIndex].Forename);
            populateDates();
        }
        //populate the dates that the kid has booked
        private void populateDates()
        {
            List<DateTime> dates = new List<DateTime>();
            MiscDB miscdb = new MiscDB(db);
            dates = miscdb.BookingWeeksFromKid(kids[kidslistbox.SelectedIndex].Forename);

            bookinglistbox.Items.Clear();
            foreach (DateTime date in dates)
            {
                bookinglistbox.Items.Add(date.ToShortDateString());
            }
            daysbookedlbl.Text = "Days Booked: " + dates.Count.ToString();
            setPrice(dates);
        }
        //calculate the childs age in months
        private string calculateAge()
        {
            int months = DateTime.Now.Month - Convert.ToDateTime(kids[kidslistbox.SelectedIndex].DOB).Month;
            int years = DateTime.Now.Year - Convert.ToDateTime(kids[kidslistbox.SelectedIndex].DOB).Year;
            if (months < 0)
            {
                years--;
                months += 12;
            }
            if (years > 0)
            {
                months += (years * 12);
            }
            return Convert.ToString(months);
        }
        //calculate the price to pay including discounts
        private void setPrice(List<DateTime> dates)
        {
            double discount = 0;
            string discountApplied = "";
            PricesDB pdb = new PricesDB(db);
            foreach(DateTime date in dates)
            {
                if (date >= DateTime.Now.AddMonths(6))
                {
                    discount = pdb.getMaxDiscount();
                    discountApplied = "5%";
                }
                else if(date > DateTime.Now.AddMonths(3) && date < DateTime.Now.AddMonths(6))
                {
                    discount = pdb.getMedDiscount();
                    discountApplied = "3%";
                }
            }
            if(discount == 0)
            {
                discountlbl.Text = "Discount Applied: None";
            }
            else
            {
                discountlbl.Text = "Discount Applied: " + discountApplied;
            }
            double price = (pdb.getBase() * dates.Count) * (1-discount);
            totalpricelbl.Text = "Total Price: £" + price.ToString();
        }
        //open add from and pass the child and parent object
        private void btnadd_Click(object sender, EventArgs e)
        {
            CustomerDB custdb = new CustomerDB(db);
            Customer cust = custdb.getSpecificCustomer(kids[kidslistbox.SelectedIndex].Forename);
            KidsDB kiddb = new KidsDB(db);
            Kid child = kiddb.getSpecificKid(kids[kidslistbox.SelectedIndex].Forename);

            Booking book = new Booking(cust, child);
            book.Show();
            this.Hide();
        }
        //remove the selected booking
        private void btndelete_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(bookinglistbox.Text);
            List<DateTime> dates = new List<DateTime>();
            dates.Add(date);
            BookingDB bdb = new BookingDB(db);
            bdb.removeDate(dates, kids[kidslistbox.SelectedIndex].Forename);
            MessageBox.Show("Sucess");
            populateDates();
        }
    }
}
