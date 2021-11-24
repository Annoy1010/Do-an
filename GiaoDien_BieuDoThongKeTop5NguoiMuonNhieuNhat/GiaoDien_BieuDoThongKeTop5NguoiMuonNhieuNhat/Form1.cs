using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien_BieuDoThongKeTop5NguoiMuonNhieuNhat.DAO;

namespace GiaoDien_BieuDoThongKeTop5NguoiMuonNhieuNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillChart();
            LoadAccountList();
        }

        private void FillChart()
        {
            DataProvider provider = new DataProvider();
            string query = "select top 5 tendn, count(masa) as soluong from borrow group by tendn order by count(masa) desc;";
            chart1.DataSource = provider.ExcuteQuery(query);

            chart1.Series["Số lượng sách"].XValueMember = "tendn";
            chart1.Series["Số lượng sách"].YValueMembers = "soluong";
            chart1.Titles.Add("bieu do");

        }
        void LoadAccountList()
        {
            string query = "select top 5 borrow.tendn, UserAccount.HoTen, sum(Borrow.SOLUONG) as soluongdamuon from borrow, UserAccount where borrow.tendn = UserAccount.tendn Group by Borrow.tendn, UserAccount.HoTen order by sum(borrow.soluong) desc";
            DataProvider provider = new DataProvider();
            dataGridView_top5.DataSource = provider.ExcuteQuery(query);
        }
    }
}
