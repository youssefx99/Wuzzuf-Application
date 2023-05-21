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
    public partial class Report1 : Form
    {
        CrystalReport1 cr2;

        public Report1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
