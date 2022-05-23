using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileImage  = new OpenFileDialog();
            if(fileImage.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(fileImage.FileName);
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
