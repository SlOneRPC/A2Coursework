using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CourseWork.Gui
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.panel3.AutoScroll = true;
            btncreche.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void btncreche_Click(object sender, EventArgs e)
        {

        }

        private void crechepbx_MouseHover(object sender, EventArgs e)
        {
            crechelbl.Visible = true;
        }

        private void transportpbx_MouseHover(object sender, EventArgs e)
        {
            transportlbl.Visible = true;
        }

        private void advicepbx_MouseHover(object sender, EventArgs e)
        {
            advicelbl.Visible = true;
        }

        private void grouppbx_MouseHover(object sender, EventArgs e)
        {
            grouplbl.Visible = true;
        }

        private void classespbx_MouseHover(object sender, EventArgs e)
        {
            classeslbl.Visible = true;
        }

        private void crechepbx_MouseLeave(object sender, EventArgs e)
        {
            crechelbl.Visible = false;
        }

        private void transportpbx_MouseLeave(object sender, EventArgs e)
        {
            transportlbl.Visible = false;
        }

        private void advicepbx_MouseLeave(object sender, EventArgs e)
        {
            advicelbl.Visible = false;
        }

        private void grouppbx_MouseLeave(object sender, EventArgs e)
        {
            grouplbl.Visible = false;
        }

        private void classespbx_MouseLeave(object sender, EventArgs e)
        {
            classeslbl.Visible = false;
        }
    }
}
