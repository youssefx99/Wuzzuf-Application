using Oracle.DataAccess.Client;
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
    public partial class view_applications : Form
    {
        public view_applications()
        {
            InitializeComponent();
        }

        private void view_applications_Load(object sender, EventArgs e)
        {
            // fill the data grid view with the applicants' data
            String conn_str = "Data Source=orcl;User Id=hr;Password=hr;";
            String cmd = @"
                Select SID, PID, Submission_Date, Skills
                From Applications
                Where PID in (
                     select PID
                     from Posts
                     where EID = :EID)";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd, conn_str);
            adapter.SelectCommand.Parameters.Add("EID", Gvariales.currentEmpID);
            DataSet ds = new DataSet();

            adapter.Fill(ds);
            applications_gridView.DataSource = ds.Tables[0];
            applications_gridView.ReadOnly = true;
            applications_gridView.AllowUserToAddRows = false;
            applications_gridView.AllowUserToDeleteRows = false;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            show_application show_Applications = new show_application();
            Gvariales.seekerID_toShow = Convert.ToInt32(id_txt.Text);
            Gvariales.JobID_toShow = Convert.ToInt32(PID_txt.Text);
            show_Applications.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Employer_Dashboard employer_Dashboard = new Employer_Dashboard();
            employer_Dashboard.Show();
            this.Close();
        }
    }
}
