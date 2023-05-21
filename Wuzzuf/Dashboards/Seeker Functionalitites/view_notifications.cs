using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuzzuf.Dashboards.Seeker_Functionalitites
{
    public partial class view_notifications : Form
    {
        OracleDataAdapter adapter;
        DataSet ds = new DataSet();
        OracleCommandBuilder builder;
        public view_notifications()
        {
            InitializeComponent();
        }

        private void view_notifications_Load(object sender, EventArgs e)
        {
            String cmd = "Select SID, PID, Status, Comment_ From Notifications Where SID = :SID";
            String conn_str = "Data Source=orcl;User Id=hr;Password=hr;";
            adapter = new OracleDataAdapter(cmd, conn_str);
            adapter.SelectCommand.Parameters.Add("SID", Gvariales.currentSekID);
            
            adapter.Fill(ds);
            notifications_grid_view.DataSource = ds.Tables[0];
            notifications_grid_view.ReadOnly = true;
            notifications_grid_view.AllowUserToAddRows = false;
            notifications_grid_view.AllowUserToDeleteRows = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            Seeker_Dasobard seeker_Dasobard = new Seeker_Dasobard();
            seeker_Dasobard.Show();
            this.Close();
        }
    }
}
