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
    public partial class RegGenres : Form
    {
        int GENID = 0;
        public int gid;

        public RegGenres(int GENID)
        {
            InitializeComponent();
            this.GENID = GENID;
        }

        private void RegGenre_Load(object sender, EventArgs e)
        {
          
            try
            {
                string q = "select * from Genres";
                Database db = new Database(q);
                DataTable dt = db.GetData();
                cbGenre.DisplayMember = "Genre";
                cbGenre.ValueMember = "Id";
                cbGenre.DataSource = dt;
                if (GENID > 0)
                {
                    string selectgen = "select * from RegGenre where id=" + GENID;
                    db = new Database(selectgen);
                    DataTable dts = db.GetData();
                    if (dts.Rows.Count > 0)
                    {
                        cbGenre.SelectedValue = dts.Rows[0]["Genre"];
                        txtMovieT.Text = dts.Rows[0]["movietitle"].ToString();
                        txtDirector.Text = dts.Rows[0]["Director"].ToString();
                        txtDate.Text = dts.Rows[0]["Date"].ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int Genre = Convert.ToInt32 (cbGenre.SelectedValue);
            string q = "insert into RegGenre values('"+Genre+"','"+txtMovieT.Text+"','"+txtDirector.Text+"','"+txtDate.Text+"')";
            if(gid>0)
            {
                q = "update RegGenre set Genre='"+Genre+"',movietitle='"+txtMovieT.Text+"',Director='"+txtDirector.Text+"',Date='"+txtDate.Text+"' where id="+GENID;

            }
            Database db = new Database(q);
            db.ExecuteNonQuery();
            MessageBox.Show("Save Successfully");
        }
    }
}