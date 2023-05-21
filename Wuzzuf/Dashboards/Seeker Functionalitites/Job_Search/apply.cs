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

namespace Wuzzuf.Job_Search
{
    public partial class apply : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=orcl;User Id=hr;Password=hr;");
        public apply()
        {
            InitializeComponent();
        }

        private void apply_Load(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select major, education, experience, skills From Seeker Where SID = :id";
            cmd.Parameters.Add("id", Gvariales.currentSekID);
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // if it found something to read
            {
                Major_txt.Text = reader.GetString(0);
                Education_txt.Text = reader.GetString(1);
                Experience_txt.Text = reader.GetString(2);
                Skills_txt.Text = reader.GetString(3);
            }
            reader.Close();
        }

        private void apply_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void send_Data()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Insert into Applications 
                Values(:SID, :PID, :Submission_Date, :Major, :Experience, :Education, :Skills)";
            cmd.Parameters.Add("SID", Gvariales.currentSekID);
            cmd.Parameters.Add("PID", Gvariales.JobID_toShow);
            // dealing with date parameter
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = "Submission_Date";
            parameter.OracleDbType = OracleDbType.Date;
            parameter.Value = DateTime.Now;
            cmd.Parameters.Add(parameter);

            cmd.Parameters.Add("Major", Major_txt.Text);
            cmd.Parameters.Add("Experience", Experience_txt.Text);
            cmd.Parameters.Add("Education", Education_txt.Text);
            cmd.Parameters.Add("Skills", Skills_txt.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Your application =)", "Success");
            }
            catch
            {
                MessageBox.Show("You can't apply to the same job / intern more than once :/");
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            send_Data();
            this.Close();
        }

        private void overrite_submit_btn_Click(object sender, EventArgs e)
        {
            send_Data();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"Update Seeker 
                set Major = :Major, Experience = :Experience, Education = :Education, Skills = :Skills";
            cmd.Parameters.Add("Major", Major_txt.Text);
            cmd.Parameters.Add("Experience", Experience_txt.Text);
            cmd.Parameters.Add("Education", Education_txt.Text);
            cmd.Parameters.Add("Skills", Skills_txt.Text);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
