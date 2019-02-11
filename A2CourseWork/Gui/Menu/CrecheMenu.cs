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
using A2CourseWork.Gui.ViewBooking;
namespace A2CourseWork.Gui
{
    public partial class CrecheMenu : Default
    {
        public CrecheMenu()
        {
            InitializeComponent();
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

        private void homepbx_Click(object sender, EventArgs e)
        {
            Menu main = new Gui.Menu();
            this.Hide();
            main.Show();
        }

        private void CrecheMenu_Load(object sender, EventArgs e)
        {
            Timer.Start();
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            MiscFunctions.buttonhover(this);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            BookingMenu form = new BookingMenu();
            this.Hide();
            form.Show();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            AddEditStaff form = new AddEditStaff();
            this.Hide();
            form.Show();
        }

        private void btnbookingsview_Click(object sender, EventArgs e)
        {
            ViewMenu form = new ViewMenu();
            this.Hide();
            form.Show();
        }

        private void btnbydate_Click(object sender, EventArgs e)
        {
            Prices menu = new Prices();
            this.Hide();
            menu.Show();
        }

        private void btnwaiting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is not a section i plan to add");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupsbtn_Click(object sender, EventArgs e)
        {
            Groups gmenu = new Groups();
            gmenu.Show();
            this.Hide();
        }
    }
}
