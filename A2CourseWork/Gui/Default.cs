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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            this.panel2.BringToFront();
        }
   
        //exit button
        private void btnexit_Click_1(object sender, EventArgs e)
        {
            MiscFunctions.exit();
        }
        //minimize button
        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        //Dragable panel
        System.Drawing.Point lastclick;

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastclick.X;
                this.Top += e.Y - lastclick.Y;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Size = new Size(91, 569);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            booksidebtn.BackColor = Color.Gray;
        }

        private void booksidebtn_MouseLeave(object sender, EventArgs e)
        {
            booksidebtn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void viewsidebtn_MouseHover(object sender, EventArgs e)
        {
            viewsidebtn.BackColor = Color.Gray;
        }

        private void viewsidebtn_MouseLeave(object sender, EventArgs e)
        {
            viewsidebtn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void staffsidebtn_MouseHover(object sender, EventArgs e)
        {
            staffsidebtn.BackColor = Color.Gray;
        }

        private void staffsidebtn_MouseLeave(object sender, EventArgs e)
        {
            staffsidebtn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void booksidebtn_Click(object sender, EventArgs e)
        {
            BookingMenu menu = new BookingMenu();
            this.Hide();
            menu.Show();
        }

        private void viewsidebtn_Click(object sender, EventArgs e)
        {
            ViewBooking.ViewMenu menu = new ViewBooking.ViewMenu();
            this.Hide();
            menu.Show();
        }

        private void staffsidebtn_Click(object sender, EventArgs e)
        {
            AddEditStaff staffmenu = new AddEditStaff();
            this.Hide();
            staffmenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Gui.Menu menu = new Gui.Menu();
            this.Hide();
            menu.Show();
        }

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            pricesbtn.BackColor = Color.Gray;
        }

        private void pricesbtn_MouseLeave(object sender, EventArgs e)
        {
            pricesbtn.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Size = new Size(91, 569);
        }

        private void waitinglistbtn_MouseHover(object sender, EventArgs e)
        {
            waitinglistbtn.BackColor = Color.Gray;
        }

        private void waitinglistbtn_MouseLeave(object sender, EventArgs e)
        {
            waitinglistbtn.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Size = new Size(91, 569);
        }

        private void pricesbtn_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void waitinglistbtn_MouseEnter(object sender, EventArgs e)
        {
            panel2.Size = new Size(312, 569);
        }

        private void honebtn_MouseHover(object sender, EventArgs e)
        {
            honebtn.BackColor = Color.Gray;
        }

        private void honebtn_MouseLeave(object sender, EventArgs e)
        {
            honebtn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pricesbtn_Click(object sender, EventArgs e)
        {
            Prices p = new Prices();
            this.Hide();
            p.Show();
        }

        private void waitinglistbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is not something i plan to add");
        }
    }
}
