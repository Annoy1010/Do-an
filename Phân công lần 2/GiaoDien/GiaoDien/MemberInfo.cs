using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class MemberInfo : Form
    {
        public MemberInfo()
        {
            InitializeComponent();
            ShowUserData();
            removeborrowBtn.Hide();
        }
        void ShowUserData()
        {
            string query = "SELECT TENDN 'Tên đăng nhập', HOTEN 'Họ và tên', TUOI 'Tuổi', CMND 'Chứng minh nhân dân', SDT 'Số điện thoại', EMAIL 'Email' FROM UserAccount WHERE QUYENQL = 0";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void ShowBorrowData()
        {
            string query = "SELECT BR.TENDN 'Tên đăng nhập', UA.HOTEN 'Họ tên', UA.TUOI 'Tuổi',UA.CMND 'Chứng minh nhân dân',UA.SDT 'Số điện thoại', BR.MASA 'Mã sách mượn', BR.NGAYMUON 'Ngày mượn', BR.HANTRA 'Hạn ngày trả', BR.NGAYTRA 'Ngày trả', BR.SOLUONG 'Số lượng đã mượn', BR.DATRA 'Đã trả' FROM UserAccount UA,Borrow BR WHERE UA.TENDN = BR.TENDN";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void memberListBtn_Click(object sender, EventArgs e)
        {
            ShowUserData();
            removeborrowBtn.Hide();
        }
        private void borrowmemberListBtn_Click(object sender, EventArgs e)
        {
            ShowBorrowData();
            removeborrowBtn.Show();
        }
        private void removeborrowBtn_Click(object sender, EventArgs e)
        {
            object usernameData = data.SelectedCells[0].Value;
            string username = usernameData.ToString();
            DialogResult acp = MessageBox.Show("Bạn có chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (acp == DialogResult.Yes)
            {
                RemoveBorrow(username);

                /// Get Admin Account
                //DataTable AdminInfo = SearchAdmin();
                //string emailAdmin = AdminInfo.Rows[0]["EMAIL"].ToString();
                //string passAdmin = AdminInfo.Rows[0]["MATKHAU"].ToString();


                /// Get User Email
                DataTable RemovedUserInfo = SearchMember(username);
                string emailUser = RemovedUserInfo.Rows[0]["EMAIL"].ToString();


                string subject = "Hủy quyền mượn sách";
                string content = "Xin chào, bạn đã vi phạm quy định của thư viện. Bạn sẽ bị hủy quyền mượn sách trong thư viện trong tương lai. Vui lòng liên hệ quản trị viên để biết thêm thông tin chi tiết. Xin cảm ơn.";
                SendMail("lethephuc2002@gmail.com", "l3th3Phuc", emailUser, subject, content);

                MessageBox.Show(emailUser);
                MessageBox.Show("Hủy quyền mượn sách thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void RemoveBorrow(string username)
        {
            string query = "UPDATE UserAccount SET QUYENMUON = 0 WHERE TENDN = '" + username + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        void SendMail(string mailfrom, string pass, string mailto, string subject, string content)
        {
            MailMessage mail = new MailMessage(mailfrom, mailto, subject, content); //
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("lethephuc2002@gmail.com", "l3th3Phuc"); /// Sử dụng tài khoản gmail người gửi
            client.EnableSsl = true;           
            client.Send(mail);  
            MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
        }
        DataTable SearchMember(string user)
        {
            string query = "SELECT EMAIL FROM UserAccount WHERE TENDN = '" + user + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        //DataTable SearchAdmin()
        //{
        //    string query = "SELECT EMAIL FROM UserAccount WHERE TENDN = 'sanpot'";
        //    return DataProvider.Instance.ExecuteQuery(query);
        //}
    }
}
