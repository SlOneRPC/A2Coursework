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
    public partial class ViewBookings : Form
    {
        Database db;
        List<Kid> kids = new List<Kid>();

        public ViewBookings()
        {
            db = new Database();
            InitializeComponent();
            db.connect();
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
            CrecheMenu menu = new CrecheMenu();
            this.Hide();
            menu.Show();
        }

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

        private void btncheck_Click(object sender, EventArgs e)
        {
            bookingpnl1.Visible = false;
            bookingpnl2.Visible = true;
            fnamelbl.Text = "Forename: " + kids[kidslistbox.SelectedIndex].Forename;
            snamelbl.Text = "Surname: " + kids[kidslistbox.SelectedIndex].Surname;
            doblbl.Text = "DOB: " + kids[kidslistbox.SelectedIndex].DOB;
        }
    }
}
