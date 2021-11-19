using QuenMatKhau.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuenMatKhau
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            if (IsNullData(email))
                MessageBox.Show("Vui lòng nhập email trước khi xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (CheckEmail(email).Rows.Count == 0)
                    MessageBox.Show("Email không hợp lệ. Vui lòng kiểm lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    EmailResetPass.Instance.SetEmail(email);
                    OTPCode.Instance.SetOTP(InitOTPCode(100000, 999999).ToString());
                    string subject = "Bảo mật";
                    string content = "Xin chào bạn, bạn vừa thực hiện khôi phục tài khoản. Mã xác thực của bạn là: " + OTPCode.Instance.GetOTP()
                                        + ". Vui lòng xác nhận mã để thực hiện cài đặt lại mật khẩu.";
                    SendMail("libmgsystem@gmail.com", "1010@1010", email, subject, content);
                    this.Close();
                    DisplayNewForm();
                }
            }
        }
        void DisplayNewForm()
        {
            th = new Thread(OpenCreateNewPassForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenCreateNewPassForm()
        {
            Application.Run(new OTP());
        }

        bool IsNullData(string email)
        {
            return String.IsNullOrEmpty(email);
        }
        DataTable CheckEmail(string email)
        {
            string query = "SELECT * FROM UserAccount WHERE EMAIL = '" + email + "'";
            return DataProvider.Instance.ExecuteQuery(query);
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
            MessageBox.Show("Đã gửi mã xác thực thành công!", "Thông báo", MessageBoxButtons.OK);
        }
        int InitOTPCode(int begin, int end)
        {
            Random rd = new Random();
            return rd.Next(begin, end);
        }
    }
}
