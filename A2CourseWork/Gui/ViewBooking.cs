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
    public partial class ViewBooking : Form
    {
        Database db;
        List<Kid> kids = new List<Kid>();
        Kid booking = new Kid();
        public ViewBooking()
        {
            db = new Database();
            InitializeComponent();
            db.connect();
            initlistbox();
        }
        //exit button
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void initlistbox()
        {
            KidsDB kiddb = new KidsDB(db);
            kids=kiddb.getallkids();
            foreach(Kid child in kids)
            {
                kidslist.Items.Add(child.Forename + " " + child.Surname);
            }
            if(kids.Count > 0)
            {
                kidslist.SelectedIndex = 0;
            }
            else
            {
                btnview.Enabled = false;
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            booking1pnl.Visible = false;
            booking = kids[kidslist.SelectedIndex];
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu menu = new CrecheMenu();
            this.Hide();
            menu.Show();
        }
    }
}
