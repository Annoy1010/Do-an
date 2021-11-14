using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien_ThongTinUser.DAO;

namespace GiaoDien_ThongTinUser
{
    public partial class Form1 : Form
    {
        public Form1(string username, string password)
        {
            InitializeComponent();
            LoadInfo(username, password);
        }
        void LoadInfo(string username, string password)
        {
            DataProvider provider = new DataProvider();
            string query = "select hoten, tuoi, cmnd, sdt from useraccount where tendn = '" + username + "'";
            DataTable data = provider.ExcuteQuery(query);
            txtHoTen.Text = data.Rows[0]["HOTEN"].ToString();
            txtTuoi.Text = data.Rows[0]["TUOI"].ToString();
            txtCMND.Text = data.Rows[0]["CMND"].ToString();
            txtDT.Text = data.Rows[0]["SDT"].ToString();
        }   
    }
}
