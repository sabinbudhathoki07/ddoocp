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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NEWGENREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genre g = new Genre(0);
            g.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void DISPLAYGENREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayGen dg = new DisplayGen();
            dg.Show();
        }

        private void NEWMOVIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegGenres rg = new RegGenres(0);
            rg.Show();

        }

        private void DISPLAYMOVIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRegGen dg = new DisplayRegGen();
            dg.Show();
        }
    }
}
