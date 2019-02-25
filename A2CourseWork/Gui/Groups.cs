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
    public partial class Groups : Default
    {
        private Database db;
        private DataTable table;
        List<List<string>> data;
        List<int> attention;
        public Groups()
        {
            InitializeComponent();
            panel2.BringToFront();
            db = new Database();
            db.connect();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            populategroupNums();
            populateGroupNumscbx();
            createTableForGroup(groupnumscbx.SelectedIndex + 1);
        }


        private void populategroupNums()
        {
            GroupDB gdb = new GroupDB(db);
            List<int> groupNums = gdb.numineachgroup();
            List<string> groupNames = gdb.getgroupnames();
            GroupANum.Text = groupNames[0] + " : ";  
            GroupBNum.Text = groupNames[1] + " : "; 
            GroupCNum.Text = groupNames[2] + " : ";

            num1.Text = groupNums[0].ToString();
            Num2.Text = groupNums[1].ToString();
            Num3.Text = groupNums[2].ToString();

            availableA.Text = groupNames[0] + " : " + (gdb.getANum() - groupNums[0]).ToString();
            AvaliableB.Text = groupNames[1] + " : " + (gdb.getBNum() - groupNums[1]).ToString();
            AvaliableC.Text = groupNames[2] + " : " + (gdb.getCNum() - groupNums[2]).ToString();
            if (groupNums[0] >= gdb.getANum())
            {
                num1.ForeColor = Color.Red;
            }
            else
            {
                num1.ForeColor = Color.LimeGreen;
            }
            if(groupNums[1] >= gdb.getBNum())
            {
                Num2.ForeColor = Color.Red;
            }
            else
            {
                Num2.ForeColor = Color.LimeGreen;
            }

            if(groupNums[2] >= gdb.getCNum())
            {
                Num3.ForeColor = Color.Red;
            }
            else
            {
                Num3.ForeColor = Color.LimeGreen;
            }
            StaffDB sdb = new StaffDB(db);
            StaffA.Text = groupNames[0] + " : " + sdb.countStaffbyid(1);
            StaffB.Text = groupNames[1] + " : " + sdb.countStaffbyid(2);
            StaffC.Text = groupNames[2] + " : " + sdb.countStaffbyid(3);
            List<Label> stafflabels = new List<Label>() { StaffA, StaffB, StaffC };
            int counter = 0;
            foreach (Label label in stafflabels)
            {
                counter++;
                if (sdb.countStaffbyid(counter)<2)
                {
                    label.ForeColor = Color.Red;
                }
            }
        }

        private void populateGroupNumscbx()
        {
            groupnumscbx.Items.Clear();
            GroupDB gdb = new GroupDB(db);
            List<string> groupNames= gdb.getgroupnames();
            groupnumscbx.Items.Add(groupNames[0]);
            groupnumscbx.Items.Add(groupNames[1]);
            groupnumscbx.Items.Add(groupNames[2]);
            groupnumscbx.SelectedIndex = 0;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu menu = new CrecheMenu();
            this.Hide();
            menu.Show();
        }

        private void createTableForGroup(int groupid)
        {
            table = new DataTable();
            table.Columns.Add("Child Name");
            table.Columns.Add("Child DOB");
            table.Columns.Add("Child Group");
            table.Columns.Add("Months till group change");
            table.Columns.Add("Needs Attenion");
            MiscDB miscdb = new MiscDB(db);
            data = miscdb.GetGroupDetails(groupid);
            attention = new List<int>();
            foreach (List<string> current in data)
            {
                int change = MiscFunctions.CalculateGroupChange(current[2], groupid);
                attention.Add(change);
                string Attention = "No";
                if (change < 0)
                {
                    Attention = "Yes";
                }
                table.Rows.Add(current[0] + " " + current[1], current[2], MiscFunctions.getgroupfromage(current[2]), change.ToString(), Attention);
            }
            GroupDetails.DataSource = table;
            GroupDetails.AllowUserToAddRows = false;
            int x = 0;
            foreach (DataGridViewRow row in GroupDetails.Rows)
            {
                if (attention[x] > 0)
                {
                    row.Cells[4].Style.BackColor = Color.LimeGreen;
                }
                else
                {
                    row.Cells[4].Style.BackColor = Color.Red;
                }
                x++;
            }

        }

        private void groupnumscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            createTableForGroup(groupnumscbx.SelectedIndex + 1);
            if(groupnumscbx.SelectedIndex == 2 || data.Count == 0)
            {
                btnupdate.Enabled = false;
            }
            else
            {
                btnupdate.Enabled = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int updated = 0;
            GroupDB gdb = new GroupDB(db);
            if(groupnumscbx.SelectedIndex != 2)
            {
                int x = 0;
               foreach(int index in attention)
               {
                    if (index<0)
                    {
                        gdb.updategroup(data[x][0]);
                        createTableForGroup(groupnumscbx.SelectedIndex + 1);
                        updated++;
                    }
                    x++;
               }
            }

            if(updated == 0)
            {
                MessageBox.Show("No changes needed");
            }
        }
    }
}
