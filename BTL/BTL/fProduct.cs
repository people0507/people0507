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
    public partial class fProduct : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        string sql = @"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public fProduct()
        {
            InitializeComponent();
        }
        connectDB conn = new connectDB();
        SqlConnection con;
        SqlCommand cm;
        DataSet ds;
        SqlDataAdapter da;
        public void loadData()
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Products,ListOfProduct where Products.id = ListOfProduct.id ";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

            
            this.LoadDBComBox();

        }
        public void LoadDBComBox()
        {
            con = conn.conDB();
            con.Open();
            cm = new SqlCommand("select id,name from ListOfProduct",con);
            da = new SqlDataAdapter(cm);
            ds=new DataSet();
            da.Fill(ds,"ListOfProduct");
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView2.CurrentRow.Index;
            txtIDSP.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtNameSP.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txtprice.Text= dataGridView2.Rows[i].Cells[3].Value.ToString();

        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            loadData();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO Products (name, price) VALUES(N'"+txtNameSP.Text+"','"+txtprice.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
            
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "DELETE FROM Products WHERE id = '" + txtIDSP.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {

        }
    }
}
