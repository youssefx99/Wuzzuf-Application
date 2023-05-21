using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Wuzzuf
{
    public partial class SeekerProfile : Form
    {
        OracleConnection conn;
        String connString = "Data Source=orcl;User Id=hr;Password=hr;";
        public SeekerProfile()
        {
            InitializeComponent();
        }

        private void SeekerProfile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(connString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"
                Select Name, Email, Password, Gender, Education, Birth_Date, Major, Experience, Skills
                From Seeker
                Where SID = :id";
            cmd.Parameters.Add("id", Gvariales.currentSekID);

            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name.Text = reader.GetString(0);
                mail.Text = reader.GetString(1);
                password.Text = reader.GetString(2);
                Gender.Text = (reader.GetString(3) == "M" ? "Male" : "Female");
                Education.Text = reader.GetString(4);
                Birth_Date.Text = reader.GetDateTime(5).ToString();
                Major.Text = reader.GetString(6);
                Experience.Text = reader.GetString(7);
                Skills.Text = reader.GetString(8);
            }

            name.ReadOnly = true;
            mail.ReadOnly = true;
            password.ReadOnly = true;
            Gender.ReadOnly = true;
            Birth_Date.ReadOnly = true;

            reader.Close();
        }

        private void Show_Hide_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !password.UseSystemPasswordChar;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            String major_str = Major.Text;
            String experience_str = Experience.Text;
            String skills_str = Skills.Text;
            String education_str = Education.Text;

            
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = @"
                Update Seeker
                Set major = :major, experience = :experience, skills = :skills, education = :education
                Where SID = :id";
            command.Parameters.Add("major", major_str);
            command.Parameters.Add("experience", experience_str);
            command.Parameters.Add("skills", skills_str);
            command.Parameters.Add("education", education_str);
            command.Parameters.Add("id", Gvariales.currentSekID);

            int r = command.ExecuteNonQuery();

            MessageBox.Show("Saved");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Seeker_Dasobard seeker_Dasobard = new Seeker_Dasobard();
            seeker_Dasobard.Show();
            this.Close();
        }

        private void SeekerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
