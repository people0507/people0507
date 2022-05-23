using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Trim().Length > 0 && !char.IsDigit(textBox1.Text,textBox1.Text.Length - 1))
            {
                this.errorProvider1.SetError(textBox1, "Không được nhập chữ , hãy nhập số! ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length > 0 && !char.IsDigit(textBox2.Text, textBox2.Text.Length - 1))
            {
                this.errorProvider1.SetError(textBox2, "Không được nhập chữ, hãy nhập số! ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim().Length > 0 && !char.IsDigit(textBox3.Text, textBox3.Text.Length - 1))
            {
                this.errorProvider1.SetError(textBox3, "Không được nhập chữ, hãy nhập số! ");
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            float delta = 0;
            if(a != 0)
            {
                delta = (float)(b * b - 4*a * c);
                if (delta < 0)
                {
                    richTextBox1.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    richTextBox1.Text = "Phương trình có nghiệm kép : x1 = x2= " + -b / 2 * a;
                }
                else
                {
                    richTextBox1.Text = "x1 = " + (-b + Math.Sqrt(delta)) / 2 * a + "\nx2 = " + (-b - Math.Sqrt(delta)) / 2 * a;
                    
                }
                    
            }
            else
            {
                if(b == 0)
                {
                    if(c == 0)
                    {
                        richTextBox1.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        richTextBox1.Text = "Phương trình vô nghiệm";  
                    }    
                }
                else
                {
                    richTextBox1.Text = "Phương trình có nghiệm duy nhất :" + -c / b;
                }    
            }    
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
