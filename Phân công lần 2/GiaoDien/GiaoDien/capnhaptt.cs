using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien
{
    public partial class capnhaptt : Form
    {
        public capnhaptt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            string fullname = nameText.Text;
            string age = agetb.Text;
            string passport = passportText.Text;
            string phone = phoneText.Text;
            string email = emailText.Text;
            if (IsNullData(fullname, age, passport, phone, email))
                MessageBox.Show("Nhập không đủ thông tin. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    CheckUserExist(CurrentAccount.Instance.GetAccount(), fullname, age, passport, phone, email);

                    MessageBox.Show("Đăng ký thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            bool IsNullData(   string fullName, string tuoi, string passp, string phones, string mail)
            {
                if (  String.IsNullOrEmpty(fullName) || String.IsNullOrEmpty(tuoi) || String.IsNullOrEmpty(passp) || String.IsNullOrEmpty(phones) || String.IsNullOrEmpty(mail))
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
            bool IsValidEmail(string emails)
            {
                if (emails.Trim().EndsWith(".") || !emails.Contains(".") || !emails.Contains("@"))
                    return false;
                try
                {
                    var addr = new System.Net.Mail.MailAddress(emails);
                    return addr.Address == emails;
                }
                catch
                {
                    return false;
                }
            }
           

            void CheckUserExist(string user,  string fullName, string tuoi, string passp, string phones, string mail)
            {
                string query = string.Format("UPDATE  UserAccount SET HOTEN=N'{0}',TUOI={1},CMND={2},SDT='{3}',EMAIL='{4}' WHERE TENDN='lesyhoi' ", fullName,int.Parse(tuoi), int.Parse(passp),phones,mail);
                int i=DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show(i.ToString());
            }
        }
    }

