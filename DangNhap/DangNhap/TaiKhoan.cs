using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap
{
    class TaiKhoan
    {
    

        private string taiKhoan { get; set; }
        private string matKhau { get; set; }
        public TaiKhoan()
        {
        }

        public TaiKhoan(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }
    }
}
