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

        public Booking()
        {
            db = new Database();
            InitializeComponent();
            db.connect();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                //old method
                //BookingDB book = new BookingDB(db);
                //book.Addcustomer(Fnametxt.Text, Snametxt.Text, teleNotxt.Text, posttxt.Text.Replace(" ", String.Empty));

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

                Nokids = KidsNo.Value;
                if (booked == Nokids - 1)
                {
                    btnnext.Text = "Add";
                }
                btncheckout.Enabled = false;
                DOBpicker.MaxDate = DateTime.Now.Date;
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
            if(postcode.Length != 7)
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
                //(old method)
                //BookingDB book = new BookingDB(db);
                //book.Addkid(ChildFnametxt.Text, childSnametxt.Text, DOBpicker.Value.ToShortDateString(), parentForeName);

                //create a kid object (New method)
                Kid child = new Kid();
                child.Forename = ChildFnametxt.Text;
                child.Surname = childSnametxt.Text;
                child.DOB = DOBpicker.Value.ToShortDateString();
                kids.Add(child);

                booked += 1;
                Kidslist.Items.Add(ChildFnametxt.Text + " " + childSnametxt.Text);
                btncheckout.Enabled = true;
                if (booked == Nokids)
                {
                    KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
                    book2pnl.Visible = false;
                    book3pnl.Location = new Point(408, 65);
                }
                if (booked != Nokids)
                {
                    OnNewkid();
                }
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
            foreach (Kid child in kids)
            {
                book.Addkid(child.Forename, child.Surname, child.DOB, cust.Forename);
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
            MiscFunctions misc = new MiscFunctions();
            misc.buttonhover(this);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Booking will be lost?", "Leave Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrecheMenu form = new CrecheMenu();
                form.Show();
                this.Hide();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Booking will be lost?", "Leave Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrecheMenu form = new CrecheMenu();
                form.Show();
                this.Hide();
            }
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure, Booking will be lost?", "Leave Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CrecheMenu form = new CrecheMenu();
                form.Show();
                this.Hide();
            }
        }
    }
}
