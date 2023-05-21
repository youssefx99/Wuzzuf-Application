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
using Wuzzuf.Dashboards.Seeker_Functionalitites;
using Wuzzuf.Job_Search;

namespace Wuzzuf
{
    public partial class Seeker_Dasobard : Form
    {
        public Seeker_Dasobard()
        {
            InitializeComponent();
        }

        private void Seeker_Dasobard_Load(object sender, EventArgs e)
        {
            OracleConnection conn;
            String connString = "Data Source=orcl;User Id=hr;Password=hr;";
            conn = new OracleConnection(connString);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select NAME from seeker where sid= :id";

            cmd.Parameters.Add("id", Gvariales.currentSekID);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                labelname.Text = reader.GetString(0).ToUpper();
            }
        }

        private void notifications_btn_Click(object sender, EventArgs e)
        {
            view_notifications view_Notifications = new view_notifications();
            view_Notifications.Show();
            this.Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search choose_Keywords = new search();
            choose_Keywords.Show();
            this.Close();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            SeekerProfile seekerProfile = new SeekerProfile();
            seekerProfile.Show();
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
