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
        Database db;
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
        }


        private void populategroupNums()
        {
            GroupDB gdb = new GroupDB(db);
            List<int> groupNums = gdb.numineachgroup();
            GroupANum.Text = "Group A : " + groupNums[0].ToString();
            GroupBNum.Text = "Group B : " + groupNums[1].ToString();
            GroupCNum.Text = "Group C : " + groupNums[2].ToString();

            if (groupNums[0] >= gdb.getANum())
            {
                GroupANum.ForeColor = Color.Red;
            }
            else
            {
                GroupANum.ForeColor = Color.LimeGreen;
            }
            if(groupNums[1] >= gdb.getBNum())
            {
                GroupBNum.ForeColor = Color.Red;
            }
            else
            {
                GroupBNum.ForeColor = Color.LimeGreen;
            }

            if(groupNums[2] >= gdb.getCNum())
            {
                GroupCNum.ForeColor = Color.Red;
            }
            else
            {
                GroupCNum.ForeColor = Color.LimeGreen;
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
