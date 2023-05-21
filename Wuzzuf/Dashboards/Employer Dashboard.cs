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
    public partial class Employer_Dashboard : Form
    {
        public Employer_Dashboard()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AddOrEditPosts AP = new AddOrEditPosts();
            AP.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignIn SI  = new SignIn();
            SI.Show();
            Gvariales.currentEmpID = -1;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployerProfile EP = new EmployerProfile();
            EP.Show();
            this.Close();
        }

        private void view_application_btn_Click(object sender, EventArgs e)
        {
            view_applications view_Applications = new view_applications();
            view_Applications.Show();
            this.Close();
        }

        private void Employer_Dashboard_Load(object sender, EventArgs e)
        {
           
                OracleConnection conn;
                String connString = "Data Source=orcl;User Id=hr;Password=hr;";
                conn = new OracleConnection(connString);
                conn.Open();


                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select NAME from employer where eid= :id";

                cmd.Parameters.Add("id", Gvariales.currentEmpID);

                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    labelname.Text = reader.GetString(0).ToUpper();
                }


        }
    }
}
