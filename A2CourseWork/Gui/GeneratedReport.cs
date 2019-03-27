using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CourseWork.Gui
{
    public partial class GeneratedReport : Form
    {
        DateTime Monday;
        double revenue;
        public GeneratedReport(DateTime Monday,double revenue)
        {
            InitializeComponent();
            this.Monday = Monday;
            this.revenue = revenue;
            datelbl.Text = "Current Viewing: " + Monday.ToShortDateString();
        }

        private void GeneratedReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crecheData.DataTable1' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            this.dataTable1TableAdapter.Fill(this.crecheData.DataTable1,Monday.ToShortDateString(), revenue);
            this.reportViewer1.RefreshReport();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
