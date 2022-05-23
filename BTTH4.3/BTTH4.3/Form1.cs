using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTTH4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {   
            if(txtN.Text.Trim().Length > 0 && !char.IsDigit(txtN.Text, txtN.Text.Length - 1))
            {
                errorProvider1.SetError(txtN, "Khong dc nhap chu!");
            }
            
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(txtN.Text);
            if(a >= 0 && a <= 1000)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(txtN, "Nhập số trong khoảng 0<n<1000!");
              
            }
        }
        //kiểm tra số nguyên tố
        public static bool checkSNT(int n)
        {
            for(int i = 2; i <= n/2; i++)
                if(n % i == 0)
                    return false;
                return true;
        }
        //kiểm tra số hoàn chỉnh
        public static bool checkSHC(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                
            }   
                if (sum == n)
                    return true;
                return false;
        }

        private void btn_DisplayClick(object sender, EventArgs e)
        {
            
            string tong = "";
            int n = Convert.ToInt32(txtN.Text);
            //Số nguyên tố
            for (int i = 2; i < n; i++)
            if(checkSNT(i))   
                {
                    tong = tong+ i + " ";
                    lbl_Kq1.Text = tong;
                }
                
            //Số chính phương

            string tongCP = " ";
            for(int i = 1; i < n; i++)
            {
                tongCP =tongCP + (i * i) + " " ;
                lbl_Kq2.Text = tongCP ;
            }

            //Số hoàn chỉnh
            string tongHC = " ";
            for(int i = 1; i <= n; i++)
            if (checkSHC(i))
            {
                tongHC =tongHC+ i + " ";
                lbl_Kq3.Text = tongHC;
            }
            } 
        }
    }

