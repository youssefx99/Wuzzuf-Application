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
    public partial class AddOrEditPosts : Form
    {
        public AddOrEditPosts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addPost AD = new addPost();
            AD.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPost EP = new EditPost();
            EP.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Employer_Dashboard ED = new Employer_Dashboard();
            ED.Show();
            this.Close();
        }

        private void AddOrEditPosts_Load(object sender, EventArgs e)
        {

        }
    }
}
