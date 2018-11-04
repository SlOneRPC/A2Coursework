using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2CourseWork.Objects;
using A2CourseWork.Classes;
namespace A2CourseWork.Gui
{
    public partial class AddEditStaff : Form
    {
        Database db;
        List<StaffMember> staff = new List<StaffMember>();
        string mode;

        public AddEditStaff()
        {
            InitializeComponent();
            db = new Database();
            if (!db.connect())
            {
                MessageBox.Show("Error - Connection falied!");
            }
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

        private void AddEditStaff_Load(object sender, EventArgs e)
        {
            initcombo();
            Timer.Start();
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            MiscFunctions misc = new MiscFunctions();
            misc.buttonhover(this);
        }

        private void initcombo()
        {
            stafflist.Items.Clear();
            StaffDB staffdb = new StaffDB(db);
            staff = staffdb.getallstaff();
            if(staff.Count == 0)
            {
                btnadd.Visible = false;
                mode = "add";
                enableTextboxes();
            }
            else
            {
                if (!btnadd.Visible && staff.Count > 0)
                {
                    btnadd.Visible = true;
                }
                foreach (StaffMember member in staff)
                {
                    stafflist.Items.Add(member.Forename + " " + member.Surname);
                }
                stafflist.SelectedIndex = 0;
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            List<StaffMember> updatedstaff = new List<StaffMember>();
            foreach(StaffMember member in staff)
            {
                if ((member.Forename.ToLower().Trim() + " " + member.Surname.ToLower().Trim()).Contains(searchtxt.Text.ToLower().Trim())) 
                {
                    updatedstaff.Add(member);
                }
            }
            stafflist.Items.Clear();
            foreach(StaffMember member in updatedstaff)
            {
                stafflist.Items.Add(member.Forename + " " + member.Surname);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "add":
                    doadd();
                    break;
                case "edit":
                    doedit();
                    break;
                case "edit1":
                    startedit();
                    break;
                    
            }
        }

        private void startedit()
        {
            fnametxt.Enabled = true;
            Surnametxt.Enabled = true;
            TeleNotxt.Enabled = true;
            Addresstxt.Enabled = true;
            Postcodetxt.Enabled = true;
            btnupdate.Text = "Save";
            mode = "edit";
            btncancel.Visible = true;
        }

        private void doadd()
        {
            if (performchecks())
            {
                StaffDB staffdb = new StaffDB(db);
                staffdb.addstaffmember(fnametxt.Text, Surnametxt.Text, TeleNotxt.Text, Postcodetxt.Text, Addresstxt.Text);
                messagelbl.Text = "Success!";
                messagelbl.Visible = true;
                DialogResult dialogResult = MessageBox.Show("Would you like to add another staff member?", "Adding staff", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    resetTextboxes();
                }
                else
                {
                    mode = "edit1";
                    enableTextboxes();
                    btnadd.Visible = true;
                    btncancel.Visible = false;
                }
                initcombo();
            }
        }

        private void doedit()
        {
            if (performchecks())
            {
                StaffDB staffdb = new StaffDB(db);
                staffdb.updatestaffmember(staff[stafflist.SelectedIndex].Forename,fnametxt.Text,Surnametxt.Text,TeleNotxt.Text,Postcodetxt.Text,Addresstxt.Text);
                initcombo();
                messagelbl.Text = "Edit complete";
                messagelbl.Visible = true;
                mode = "edit1";
                btncancel.Visible = false;
            }
        }

        private void enableTextboxes()
        {
            if (fnametxt.Enabled)
            {
                fnametxt.Enabled = false;
                Surnametxt.Enabled = false;
                TeleNotxt.Enabled = false;
                Addresstxt.Enabled = false;
                Postcodetxt.Enabled = false;
            }
            else
            {
                fnametxt.Enabled = true;
                Surnametxt.Enabled = true;
                TeleNotxt.Enabled = true;
                Addresstxt.Enabled = true;
                Postcodetxt.Enabled = true;
            }
        }

        private void resetTextboxes()
        {
            fnametxt.Clear();
            Surnametxt.Clear();
            TeleNotxt.Clear();
            Postcodetxt.Clear();
            Addresstxt.Clear();
        }
        private bool performchecks()
        {
            bool error = false;
            if(fnametxt.Text == "")
            {
                error1.Visible = true;
                error = true;
            }
            if(Surnametxt.Text == "")
            {
                error2.Visible = true;
                error = true;
            }
            if(TeleNotxt.TextLength != 11)
            {
                error3.Visible = true;
                error = true;
            }
            else
            {
                foreach (char c in TeleNotxt.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        error3.Visible = true;
                        error = true;
                        MessageBox.Show("Telephone number must only contain numbers!");
                        break;
                    }
                }
            }
            if(Addresstxt.Text == "")
            {
                error4.Visible = true;
                error = true;
            }
            string postcode = Postcodetxt.Text.Replace(" ", String.Empty);
            if (postcode.Length != 7)
            {
                error5.Visible = true;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnupdate.Text = "Add";
            enableTextboxes();
            resetTextboxes();
            btnadd.Visible = false;
            btncancel.Visible = true;
        }

        private void stafflist_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = "edit1";
            fnametxt.Text = staff[stafflist.SelectedIndex].Forename;
            Surnametxt.Text = staff[stafflist.SelectedIndex].Surname;
            TeleNotxt.Text = staff[stafflist.SelectedIndex].TeleNo;
            Addresstxt.Text = staff[stafflist.SelectedIndex].Address;
            Postcodetxt.Text = staff[stafflist.SelectedIndex].Postcode;
            btnupdate.Text = "Edit";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu form = new CrecheMenu();
            form.Show();
            this.Hide();
        }

        int x = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (messagelbl.Visible)
            {
                if(x == 50)
                {
                    messagelbl.Visible = false;
                    x = 0;
                }
                x++;
            }
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = stafflist.SelectedIndex;
                enableTextboxes();
                initcombo();
                btncancel.Visible = false;
                stafflist.SelectedIndex = index;
            }
        }
    }
}
