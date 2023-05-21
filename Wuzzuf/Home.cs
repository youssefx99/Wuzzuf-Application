using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


namespace Wuzzuf
{

    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SignUpOption_Click(object sender, EventArgs e)
        {
            SignUp SU = new SignUp();
            SU.Show();
            this.Hide();
        }

        private void SignInOption_Click(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();
            SI.Show();
            this.Hide();
        }

        private void statis_Click(object sender, EventArgs e)
        {
            Report1 salaries_report = new Report1();
            salaries_report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report2 statistics = new Report2();
            statistics.Show();
        }
    }
}
