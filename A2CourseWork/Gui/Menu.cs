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
            MiscFunctions misc = new MiscFunctions();
            misc.exit();
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
            CrecheMenu main = new CrecheMenu();
            this.Hide();
            main.Show();
        }

        private void crechepbx_Click(object sender, EventArgs e)
        {
            CrecheMenu main = new CrecheMenu();
            this.Hide();
            main.Show();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            sidepnl.Size = new Size(199, 569);
        }

        private void Mainpnl_MouseEnter(object sender, EventArgs e)
        {
            sidepnl.Size = new Size(91, 569);
        }

        private void MainImage_MouseEnter(object sender, EventArgs e)
        {
            sidepnl.Size = new Size(91, 569);
        }

        private void crechepbx_MouseHover(object sender, EventArgs e)
        {
            crechepbx.BackColor = Color.Gray;
        }

        private void transportpbx_MouseHover(object sender, EventArgs e)
        {
            transportpbx.BackColor = Color.Gray;
        }

        private void advicepbx_MouseHover(object sender, EventArgs e)
        {
            advicepbx.BackColor = Color.Gray;
        }

        private void grouppbx_MouseHover(object sender, EventArgs e)
        {
            grouppbx.BackColor = Color.Gray;
        }

        private void classespbx_MouseHover(object sender, EventArgs e)
        {
            classespbx.BackColor = Color.Gray;
        }

        private void crechepbx_MouseLeave(object sender, EventArgs e)
        {
            crechepbx.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void transportpbx_MouseLeave(object sender, EventArgs e)
        {
            transportpbx.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void advicepbx_MouseLeave(object sender, EventArgs e)
        {
            advicepbx.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void grouppbx_MouseLeave(object sender, EventArgs e)
        {
            grouppbx.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void classespbx_MouseLeave(object sender, EventArgs e)
        {
            classespbx.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void crechepbx_Click_1(object sender, EventArgs e)
        {
            CrecheMenu main = new CrecheMenu();
            this.Hide();
            main.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MiscFunctions misc = new MiscFunctions();
            misc.buttonhover(this);
        }
    }
}
