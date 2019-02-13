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
            List<string> groupNames = gdb.getgroupnames();
            GroupANum.Text = groupNames[0] + " : ";  
            GroupBNum.Text = groupNames[1] + " : "; 
            GroupCNum.Text = groupNames[2] + " : ";

            num1.Text = groupNums[0].ToString();
            Num2.Text = groupNums[1].ToString();
            Num3.Text = groupNums[2].ToString();

            availableA.Text = "Avaliable : " + (gdb.getANum() - groupNums[0]).ToString();
            AvaliableB.Text = "Avaliable : " + (gdb.getBNum() - groupNums[1]).ToString();
            AvaliableC.Text = "Avaliable : " + (gdb.getCNum() - groupNums[2]).ToString();
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
    }
}
