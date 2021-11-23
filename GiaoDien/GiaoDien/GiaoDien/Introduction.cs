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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
            showIntro();
        }
        void showIntro()
        {
            data.Text = "Ngày nay công nghệ thông tin ngày càng phát "
                + "triển việc lưu trữ tra cứu thông tin trở nên dễ dàng hơn. "
                + "Đặc biệt đối với thư viện khi mà phải lưu trữ một khối lượng "
                + "dữ liệu lớn, thấy được vấn đề đó nhóm em đã xây dựng app quản "
                + "lý thư viện để quản lý các thông tin sách và thành viên trở nên "
                + "dễ dàng hơn. App có tính ứng dụng cao, giao diện đơn giản, dễ sử dụng "
                + "có phân quyền sử dụng hệ thống để đảm bảo tính bảo mật. Giúp tiết "
                + "kiệm tối đa nguồn lực và thời gian.";
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            showIntro();
        }
    }
}
