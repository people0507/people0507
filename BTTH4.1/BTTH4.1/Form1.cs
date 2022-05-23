using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "") {
                errorProvider1.SetError(txtUser, "Chua nhap ten dang nhap!");
                errorProvider1.SetError(txtPass, "Chua nhap mat khau!");
            }
            else {
            DialogResult r;
            r = MessageBox.Show("Tên đăng nhập: "+txtUser.Text+"\nMật khẩu: "+txtPass.Text) ;
            }
            
            if (chkNho.Checked == true)
            {
                MessageBox.Show( "Bạn có ghi nhớ.");
            }
       
        }
    }
}
