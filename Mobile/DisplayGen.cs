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
    public partial class DisplayGen : Form
    {
        public DisplayGen()
        {
            InitializeComponent();
        }


        private void DisplayGen_Load(object sender, EventArgs e)
        {
            LoadGenre();
        }
        private void LoadGenre()
        {
            try
            {


                string q = "select * from genres ";
                Database db = new Database(q);
                db.GetData();
                DataTable dt = db.GetData();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
                {
                    if (MessageBox.Show("Are you", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string q = "delete from genres where id=" + id;
                        Database db = new Database(q);
                        db.ExecuteNonQuery();
                    }
                }
                else
                {
                    Genre g = new Genre(id);
                    g.mygen = id;
                    g.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
                this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadGenre();
        }
    }
}

