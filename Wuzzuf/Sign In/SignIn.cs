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
    public partial class SignIn : Form
    {



        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";


        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();
            
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            String Email = userEmail.Text;
            Email = Email.ToLower();
            String pass = userPass.Text;
            String userType;

            if (employerRB.Checked)
                userType = "E";
            else
                userType = "S";


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            if (userType == "S")
                cmd.CommandText = "select sid from seeker where email = :Email and password = :pass";
            else
                cmd.CommandText = "select eid from employer where email = :Email and password = :pass";

            cmd.Parameters.Add("Email", Email);
            cmd.Parameters.Add("pass", pass);

            OracleDataReader r = cmd.ExecuteReader();
            
            if (r.Read())
            {
                if(userType == "S")
                {
                    Gvariales.currentSekID = Convert.ToInt32(r[0]);
                    Gvariales.currentEmpID = -1;
                    

                    Seeker_Dasobard SD = new Seeker_Dasobard();
                    SD.Show();
                    this.Close();
                }
                else
                {
                    Gvariales.currentEmpID = Convert.ToInt32(r[0]);
                    Gvariales.currentSekID = -1;


                    Employer_Dashboard ED = new Employer_Dashboard();
                    ED.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("User doesn't exsit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void show_hide_btn_Click(object sender, EventArgs e)
        {
            userPass.UseSystemPasswordChar = !userPass.UseSystemPasswordChar;
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }
    }
}
