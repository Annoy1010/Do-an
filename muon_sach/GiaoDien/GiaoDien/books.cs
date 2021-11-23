using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    class books
    {
        string masa;
        string tensa;
        string loaisa;
        string nxb;
        string tacgia;
        int taiban;
        int soluong;
        public books()
        {
            taiban = soluong = 0;
            masa = tensa = loaisa = nxb = tacgia = "";
        }
        public books(string MASA,string TENSA,string LOAISA,string NXB,string TACGIA,int TAIBAN,int SOLUONG)
        {
            this.Masa = MASA;
            this.Tensa = TENSA;
            this.Loaisa = LOAISA;
            this.Nxb = NXB;
            this.Tacgia = TACGIA;
            this.Taiban = TAIBAN;
            this.Soluong = SOLUONG;
        }
        public books(DataRow row)
        {
            this.Masa = row["MASA"].ToString();
            this.Tensa = row["TENSA"].ToString();
            this.Loaisa = row["LOAISA"].ToString();
            this.Nxb = row["NXB"].ToString();
            this.Tacgia = row["TACGIA"].ToString();
            this.Taiban = (int)row["TAIBAN"];
            this.Soluong = (int)row["SOLUONG"];
        }
        public string Masa
        {
            get { return masa; }
            set { masa = value; }
        }
        public int Taiban
        {
            get { return taiban; }
            set { taiban = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Tensa
        {
            get { return tensa; }
            set { tensa = value; }
        }
        public string Tacgia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
        public string Loaisa
        {
            get { return loaisa; }
            set { loaisa = value; }
        }
        public string Nxb
        {
            get { return nxb; }
            set { nxb= value; }
        }
    }
}
