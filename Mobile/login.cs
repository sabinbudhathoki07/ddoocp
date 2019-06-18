using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtGenreId.Text == "admin" && txtPassword.Text == "admin")
            {
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
            txtPassword.Text = "";
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtGenreId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
