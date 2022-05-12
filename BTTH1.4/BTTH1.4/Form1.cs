using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH1._4
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnRed_CheckedChange(object sender, EventArgs e)
        {
            
            lblLapTrinh.Text = textBox1.Text;
            lblLapTrinh.ForeColor = Color.Red;
            
        }
     
        private void btnGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = textBox1.Text;
            lblLapTrinh.ForeColor = Color.Green;
        }

        private void btnBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = textBox1.Text;
            lblLapTrinh.ForeColor = Color.Blue;
        }

        private void btnBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = textBox1.Text;
            lblLapTrinh.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBold.Checked == true)
            {
                lblLapTrinh.Text = textBox1.Text;
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Bold);
                chkItalic.Checked = false;
                chkUnderline.Checked = false;
            }
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItalic.Checked == true)
            {
                lblLapTrinh.Text = textBox1.Text;
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Italic);
                chkBold.Checked = false;
                chkUnderline.Checked = false;
            }
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnderline.Checked == true)
            {
                lblLapTrinh.Text = textBox1.Text;
                lblLapTrinh.Font = new Font(lblLapTrinh.Font, FontStyle.Underline);
                chkBold.Checked = false;
                chkItalic.Checked = false;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRed.Select();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {

        }

        private void lblLapTrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLapTrinh_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
