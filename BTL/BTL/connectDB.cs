﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class connectDB : Form
    {
            public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI\GF63;Initial Catalog=QuanliSanPhamSieuThi;Integrated Security=True");
            return con;     
                }
    }
}
