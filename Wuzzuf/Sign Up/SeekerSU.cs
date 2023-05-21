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
    public partial class SeekerSU : Form
    {
        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";

        public SeekerSU()
        {
            InitializeComponent();
        }

        private void SeekerSU_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();
        }

        private void SeekerSU_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            
            int maxID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetNextSID";
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
            
            
            String name = Sname.Text;
            String email = Semail.Text.ToLower();
            String password = Spassword.Text;
            // radio buttons
            radioButton1.Tag = 'M';
            String gender;
            //

            String Education = Seducation.Text;
            String expecience  = SeekerExperience.Text;
            String major = Smajor.Text;
            String skills = Sskills.Text;
            DateTime BirthDate = DateTimePicker.Value;
            //      0 male = 'm'       0 female

            if(radioButton1.Checked)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            OracleCommand insertCommand = new OracleCommand();
            insertCommand.Connection = conn;
            insertCommand.CommandText = "insert into Seeker values(:id, :name, :email, :password,:gender, :education, :Bdate, :major, :exp, :skills)";
            insertCommand.Parameters.Add("id", maxID);
            insertCommand.Parameters.Add("name", name);
            insertCommand.Parameters.Add("email", email);
            insertCommand.Parameters.Add("password", password);
            insertCommand.Parameters.Add("gender", gender);
            insertCommand.Parameters.Add("education", Education);
            // dealing with date parameter
            OracleParameter op = new OracleParameter();
            op.ParameterName = "Bdate";
            op.OracleDbType = OracleDbType.Date;
            op.Value = BirthDate;
            insertCommand.Parameters.Add(op);
            //
            insertCommand.Parameters.Add("major", major);
            insertCommand.Parameters.Add("experience", expecience);
            insertCommand.Parameters.Add("skills", skills);

            try
            {
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Sign up", "1 record inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home F2 = new Home();
                this.Close();
                F2.Show();
            }
            catch
            {
                MessageBox.Show("Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }
    }
}
