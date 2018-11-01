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
namespace A2CourseWork.Gui
{
    public partial class Booking : Form
    {
        Database db;
        decimal Nokids;
        string parentForeName;
        int booked=0;

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
            Menu home = new Menu();
            this.Hide();
            home.Show();
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
            BookingDB book = new BookingDB(db);
            book.Addcustomer(Fnametxt.Text, Snametxt.Text, teleNotxt.Text, posttxt.Text);
            parentForeName = Fnametxt.Text;
            book1pnl.Visible = false;
            book2pnl.Visible = true;
            book3pnl.Visible = true;
            Nokids = KidsNo.Value;
            if (booked == Nokids - 1)
            {
                btnnext.Text = "Add";
            }
            btncheckout.Enabled = false;
        }

        private void OnNewkid()
        {
            ChildFnametxt.Text = "";
            childSnametxt.Text = "";
            DOBpicker.ResetText();
            KidsBookedlbl.Text = "Number of Kids Booked: " + booked.ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if(booked == 1)
            {
                btncheckout.Enabled = true;
            }
            BookingDB book = new BookingDB(db);
            book.Addkid(ChildFnametxt.Text,childSnametxt.Text,DOBpicker.Value.Date.ToString(),parentForeName);
            booked += 1;
            Kidslist.Items.Add(ChildFnametxt.Text);
            if(booked == Nokids)
            {
                book2pnl.Visible = false;
                book3pnl.Location = new Point(408, 65);
            }
            if(booked != Nokids)
            {
                OnNewkid();
            }
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            if(booked != Nokids)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to checkout without booking all kids?", "Booking", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Booking completed");
                    Menu next = new Gui.Menu();
                    this.Hide();
                    next.Show();
                }
            }
            else
            {
                MessageBox.Show("Booking completed");
                Menu next = new Gui.Menu();
                this.Hide();
                next.Show();
            }
        }
    }
}
