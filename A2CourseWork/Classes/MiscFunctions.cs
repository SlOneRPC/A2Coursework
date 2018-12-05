using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A2CourseWork.Classes
{
    class MiscFunctions
    {
        public static void buttonhover(Form form)
        {
            foreach (Button b in form.Controls.OfType<Button>())
            {
                b.MouseEnter += (s, g) => b.Cursor = Cursors.Hand;
                b.MouseLeave += (s, g) => b.Cursor = Cursors.Arrow;
            }
        }

        public static void exit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void nextform(Form newform)
        {
            
        }

        public static string getgroupfromage(int months)
        {
            string groupName = "";
            //calculate group
            if (months > 5 && months < 19)
            {
                groupName = "Baby";
            }
            else if (months >= 18 && months <= 30)
            {
                groupName = "Toddlers";
            }
            else if (months >= 30 && months <= 48)
            {
                groupName = "Children";
            }
            else
            {
                MessageBox.Show("Error - Invalid group name");
                return "";
            }
            return groupName;
        }
    }
}
