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
    public partial class LibraryRule : Form
    {
        public LibraryRule()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            data.Text = "- Không mang túi xách, cặp, sách, báo – tạp chí in vào phòng đọc (chấp nhận sách, báo dạng photocopy).\n"
                + "- Chỉ đọc tại chỗ, không mang tài liệu ra khỏi phòng đọc, ra ngoài thư viện.\n"
                + "- Không cắt xén, xé trang tài liệu, khi phát hiện sách thiếu trang, yêu cầu báo ngay cho thủ thư, nếu không bạn đọc hoàn toàn chịu trách nhiệm.\n"
                + "- Bạn đọc nào vi phạm nội quy, tùy từng mức độ sẽ có hình thức xử lý thích hợp: thu thẻ đọc, bồi thường, thông báo về cơ quan, trường học…hoặc truy tố trước pháp luật. Bạn đọc nào vi phạm nội quy, tùy từng mức độ sẽ có hình thức xử lý thích hợp: bồi thường, thông báo về cơ quan, trường học…hoặc truy tố trước pháp luật.\n"
                + "- Bạn đọc nào mượn sách quá thời hạn quy định sẽ bị hủy bỏ quyền mượn sách trong thư viện.\n"
                + "- Không hút thuốc, chất dễ cháy nổ vào phòng đọc, giữ gìn vệ sinh chung.\n"
                + "- Không nói chuyện riêng, không nghe điện thoại tại phòng đọc, yêu cầu điện thoại để chế độ rung.";
            
        }

        private void policyBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
