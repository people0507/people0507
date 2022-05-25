using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class formTbManager : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        string sql = @"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public formTbManager()
        {
            InitializeComponent();
        }
  


        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePW n = new fChangePW();
            this.Hide();
            n.ShowDialog();
            this.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void formTbManager_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin n = new fAdmin();
            this.Hide();
            n.ShowDialog();
            this.Show();
            
        }
    }
}
