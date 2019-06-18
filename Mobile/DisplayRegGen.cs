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
    public partial class DisplayRegGen : Form
    {
        public DisplayRegGen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        try
            {
                int  id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
                {
                    if (MessageBox.Show("Are you", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string q = "delete from RegGenre where id=" + id;
                         Database db = new Database(q);
                         db.ExecuteNonQuery();
                    }
}
                else
                {
                    RegGenres rg = new RegGenres(id);
                    rg.gid = id;
                    rg.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayRegGen_Load(object sender, EventArgs e)
        {
            LoadRegGen();
        }
        private void LoadRegGen()
        {
            try
            {


                string qq = "select * from RegGenre ";
                Database db = new Database(qq);
                db.GetData();
                DataTable dt = db.GetData();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoadRegGen();
        }
    }
}
