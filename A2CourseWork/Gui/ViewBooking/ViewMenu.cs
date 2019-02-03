using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CourseWork.Gui.ViewBooking
{
    public partial class ViewMenu : Default
    {
        public ViewMenu()
        {
            InitializeComponent();
            panel2.BringToFront();
        }

        private void btndate_Click(object sender, EventArgs e)
        {
            ByDate date = new ByDate();
            this.Hide();
            date.Show();
        }

        private void btnchild_Click(object sender, EventArgs e)
        {
            ViewBookings child = new ViewBookings();
            this.Hide();
            child.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu menu = new CrecheMenu();
            this.Hide();
            menu.Show();
        }
    }
}
