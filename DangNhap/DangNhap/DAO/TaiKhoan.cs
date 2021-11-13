using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap.DAO
{
    class TaiKhoan
    {
        private string Username { get; set; }
        public TaiKhoan()
        {
        }

        public TaiKhoan(string username)
        {
            Username = username;
        }
        public void setTaiKhoan(string username)
        {
            this.Username = username;
        }

     
    }
}
