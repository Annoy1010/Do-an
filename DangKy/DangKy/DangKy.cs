using DangKy.DAO;
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

namespace DangKy
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string repass = textBox3.Text;
            string fullname = textBox4.Text;
            string age = textBox5.Text;
            string passport = textBox6.Text;
            string phone = textBox7.Text;
            if (IsNullData(user, pass, repass, fullname, age, passport, phone))
                MessageBox.Show("Nhập không đủ thông tin. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (pass.Length < 6)
                    MessageBox.Show("Mật khẩu không đủ mạnh. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!SubmitPassCorrect(pass, repass))
                        MessageBox.Show("Mật khẩu xác nhận không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (!IsValidNumber(age))
                            MessageBox.Show("Thông tin 'Tuổi' không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (!IsValidNumber(passport) || passport.Length < 9)
                            MessageBox.Show("Thông tin 'Chứng minh nhân dân ' không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (!IsValidNumber(phone) || phone.Length < 10)
                            MessageBox.Show("Thông tin 'Số điện thoại' không chính xác. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            string passCode = ConvertPassword(pass);
                            if (CheckUserExist(user, passCode, fullname, age, passport, phone) == 0)  /// Bị lỗi khi trùng tên đăng nhập
                                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng kiểm tra lại.");
                            else
                            {
                                MessageBox.Show("Đăng ký thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                            }
                        }
                    }
                }
            }
        }
        bool IsNullData(string user, string pass, string repass, string fullname, string age, string passport, string phone)
        {
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(repass) || String.IsNullOrEmpty(fullname) || String.IsNullOrEmpty(age) || String.IsNullOrEmpty(passport) || String.IsNullOrEmpty(phone))
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
            if (Int64.Parse(str) < 0)
                return false;
            return true;
        }

        bool SubmitPassCorrect(string pass, string repass)
        {
            return repass == pass;
        }

        int CheckUserExist(string user, string pass, string fullname, string age, string passport, string phone)
        {
            string query = "EXEC Add_Account @TENDN , @MATKHAU , @HOTEN , @TUOI , @CMND , @SDT , @QUYENMUON , @QUYENQL";
            int SuccessRows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, pass, fullname, age, passport, phone, 1, 0 });
            return SuccessRows;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ConvertPassword(string pass)
        {
            SHA256 sh = SHA256.Create();
            HashAlgorithm hash = HashAlgorithm.Create();
            byte[] code = hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
            StringBuilder sb = new StringBuilder();
            foreach (var item in code)
                sb.Append(item.ToString("x"));
            return sb.ToString();
        }
        bool showpass = true;
        bool showrepass = true;
        private void hidepassword_Click(object sender, EventArgs e)
        {
            if (!showpass)
            {
                showpass = true;
                textBox2.UseSystemPasswordChar = true;
                hidepassword.Image = Image.FromFile(@"E:\Projects\Lập trình trực quan\Phần mềm\Img\hide.png");
            }
            else
            {
                showpass = false;
                textBox2.UseSystemPasswordChar = false;
                hidepassword.Image = Image.FromFile(@"E:\Projects\Lập trình trực quan\Phần mềm\Img\show.png");
            }
        }

        private void hiderepassword_Click(object sender, EventArgs e)
        {
            if (!showrepass)
            {
                showrepass = true;
                textBox3.UseSystemPasswordChar = true;
                hiderepassword.Image = Image.FromFile(@"E:\Projects\Lập trình trực quan\Phần mềm\Img\hide.png");
            }
            else
            {
                showrepass = false;
                textBox3.UseSystemPasswordChar = false;
                hiderepassword.Image = Image.FromFile(@"E:\Projects\Lập trình trực quan\Phần mềm\Img\show.png");
            }
        }

    }
}
