using GiaoDien.DAO;
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
    public partial class MemberBorrowedOverdue : Form
    {
        public MemberBorrowedOverdue()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {

            string query = "SELECT BR.TENDN 'Tên đăng nhập', UA.HOTEN 'Họ tên', UA.TUOI 'Tuổi', BR.MASA 'Mã sách mượn', BR.NGAYMUON 'Ngày mượn', BR.HANTRA 'Hạn ngày trả',BR.NGAYTRA 'Ngày trả', BR.SOLUONG 'Số lượng đã mượn' FROM UserAccount UA,Borrow BR WHERE UA.TENDN = BR.TENDN and BR.NGAYTRA > BR.HANTRA";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
