using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH4._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvNhanvien.Items.Add(txtTen.Text);
            item.SubItems.Add(txtDiachi.Text);
            item.SubItems.Add(dtNgay.Value.ToShortDateString());
            item.SubItems.Add(txtSDT.Text);

            txtDiachi.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            dtNgay.Value = DateTime.Now;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvNhanvien.Columns[0].Width = (int)(lvNhanvien.Width * 0.35);
            lvNhanvien.Columns[1].Width = (int)(lvNhanvien.Width * 0.22);
            lvNhanvien.Columns[2].Width = (int)(lvNhanvien.Width * 0.22);
            lvNhanvien.Columns[3].Width = (int)(lvNhanvien.Width * 0.21);
            lvNhanvien.View = View.Details;
            lvNhanvien.GridLines = true; //
            lvNhanvien.FullRowSelect = true; // lấy cả dòng

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                lvNhanvien.Items.Remove(lvNhanvien.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn dòng muốn xóa!");
            }
        }

    

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                lvNhanvien.SelectedItems[0].SubItems[0].Text = txtTen.Text;
                lvNhanvien.SelectedItems[0].SubItems[2].Text = txtDiachi.Text;
                lvNhanvien.SelectedItems[0].SubItems[1].Text = dtNgay.Value.ToShortDateString();
                lvNhanvien.SelectedItems[0].SubItems[3].Text = txtSDT.Text;
            }
            else
            {
                MessageBox.Show("Chọn dòng muốn sửa!");
            }

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)//chỉ thực hiện khi click vào dòng dữ liệu
            {
                txtTen.Text = lvNhanvien.SelectedItems[0].SubItems[0].Text;
                dtNgay.Text = lvNhanvien.SelectedItems[0].SubItems[1].Text;
                txtDiachi.Text = lvNhanvien.SelectedItems[0].SubItems[2].Text;
                txtSDT.Text = lvNhanvien.SelectedItems[0].SubItems[3].Text;
            }

        }
    }
}
