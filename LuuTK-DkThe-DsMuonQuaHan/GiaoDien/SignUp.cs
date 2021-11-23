using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void singupBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passText.Text;
            string repass = repassText.Text;
            string fullname = nameText.Text;
            string age = ageText.Text;
            string passport = passportText.Text;
            string phone = phoneText.Text;
            string email = emailText.Text;
            if (IsNullData(user, pass, repass, fullname, age, passport, phone, email))
                MessageBox.Show("Nhập không đủ thông tin. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (pass.Length < 6)
                    MessageBox.Show("Mật khẩu quá ngắn. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!SubmitPassCorrect(pass, repass))
                        MessageBox.Show("Mật khẩu xác nhận không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (!IsValidNumber(age))
                            MessageBox.Show("Thông tin 'Tuổi' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (!IsValidNumber(passport) || passport.Length < 9)
                            MessageBox.Show("Thông tin 'Chứng minh thư' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (!IsValidNumber(phone) || phone.Length < 10)
                            MessageBox.Show("Thông tin 'Số điện thoại' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (!IsValidEmail(email))
                            MessageBox.Show("Thông tin 'Email' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            SHA256 sha256Hash = SHA256.Create();
                            string convertpass = EnCode.GetHash(sha256Hash, pass);
                            if (CheckUserExist(user, convertpass, fullname, age, passport, phone, email) == 0)
                                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                MessageBox.Show("Đăng ký thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                usernameText.Clear();
                                passText.Clear();
                                repassText.Clear();
                                nameText.Clear();
                                ageText.Clear();
                                passportText.Clear();
                                phoneText.Clear();
                                emailText.Clear();
                            }
                        }
                    }
                }    
            }
        }

        bool IsNullData(string user, string pass, string repass, string fullname, string age, string passport, string phone, string mail)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(repass) || String.IsNullOrEmpty(fullname) || String.IsNullOrEmpty(age) || String.IsNullOrEmpty(passport) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(mail))
                return true;
            return false;
        }

        bool IsValidNumber(string str)
        {
            if (str.Trim() == "")
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                    return false;
            }
            return true;
        }
        bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith(".") || !email.Contains(".") || !email.Contains("@"))
                return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        bool SubmitPassCorrect(string pass, string repass)
        {
            return repass == pass;
        }

        int CheckUserExist(string user, string pass, string fullname, string age, string passport, string phone, string mail)
        {
            string query = string.Format("INSERT INTO UserAccount VALUES ('{0}', '{1}', N'{2}', {3}, {4}, '{5}', '{6}', {7}, {8})", user, pass, fullname, age, passport, phone, mail, 1, 0);
            int SuccessRows = DataProvider.Instance.ExecuteNonQuery(query);
            return SuccessRows;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool showpass = true;
        bool showrepass = true;
        private void hidepass_Click_1(object sender, EventArgs e)
        {
            if (!showpass)
            {
                showpass = true;
                passText.UseSystemPasswordChar = true;
                hidepass.Image = global::GiaoDien.Properties.Resources.hide;
            }
            else
            {
                showpass = false;
                passText.UseSystemPasswordChar = false;
                hidepass.Image = global::GiaoDien.Properties.Resources.show;
            }
        }

        private void hiderepass_Click(object sender, EventArgs e)
        {
            if (!showrepass)
            {
                showrepass = true;
                repassText.UseSystemPasswordChar = true;
                hiderepass.Image = global::GiaoDien.Properties.Resources.hide;

            }
            else
            {
                showrepass = false;
                repassText.UseSystemPasswordChar = false;
                hiderepass.Image = global::GiaoDien.Properties.Resources.show;
            }
        }
    }
}
