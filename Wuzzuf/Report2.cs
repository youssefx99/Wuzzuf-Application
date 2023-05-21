using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuzzuf
{
    public partial class Report2 : Form
    {
        CrystalReport2 cr2;
        public Report2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
