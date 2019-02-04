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
    public partial class Prices : Default
    {
        Database db;
        public Prices()
        {
            InitializeComponent();
            panel2.BringToFront();
            db = new Database();
            db.connect();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CrecheMenu menu = new CrecheMenu();
            this.Hide();
            menu.Show();
        }

        private void Prices_Load(object sender, EventArgs e)
        {
            setPrices();
            setGroups();
        }

        private void setPrices()
        {
            PricesDB pdb = new PricesDB(db);
            Base.Value = pdb.getBase();
            MinD.Value = pdb.getMinDiscount();
            MedD.Value = pdb.getMedDiscount();
            MaxD.Value = pdb.getMaxDiscount();
        }

        private void setGroups()
        {
            GroupDB gdb = new GroupDB(db);
            List<string> groupNames = gdb.getgroupnames();
            NameA.Text = groupNames[0];
            NameB.Text = groupNames[1];
            NameC.Text = groupNames[2];
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Changing prices will affect bookings, are you sure?", "Prices", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PricesDB pdb = new PricesDB(db);
                pdb.updateValues(Convert.ToInt32(Base.Value), Convert.ToInt32(MinD.Value), Convert.ToInt32(MedD.Value), Convert.ToInt32(MaxD.Value));
                messagelbl.Visible = true;
            }
        }

        private void btngapply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current not working, needs fixed!");
        }
    }
}
