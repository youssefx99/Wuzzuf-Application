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
    public partial class EmployerSU : Form
    {

        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";


        public EmployerSU()
        {
            InitializeComponent();
        }
        private void EmployerSU_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            int maxID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetNextID";
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

            String name = Cname.Text;
            String email = Cemail.Text.ToLower();
            String password = Cpassword.Text;
            String contact = Ccontact.Text;
            String address = Caddress.Text;

            OracleCommand insertCommand = new OracleCommand();
            insertCommand.Connection = conn;
            insertCommand.CommandText = "insert into Employer values(:id, :name, :email, :password, :contact, :address )";
            insertCommand.Parameters.Add("id", maxID);
            insertCommand.Parameters.Add("name", name);
            insertCommand.Parameters.Add("email", email);
            insertCommand.Parameters.Add("password", password);
            insertCommand.Parameters.Add("contact", contact);
            insertCommand.Parameters.Add("address", address);

            try
            {
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Sign up", "1 record inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home F = new Home();
                this.Close();
                F.Show();
            }
            catch
            {
                MessageBox.Show("Email Already Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void EmployerSU_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }
    }
}
