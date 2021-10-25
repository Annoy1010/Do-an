using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class ThuVien : Form
    {
        public ThuVien()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

           QuanLyAdmin ttcn = new QuanLyAdmin();
            ttcn.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy= new DangKy();
            dangKy.Show();
        }
    }
}
