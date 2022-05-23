using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        string tinh;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1.Text+ "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void buttonplus_Click(object sender, EventArgs e)
        {
            tinh = "+";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            tinh = "-";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            tinh = "*";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            if(tinh == "+")
            {
                b = a + Convert.ToDouble(textBox1.Text);
                textBox1.Text = " = " + a.ToString() + "+" + Convert.ToString(textBox1.Text);
                textBox2.Text = b.ToString();

            }
            if(tinh == "-"){
                b = a - Convert.ToDouble(textBox1.Text);
                textBox1.Text = " = " + a.ToString() + "-" + Convert.ToString(textBox1.Text);
                textBox2.Text = b.ToString();
            }
            if(tinh == "*")
            {
                b = a * Convert.ToDouble(textBox1.Text);
                textBox1.Text = " = " + a.ToString() + "*" + Convert.ToString(textBox1.Text);
                textBox2.Text = b.ToString();
            }
            if(tinh == "/")
            {  
                b = a / Convert.ToDouble(textBox1.Text);
                textBox1.Text = " = " + a.ToString() + "/" + Convert.ToString(textBox1.Text);
                textBox2.Text = b.ToString();
            }
        }

        private void buttondivine_Click(object sender, EventArgs e)
        {
            tinh = "/";
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }
    }
}
