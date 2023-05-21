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

namespace Wuzzuf.Dashboards.Employer_Functionalities.Handle_Applications
{
    public partial class send_comment : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=orcl;User Id=hr;Password=hr;");
        public send_comment()
        {
            InitializeComponent();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            // put the application info with its status in the notifications table in the DB
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Notifications Values(:SID, :PID, :Status, :Comment_)";
            cmd.Parameters.Add("SID", Gvariales.seekerID_toShow);
            cmd.Parameters.Add("PID", Gvariales.JobID_toShow);
            cmd.Parameters.Add("Status", Gvariales.application_status);
            cmd.Parameters.Add("Comment_", comment_txt.Text); // the word comment causse problems
            cmd.ExecuteNonQuery();

            MessageBox.Show("We sent a notification to the applicant with your comment ✅", "Done");

            conn.Close();
            view_applications view_Applications = new view_applications();
            view_Applications.Show();
            this.Close();
        }
    }
}
