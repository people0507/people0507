using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void box1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {

                errorProvider1.SetError(textBox1, "Không được để trống !,hãy nhập số ");
                btnGiai.Enabled = false;
            }
            else 
            {
                errorProvider1.Clear();
                if (textBox2.Text != "")
                {
                    btnGiai.Enabled = true;
                }

            }
        }

        private void box2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Không được để trống ! hãy nhập số ");
                btnGiai.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                if (textBox1.Text != "")
                {
                    btnGiai.Enabled = true;
                }
            }
        }
        
        private void box3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void giaiClick(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            
            if (a == 0)
            {
                
                if (b == 0)
                {
                    MessageBox.Show( "Phương trình vô số nghiệm");
                    
                }
                
                else
                {
                    MessageBox.Show(  "Phương trình vô nghiệm");
                }
            }
            else
            {
                double x = (-b / a );
                textBox3.Text = x.ToString();
            }
            btnXoa.Enabled = true;
            btnGiai.Enabled = false;
        }

        private void xoaClick(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void thoatClick(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
