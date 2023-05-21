using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Wuzzuf
{
    public partial class addPost : Form
    {
        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";

        public addPost()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addPostBtn_Click(object sender, EventArgs e)
        {

            int maxID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetNextPID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                maxID++;
            }
            catch
            {
                maxID = 1;
            }

            string title = JobTitle.Text;
            string JobDS = jobDesc.Text;
            string RSkills = reqSkill.Text;
            string Pskills = prefSkill.Text;
            string keyWord_ = keyWord.Text;
            int Sal = Convert.ToInt32(salary.Text);
            int H = Convert.ToInt32(hours.Text);
            int intern_ = intern.Checked ? 1 : 0;

            OracleCommand insertCommand = new OracleCommand(); ;
            insertCommand.Connection = conn;

            insertCommand.CommandText = "insert into posts values(:discrption,:reqskills,:prefskils,:hours,:PID,:eid,:title,:isintern,:keyWord,:salary)";

            insertCommand.Parameters.Add("discrption", JobDS);
            insertCommand.Parameters.Add("reqskills", RSkills);
            insertCommand.Parameters.Add("prefskils", Pskills);
            insertCommand.Parameters.Add("hours", H);
            insertCommand.Parameters.Add("PID", maxID);
            insertCommand.Parameters.Add("eid", Gvariales.currentEmpID);
            insertCommand.Parameters.Add("title", title);
            insertCommand.Parameters.Add("isintern", intern_);
            if (keyWord_ == "")
                keyWord_ = "Other";
            insertCommand.Parameters.Add("keyWord", keyWord_);
            insertCommand.Parameters.Add("salary", Sal);


            insertCommand.ExecuteNonQuery();


            MessageBox.Show("Post Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Employer_Dashboard employer_Dashboard = new Employer_Dashboard();
            employer_Dashboard.Show();
            this.Close();
        }

        private void addPost_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();
        }

        private void addPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
