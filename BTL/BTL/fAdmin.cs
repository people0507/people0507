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
    public partial class fAdmin : Form
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        string sql = @"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();


        public void loadData()
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT ROW_NUMBER() OVER(ORDER BY Account.UserName) as STT, Account.name as 'Họ tên', Account.UserName as 'Tên đăng nhập',Account.PassWord as 'Mật khẩu',Account.Sex as 'Giới tính', Account.Birth as 'Ngày sinh', Account.Born as 'Quê quán', Account.Role as 'Quyền',Account.Contact as 'SĐT' FROM Account";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public fAdmin()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string insert_gender;
            if (rbMale.Checked)
            {
                insert_gender = "Nam";
            }
            else { 
                insert_gender = "Nữ";
            }
            cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO Account (UserName,Name,PassWord,Role,Born,Sex,Birth,Contact) VALUES ('" + txtAcc.Text + "' , N'" + txtName.Text + "' , '" + txtPW.Text + "' , N'" + txtRole.Text + "' , N'" + txtHT.Text +"',N'" + insert_gender + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "','"+txtContact.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string insert_gender;
            if (rbMale.Checked) insert_gender = "Nam";
            else insert_gender = "Nữ";

            cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE Account SET UserName = N'" + txtAcc.Text + "', Name = N'" + txtName.Text + "', PassWord = N'" + txtPW.Text + "', Role = N'" + txtRole.Text + "', Born = N'" + txtHT.Text + "', Sex = N'" + insert_gender + "', Birth ='"+ dateTimePicker1.Value.ToString("yyyy/MM/dd")+"',Contact ='"+txtContact.Text+"' WHERE Username = '" + txtAcc.Text +"'";
            cmd.ExecuteNonQuery();
            loadData();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtAcc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtPW.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtHT.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtRole.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtContact.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Nam") rbMale.Checked = true;
            else rbFemale.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = cn.CreateCommand();
            cmd.CommandText = "DELETE FROM Account WHERE UserName = '" + txtAcc.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(sql);
            cn.Open();
            loadData();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTbManager n = new fTbManager();
            this.Hide();
            n.ShowDialog();
            this.Show();
        }
    }
}
