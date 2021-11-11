using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaDuLieuSach
{
    public class Sach
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string loaiSach { get; set; }
        public string nhaXuatBan { get; set; }
        public string tagGia { get; set; }
        public int taiBan { get; set; }
        public int soLuong { get; set; }
        public Sach()
        {
        }
        public Sach(string maSach, string tenSach, string loaiSach, string nhaXuatBan, string tagGia, int taiBan, int soLuong)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.loaiSach = loaiSach;
            this.nhaXuatBan = nhaXuatBan;
            this.tagGia = tagGia;
            this.taiBan = taiBan;
            this.soLuong = soLuong;
        }  
    }
}
