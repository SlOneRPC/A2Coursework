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
using A2CourseWork.CustExpections;
namespace A2CourseWork.Gui
{
    public partial class AddEditStaff : Default
    {
        Database db;
        List<StaffMember> staff = new List<StaffMember>();
        int staffGroup = 0;
        string mode;
        bool stilladding = false;
        StaffMember current = new StaffMember();

        public AddEditStaff()
        {
            InitializeComponent();
            db = new Database();
            if (!db.connect()) //db connection failed
            {
                MessageBox.Show("Error - Connection falied!");
            }
        }

        private void shouldQuit(bool back) //check if this form was opened by form booking
        {
            FormCollection fc = Application.OpenForms;
            int count = 0;
            foreach (Form f in fc)
            {
                if (f.Visible)
                {
                    count++;
                }
            }
            if (count > 1) // opened from booking form
            {
                this.Close();
            }
            else
            {
                if (back)
                {
                    CrecheMenu form = new CrecheMenu();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MiscFunctions.exit();
                }
            }
        }

        //exit button
        private void btnexit_Click(object sender, EventArgs e)
        {
            shouldQuit(false);
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
            populatecbx();
            initcombo();
            Timer.Start();
            Timelbl.Text = DateTime.Now.ToLongTimeString();
            MiscFunctions.buttonhover(this);
        }
        //populate listbox with staff
        private void initcombo()
        {
            stafflist.Items.Clear();
            StaffDB staffdb = new StaffDB(db);
            staff = staffdb.getallstaff();
            if(staff.Count == 0) // no staff added
            {
                btnadd.Visible = false;
                btnremove.Visible = false;
                mode = "add";
                enableTextboxes();
            }
            else
            {
                if (!stilladding && (!btnadd.Visible || !btnremove.Visible && staff.Count > 0))
                {
                    btnadd.Visible = true;
                    btnremove.Visible = true;
                }
                foreach (StaffMember member in staff)
                {
                    stafflist.Items.Add(member.Forename + " " + member.Surname);
                }
                stafflist.SelectedIndex = 0;
            }
        }

        private void populatecbx() //populate group cbx
        {
            groupcbx.Items.Clear();
            groupcbx.Items.Add("Babies");
            groupcbx.Items.Add("Toddler");
            groupcbx.Items.Add("Child");
            groupcbx.SelectedIndex = 0;
        }
        //text change event for staff search
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            List<StaffMember> updatedstaff = new List<StaffMember>();
            foreach(StaffMember member in staff)
            {
                if ((member.Forename.ToLower().Trim() + " " + member.Surname.ToLower().Trim()).Contains(searchtxt.Text.ToLower().Trim())) 
                {
                    updatedstaff.Add(member);//if found update staff list
                }
            }
            stafflist.Items.Clear();
            foreach(StaffMember member in updatedstaff)
            {
                stafflist.Items.Add(member.Forename + " " + member.Surname);
            }
            if(updatedstaff.Count > 0)
            {
                stafflist.SelectedIndex = 0;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            switch (mode) //check action depending on mode
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

        private void startedit() //enable textboxes for editing
        {
            fnametxt.Enabled = true;
            Surnametxt.Enabled = true;
            TeleNotxt.Enabled = true;
            Addresstxt.Enabled = true;
            Postcodetxt.Enabled = true;
            groupcbx.Enabled = true;
            btnupdate.Text = "Save";
            mode = "edit";
            btncancel.Visible = true;
        }

        private void doadd() //add a new staff member
        {
            reseterrors();
            if (performchecks())
            {
                StaffDB staffdb = new StaffDB(db);
                int count = staffdb.countStaffbyid(groupcbx.SelectedIndex + 1);
                if (count == 1)// recover any booking removed due to lacking staff
                {
                    int num = staffdb.UpdateDates(groupcbx.SelectedIndex + 1);
                    MessageBox.Show($"{num.ToString()} bookings added back!");
                }
                staffdb.addstaffmember(fnametxt.Text, Surnametxt.Text, TeleNotxt.Text, Postcodetxt.Text, Addresstxt.Text);
                staffdb.addStaffGroup(fnametxt.Text, groupcbx.SelectedIndex + 1);
                messagelbl.Text = "Success!";
                messagelbl.Visible = true;
                DialogResult dialogResult = MessageBox.Show("Would you like to add another staff member?", "Adding staff", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) //allow the user to continue adding staff members
                {
                    resetTextboxes();
                    mode = "add";
                    stilladding = true;
                }
                else
                {
                    mode = "edit1";
                    enableTextboxes();
                    btnadd.Visible = true;
                    btncancel.Visible = false;
                    stilladding = false;
                }
                initcombo();
            }
            else
            {
                MessageBox.Show("Please fix fields marked with *");
            }
        }

        private void doedit()
        {
            reseterrors();
            if (performchecks()) //check for requirement errors
            {
                StaffDB staffdb = new StaffDB(db);
                staffdb.updatestaffmember(current.Forename,fnametxt.Text,Surnametxt.Text,TeleNotxt.Text,Postcodetxt.Text,Addresstxt.Text);
                staffdb.updateStaffGroup(current.Forename, groupcbx.SelectedIndex + 1);
                initcombo();
                enableTextboxes();
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
                groupcbx.Enabled = false;
            }
            else
            {
                fnametxt.Enabled = true;
                Surnametxt.Enabled = true;
                TeleNotxt.Enabled = true;
                Addresstxt.Enabled = true;
                Postcodetxt.Enabled = true;
                groupcbx.Enabled = true;
            }
        }

        private void reseterrors()
        {
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
        }

        private void resetTextboxes()
        {
            fnametxt.Clear();
            Surnametxt.Clear();
            TeleNotxt.Clear();
            Postcodetxt.Clear();
            Addresstxt.Clear();
        }
        //check for error, throw custom exception if error is found
        private bool performchecks()
        {
            bool error = false;
            string message = "";
            if(fnametxt.Text == "")
            {
                message = "Missing Forename";
                error1.Visible = true;
                error = true;
            }
            if(Surnametxt.Text == "")
            {
                message = "Missing Surname";
                error2.Visible = true;
                error = true;
            }
            if(TeleNotxt.TextLength != 11)
            {
                message = "Telephone number must be 11 digits";
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
                message = "Address is missing";
                error4.Visible = true;
                error = true;
            }
            string postcode = Postcodetxt.Text.Replace(" ", String.Empty);
            if (postcode.Length>8 ||postcode.Length<6  )
            {
                message = "Postcode does not meet uk requirements";
                error5.Visible = true;
                error = true;
            }
            if (error)
            {
                try
                {
                    throw new RequirementsException(message); // custom exception
                }
                catch (RequirementsException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        //update the mode for adding a new staff member
        private void btnadd_Click(object sender, EventArgs e)
        {
            btnremove.Visible = false;
            mode = "add";
            btnupdate.Text = "Add";
            stilladding = true;
            enableTextboxes();
            resetTextboxes();
            btnadd.Visible = false;
            btncancel.Visible = true;
        }

        private void stafflist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!stilladding) // still adding no update needed
            {
                StaffDB sdb = new StaffDB(db);
                staffGroup = sdb.getStaffGroup(staff[stafflist.SelectedIndex].Forename);
                foreach (StaffMember member in staff)
                {
                    if (member.Forename + " " + member.Surname == stafflist.Text)
                    {
                        current = member;
                        break;
                    }
                }

                mode = "edit1";
                fnametxt.Text = current.Forename;
                Surnametxt.Text = current.Surname;
                TeleNotxt.Text = current.TeleNo;
                Addresstxt.Text = current.Address;
                Postcodetxt.Text = current.Postcode;
                groupcbx.SelectedIndex = staffGroup - 1;
                btnupdate.Text = "Edit";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            shouldQuit(true);
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
        //cancel adding/editing
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = stafflist.SelectedIndex;
                enableTextboxes();
                stilladding = false;
                initcombo();
                btncancel.Visible = false;
                stafflist.SelectedIndex = index;
            }
        }
        //remove staff member/bookings
        private void btnremove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WARNING removing staff members can affect bookings");
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Remove this staff member?", "Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                removeBookings();
                StaffDB staffdb = new StaffDB(db);
                staffdb.removeStaffmember(staff[stafflist.SelectedIndex].Forename); // remove staff member
                initcombo();
            }
        }

        //remove bookings if required
        private void removeBookings()
        {
            StaffDB staffdb = new StaffDB(db);
            int count = staffdb.countStaff(staff[stafflist.SelectedIndex].Forename);

            if (count <= 2) // if there will be less than two staff remove the bookings
            {
                int deleted = staffdb.DeleteDates(staff[stafflist.SelectedIndex].Forename);
                MessageBox.Show($"{deleted} Bookings temporarly removed due to the removal of the staff member, add another staff member to get these bookings back, check by-date to view bookings removed");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
