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
using Wuzzuf.Dashboards.Employer_Functionalities.Handle_Applications;

namespace Wuzzuf
{
    public partial class show_application : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=orcl;User Id=hr;Password=hr;");
        public show_application()
        {
            InitializeComponent();
        }

        private void show_applications_Load(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select name, email, gender, birth_date From Seeker Where SID = :SID";
            cmd.Parameters.Add("SID", Gvariales.seekerID_toShow);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name.Text = reader.GetString(0);
                mail.Text = reader.GetString(1);
                Gender.Text = (reader.GetString(2).ToUpper()[0] == 'M' ? "Male" : "Femle");
                Birth_Date.Text = reader.GetDateTime(3).ToString();
            }

            cmd.CommandText = @"
                Select major, education, experience, skills From Applications
                Where SID = :SID and PID = :PID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("SID", Gvariales.seekerID_toShow);
            cmd.Parameters.Add("PID", Gvariales.JobID_toShow);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Major_txt.Text = reader.GetString(0);
                Education_txt.Text = reader.GetString(1);
                Experience_txt.Text = reader.GetString(2);
                Skills_txt.Text = reader.GetString(3);
            }

            reader.Close();
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            Gvariales.application_status = 1;
            send_comment send_Comment = new send_comment();
            delete_application_record();
            send_Comment.Show();
            this.Close();
        }

        private void delete_application_record()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete From Applications Where SID = :SID and PID = :PID";
            cmd.Parameters.Add("SID", Gvariales.seekerID_toShow);
            cmd.Parameters.Add("PID", Gvariales.JobID_toShow);
            cmd.ExecuteNonQuery();
        }

        private void reject_btn_Click(object sender, EventArgs e)
        {
            Gvariales.application_status = 0;
            send_comment send_Comment = new send_comment();
            delete_application_record();
            send_Comment.Show();
            this.Close();
        }
    }
}
