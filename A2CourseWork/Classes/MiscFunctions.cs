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
        public void buttonhover(Form form)
        {
            foreach (Button b in form.Controls.OfType<Button>())
            {
                b.MouseEnter += (s, g) => b.Cursor = Cursors.Hand;
                b.MouseLeave += (s, g) => b.Cursor = Cursors.Arrow;
            }
        }

        public void exit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
