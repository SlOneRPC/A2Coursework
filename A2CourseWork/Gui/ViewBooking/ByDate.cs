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
    public partial class ByDate : Default
    {
        List<int> mondays = new List<int>();
        List<int> fridays = new List<int>();
        List<string> months = new List<string>() { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public ByDate()
        {
            InitializeComponent();
            titlelbl.Text = "Woodside Community - creche - View";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //if()
        }


        private void populateyearscbx()
        {
            yearcbx.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                yearcbx.Items.Add(DateTime.Now.Year + i);
            }
            yearcbx.SelectedIndex = 0;
        }

        private void populatemonthscbx(bool currentyear)
        {
            monthscbx.Items.Clear();
            if (currentyear)
            {
                for (int i = DateTime.Now.Month - 1; i < 12; i++)
                {
                    //if(bookeddays.Contains(mondays[i]))
                    monthscbx.Items.Add(months[i]);
                }
                monthscbx.SelectedIndex = 0;
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    monthscbx.Items.Add(months[i]);
                }
                monthscbx.SelectedIndex = 0;
            }
        }

        private void populateweekbtns(DateTime now)
        {
            DateTime startdate = new DateTime(now.Year, now.Month, 1);
            DateTime enddate = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
            mondays = new List<int>();
            fridays = new List<int>();
            for (DateTime date = startdate; date <= enddate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    mondays.Add(date.Day);
                }
            }
            //if()
        }

        private void yearcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthscbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ByDate_Load(object sender, EventArgs e)
        {
            populateyearscbx();
            if (DateTime.Now.Year.ToString() == yearcbx.Text)
            {
                populatemonthscbx(true);
            }
            else
            {
                populatemonthscbx(false);
            }
            populateweekbtns(DateTime.Now);
        }
    }
}
