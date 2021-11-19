using HuyQuyenMuon.DAO;
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

namespace HuyQuyenMuon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            object usernameData = dataGridView2.SelectedCells[0].Value;
            string username = usernameData.ToString();
            DialogResult acp = MessageBox.Show("Bạn có chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (acp == DialogResult.Yes)
            {
                RemoveBorrow(username);

                /// Get User Email
                DataTable RemovedUserInfo = SearchMember(username);
                string emailUser = RemovedUserInfo.Rows[0]["EMAIL"].ToString();


                string subject = "Hủy quyền mượn sách";
                string content = "Xin chào, bạn đã vi phạm quy định của thư viện. Bạn sẽ bị hủy quyền mượn sách trong thư viện trong tương lai. Vui lòng liên hệ quản trị viên để biết thêm thông tin chi tiết. Xin cảm ơn.";
                SendMail("libmgsystem@gmail.com", "1010@1010", emailUser, subject, content);

                MessageBox.Show(emailUser);
                MessageBox.Show("Hủy quyền mượn sách thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        void RemoveBorrow(string username)
        {
            string query = "UPDATE UserAccount SET QUYENMUON = 1 WHERE TENDN = '" + username + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        void SendMail(string mailfrom, string pass, string mailto, string subject, string content)
        {
            MailMessage mail = new MailMessage(mailfrom, mailto, subject, content); //
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("libmgsystem@gmail.com", "1010@1010"); /// Sử dụng tài khoản gmail người gửi
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
        }
        DataTable SearchMember(string user)
        {
            string query = "SELECT EMAIL FROM UserAccount WHERE TENDN = '" + user + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
