using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiuakiTh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Không dc để trống");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNumKhach_TextChanged(object sender, EventArgs e)
        {
            if (txtNumSach.Text.Trim().Length > 0 && !char.IsDigit(txtNumSach.Text, txtNumSach.Text.Length - 1))
            {
                errorProvider1.SetError(txtNumSach, "Hãy nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int dem = 0;
        int dem1 = 0;
        int sum = 0;
        
        private void btnTT_Click(object sender, EventArgs e)
        {
            
            int a =Convert.ToInt32(txtNumSach.Text);
            int b;
            int c;
            
            if(btnTT.Enabled == true && checkBox1.Checked == false)
            {

                dem++;
            }
            else
            {

            }
            if(btnTT.Enabled == true && checkBox1.Checked == true)
            {
                dem1++;
            }
            if(checkBox1.Checked == false)
            {
                txtName.Enabled = false;
                b = a * 20000;
                txtTT.Text = b.ToString();
            }
            else
            {
                b = (a * 20000) - (a * 20000 * 5 / 100);
               
                txtTT.Text = b.ToString();
            }
            int d = Convert.ToInt32(txtTT.Text);
            sum = sum + d;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtTT.Clear();
            txtName.Clear();
            txtNumSach.Clear();
            txtName.Focus();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
           
            txtSumKh.Text = dem.ToString();
            txtSumSV.Text = dem1.ToString();
            txtSumDT.Text = sum.ToString();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
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
    }
}
