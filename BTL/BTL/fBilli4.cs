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
    public partial class fBilli4 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        string sql = @"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public fBilli4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            LoadData();
        }

        public void LoadData()
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Bill4";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE Bill4 SET nameKH = N'"+textBox1.Text+"', price = '"+textBox3.Text+"', amount ='"+textBox4.Text+"', namePr = N'"+textBox2.Text+"' where idBill = '"+textBox5.Text+"'";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "DELETE FROM Bill4 WHERE idBill = '" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox6.Text == "")
            {
            cmd = cn.CreateCommand();
            cmd.CommandText = "select * from Bill4 where idBill '%"+textBox5.Text+"%'";
            cmd.ExecuteNonQuery();
            LoadData();
            }
            
        }
    }
}
