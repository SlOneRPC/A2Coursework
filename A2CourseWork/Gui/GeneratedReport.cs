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
        public GeneratedReport()
        {
            InitializeComponent();
        }

        private void GeneratedReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crecheData.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.crecheData.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
