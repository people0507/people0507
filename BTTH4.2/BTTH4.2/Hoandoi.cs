using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._2
{
    internal class Hoandoi
    {
        public static void Hoanvi(TextBox txta, TextBox txtb)
        {  
            int t = Convert.ToInt32(txta.Text);
            txta.Text = txtb.Text;
            txtb.Text = t.ToString(); 
           
        }
    }
}
    

