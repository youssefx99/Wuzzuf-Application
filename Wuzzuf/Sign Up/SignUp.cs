using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Wuzzuf
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

            SU_Choice.Items.Add("Employer");
            SU_Choice.Items.Add("Seeker");
            SU_Choice.SelectedIndex = 0;
            SU_Choice.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (SU_Choice.SelectedIndex == 0) { 
                // employer sign up form 
                EmployerSU employerSU = new EmployerSU();
                employerSU.Show();
            }
            else
            {
                // seeker sign up form
                SeekerSU seekerSU = new SeekerSU();
                seekerSU.Show();
            }
            this.Close();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }
    }
}
