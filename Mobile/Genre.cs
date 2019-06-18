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
    public partial class Genre : Form
    {
        int genID;
        public int mygen;

        public Genre( int genID)
        {
            InitializeComponent();
            this.genID = genID;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                string qq = "insert into genres Values('" + txtgen.Text + "')";
                if (genID > 0)
                {
                    qq = "update genres set name = '" + txtgen.Text + "' where id=" + genID;
                }
                Database db = new Database(qq);
                db.ExecuteNonQuery();
                MessageBox.Show("Added successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            if (genID> 0)
            {
                try
                {
                    string query = "select * from genres where id=" + genID;
                    Database db = new Database(query);
                    DataTable dt = db.GetData();
                    txtgen.Text = dt.Rows[0]["Genre"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
