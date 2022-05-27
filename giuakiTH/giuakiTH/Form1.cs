using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giuakiTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSP_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if(txtNum.Text == "-")
            {
                txtNum.Enabled = false;
            }
            if(txtNum.Text.Trim().Length > 0 && !char.IsDigit(txtNum.Text, txtNum.Text.Length - 1) )
            {
                errorProvider1.SetError(txtNum, "Hãy nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGia.Text.Trim().Length > 0 && !char.IsDigit(txtGia.Text, txtGia.Text.Length - 1))
            {
                errorProvider1.SetError(txtGia, "Hãy nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtGia.Clear();
            txtNum.Clear();
            txtSP.Clear();
            txtSP.Focus();
            txtNum.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt32(txtNum.Text);
            double d = Convert.ToDouble(txtGia.Text);
            double b;

            b = a * d;
            txtSum.Text = b.ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Do you want to close?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,

            MessageBoxDefaultButton.Button1);

            if (r == DialogResult.Yes)

                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
