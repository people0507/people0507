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
    public partial class fTbManager : Form
    {
        

        public fTbManager()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand("select Products.idPr as [ID SP],Products.name as [Name],Products.price as [Giá],Products.amount as [Số lượng]   from Products ", cn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;
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
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int tong;
            tong = a * b;
            label5.Text = tong.ToString();

            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            lvi.SubItems.Add(textBox4.Text);
            lvi.SubItems.Add(label5.Text);

            listView1.Items.Add(lvi);
            int c, d;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tong1 = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                tong1 += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
            }
            label7.Text = tong1.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("*****$Siêu thị Team 8$*****",new Font("Centuey Gothic",30,FontStyle.Regular),Brushes.Black,new PointF(200,15));
            e.Graphics.DrawString("ID   Sản Phẩm    Số Lượng    Giá     Thành Tiền   ", new Font("Centuey Gothic", 25, FontStyle.Regular), Brushes.Black, new PointF(70, 100));
            e.Graphics.DrawString("Tổng tiền: "+label7.Text, new Font("Centuey Gothic", 30, FontStyle.Regular), Brushes.Black, new PointF(200,800));
            e.Graphics.DrawString("Tên Khách Hàng: "+textBox5.Text, new Font("Centuey Gothic", 20, FontStyle.Regular), Brushes.Black, new PointF(50, 900));
            e.Graphics.DrawString("Ngày mua hàng: "+dateTimePicker1.Text, new Font("Centuey Gothic", 20, FontStyle.Regular), Brushes.Black, new PointF(50, 950));
            e.Graphics.DrawString("*****Cảm ơn quý khách đã mua hàng******", new Font("Centuey Gothic", 20, FontStyle.Regular), Brushes.Black, new PointF(200, 1000));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
