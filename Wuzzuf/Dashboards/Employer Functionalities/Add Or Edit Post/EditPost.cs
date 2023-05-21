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
    public partial class EditPost : Form
    {
        OracleDataAdapter Adapter;
        OracleCommandBuilder Builder;
        DataSet ds;


        public EditPost()
        {
            InitializeComponent();
        }

        private void EditPost_Load(object sender, EventArgs e)
        {
            String connString = "Data Source=orcl;User Id=hr;Password=hr;";
            String command = "select PID,TITLE,DESCRIPTION,REQUIRED_SKILLS,PREFERABLE_SKILLS,HOURS,Keyword,SALARY,ISINTERN  from posts where eid =" + Gvariales.currentEmpID;
            Adapter = new OracleDataAdapter(command, connString);
            ds = new DataSet();
            Adapter.Fill(ds);
            PGridView.DataSource = ds.Tables[0];

            PGridView.AllowUserToAddRows = false;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AddOrEditPosts AOEP = new AddOrEditPosts();
            AOEP.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                Builder = new OracleCommandBuilder(Adapter);
                Adapter.Update(ds.Tables[0]);
                MessageBox.Show("Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {       
                MessageBox.Show("Job ID already exist or Salary is out of boundaries", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
