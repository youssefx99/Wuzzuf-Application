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
    public partial class EmployerProfile : Form
    {
        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";

        public EmployerProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employer_Dashboard EDB = new Employer_Dashboard(); ;
            EDB.Show();
            this.Close();
        }

        private void SH_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = ! pass.UseSystemPasswordChar;
        }

        private void EmpProfile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select NAME,EMAIL,PASSWORD,CONTACT,ADDRESS from employer where eid= :id";

            cmd.Parameters.Add("id", Gvariales.currentEmpID);

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                name.Text = reader.GetString(0);
                mail.Text = reader.GetString(1);
                pass.Text = reader.GetString(2);
                cont.Text = reader.GetString(3);
                address.Text = reader.GetString(4);
            }

            name.ReadOnly = true;
            mail.ReadOnly = true;
            pass.ReadOnly = true;
            cont.ReadOnly = true;
            address.ReadOnly = true;

            reader.Close();

        }

        private void EmpProfile_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void EmpProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
