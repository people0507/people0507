using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._2
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txta.Text.Trim().Length == 0 )
            {
                errorProvider1.SetError(txta, "Loi khong nhap a.");    
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
             if ((!char.IsDigit(txta.Text, txta.Text.Length - 1)) && (!char.IsDigit(txtb.Text, txtb.Text.Length - 1)) || (!char.IsDigit(txta.Text, txta.Text.Length - 1)) && (char.IsDigit(txtb.Text, txtb.Text.Length - 1)) || (char.IsDigit(txta.Text, txta.Text.Length - 1)) && (!char.IsDigit(txtb.Text, txtb.Text.Length - 1)))
             {
                 errorProvider1.SetError(txta, "loi nhap chu!");
                 errorProvider1.SetError(txtb, "loi nhap chu!");    
             }
             else
             {
                 errorProvider1.Clear();
                 Hoandoi.Hoanvi(txta, txtb);
             }
            /*int c;
           if(txtb.Text == "")
            {
                errorProvider1.SetError(this, "Loi phai nhap b");
            }
           else if(!int.TryParse(txtb.Text,out c)){
                errorProvider1.SetError(this,"Loi phai nhap so");
            }
           else
            {
                errorProvider1.Clear();
            }
            Hoandoi.Hoanvi(txta, txtb); */
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txta.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (txtb.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtb, "Loi khong nhap b.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
