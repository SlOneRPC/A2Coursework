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
    public partial class BookingMenu : Default
    {
        Database db;
        List<Kid> kids = new List<Kid>();
        List<Customer> customers = new List<Customer>();
        Customer currentcustomer = new Customer();
        bool NoBookings = false;
        public BookingMenu()
        {
            InitializeComponent();
            db = new Database();
            db.connect();
            bookpnl1.Visible = true;
            bookpnl2.Visible = true;
        }

        private void BookingMenu_Load(object sender, EventArgs e)
        {
            this.titlelbl.Text = "Woodside Community - Creche - Booking Menu";
            panel2.BringToFront();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (!customercheck.Checked)
            {
                subtitlelbl.Text = "Please select kid";
                initlistbox(true);
            }
            else
            {
                initlistbox(false);
            }
            if (!NoBookings)
            {
                bookpnl1.Visible = false;
                bookpnl2.Visible = false;
                bookpnl3.Visible = true;
            }
        }

        private void initlistbox(bool kid)
        {

            if (kid)
            {
                KidsDB kidsdbaccess = new KidsDB(db);
                kids = kidsdbaccess.getallkids();
                containerlistbox.Items.Clear();
                foreach (Kid child in kids)
                {
                    if(child.ParentID == currentcustomer.CustId)
                    {
                        containerlistbox.Items.Add(child.Forename + " " + child.Surname);
                    }
                }
                if (kids.Count > 0)
                {
                    containerlistbox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No kids yet!");
                    returntomenu(); 
                }
            }
            else
            {
                CustomerDB customerdb = new CustomerDB(db);
                customers=customerdb.getallcustomers();
                containerlistbox.Items.Clear();
                foreach (Customer customer in customers)
                {
                    containerlistbox.Items.Add(customer.Forename + " " + customer.Surname);
                }
                if (customers.Count > 0)
                {
                    containerlistbox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No customers yet!");
                    NoBookings = true;
                }
            }
           
        }
        int x = 0;
        private void btnselect_Click(object sender, EventArgs e)
        {
            if (customercheck.Checked && x==0)
            {
                currentcustomer = customers[containerlistbox.SelectedIndex];
                if (kidcheck.Checked)
                {
                    initlistbox(true);
                }
                else
                {
                    Booking book = new Booking(currentcustomer, null);
                    book.Show();
                    this.Hide();
                }
                x++;
            }
            else
            {
                Kid kid = new Kid();
                foreach(Kid child in kids)
                {
                    if(child.Forename + " " + child.Surname == containerlistbox.Text)
                    {
                        kid = child;
                    }
                }
                Booking book = new Booking(currentcustomer, kid);
                book.Show();
                this.Hide();
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Booking book = new Booking(null, null);
            book.Show();
            this.Hide();
        }

        private void returntomenu()
        {
            CrecheMenu menu = new CrecheMenu();
            menu.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu menu = new CrecheMenu();
            menu.Show();
            this.Hide();
        }
    }
}
