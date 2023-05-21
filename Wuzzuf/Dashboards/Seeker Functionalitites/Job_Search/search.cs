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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Wuzzuf.Job_Search
{
    public partial class search : Form
    {
        OracleConnection conn = new OracleConnection("Data Source=orcl; User ID=hr; Password=hr;");
        public search()
        {
            InitializeComponent();
        }
        
        private void choose_keywords_Load(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetKeywords";
            cmd.Parameters.Add("results", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chosen_keyword.Items.Add(reader[0]);
            }
            reader.Close();
            
            chosen_keyword.DropDownStyle = ComboBoxStyle.DropDownList; // make it read only
            chosen_keyword.Sorted = true; // sort it
            chosen_keyword.SelectedIndex = 0; // choose the first one by default
        }

        private void choose_keywords_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String KeyWord_ = chosen_keyword.Text;
            int intern = Convert.ToInt16(IsIntern.Checked);
            String CommandText = "select PID, Title, Salary from Posts where keyword = :KW and isintern = :intern";
            OracleDataAdapter adapter = new OracleDataAdapter(CommandText, conn);
            adapter.SelectCommand.Parameters.Add("KW", KeyWord_);
            adapter.SelectCommand.Parameters.Add("intern", intern);
            OracleCommandBuilder builder = new OracleCommandBuilder();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            posts.DataSource = ds.Tables[0];
            posts.ReadOnly = true;
            posts.Anchor = AnchorStyles.Bottom;
            posts.AllowUserToAddRows = false;
            posts.AllowUserToDeleteRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gvariales.JobID_toShow = Convert.ToInt32(chosen_id.Text);
            show_job showJob = new show_job();
            showJob.Show();
            chosen_id.Text = "";
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Seeker_Dasobard seeker_Dasobard = new Seeker_Dasobard();
            seeker_Dasobard.Show();
            this.Close();
        }
    }
}

