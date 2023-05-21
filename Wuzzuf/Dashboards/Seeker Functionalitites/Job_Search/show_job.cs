using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Wuzzuf.Job_Search
{
    public partial class show_job : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=orcl; User ID=hr; Password=hr;");
        public show_job()
        {
            InitializeComponent();
        }

        private void show_job_Load(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
                select title, description, required_skills, preferable_skills, salary, hours, isintern
                from Posts
                where PID = :PID";

            cmd.Parameters.Add("PID", Gvariales.JobID_toShow);
            OracleDataReader rd = cmd.ExecuteReader();

            if(rd.Read()) {
                JobTitle.Text = rd.GetString(0);
                jobDesc.Text = rd.GetString(1);
                reqSkill.Text = rd.GetString(2);
                prefSkill.Text = rd.GetString(3);
                salary.Text = rd.GetValue(4).ToString();
                hours.Text = rd.GetValue(5).ToString();
                intern.Text = rd.GetValue(6).ToString() == "1" ? "Yes" : "No";
            }
            rd.Close();

            cmd.CommandText = @"select name, address, contact 
                               from employer where eid = (
                               select eid from posts  where PID = :PID
                               )";

            OracleDataReader dr = cmd.ExecuteReader();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CompanyName.Text = dr.GetString(0);
                CompanyAddress.Text = dr.GetString(1);
                CompanyContact.Text = dr.GetString(2);
            }
            dr.Close();
        }

        private void show_job_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            apply application = new apply();
            application.Show();
        }
    }
}
