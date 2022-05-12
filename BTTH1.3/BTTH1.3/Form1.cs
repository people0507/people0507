using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMinus_CheckedChanged(object sender, EventArgs e)
        {
            double x = (Convert.ToDouble(textBox1.Text)) - (Convert.ToDouble(textBox2.Text) * 1.0);
            textBox3.Text = x.ToString();
        }

        private void txtDivine_CheckedChanged(object sender, EventArgs e)
        {
            double x = (Convert.ToDouble(textBox1.Text)) / (Convert.ToDouble(textBox2.Text) * 1.0);
            textBox3.Text = x.ToString();
        }

        private void txtPlus_CheckedChanged(object sender, EventArgs e)
        {
            double x = (Convert.ToDouble(textBox1.Text)) + (Convert.ToDouble(textBox2.Text) * 1.0);
            textBox3.Text = x.ToString();
        }

        private void txtMultiply_CheckedChanged(object sender, EventArgs e)
        {
            double x = (Convert.ToDouble(textBox1.Text)) * (Convert.ToDouble(textBox2.Text) * 1.0);
            textBox3.Text = x.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
