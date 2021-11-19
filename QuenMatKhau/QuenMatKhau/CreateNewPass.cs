using QuenMatKhau.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuenMatKhau
{
    public partial class CreateNewPass : Form
    {
        Thread th;
        public CreateNewPass()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string newPass = passText.Text;
            string rePass = repassText.Text;
            SHA256 sha256Hash = SHA256.Create();
            string convertpass = EnCode.GetHash(sha256Hash, newPass);
            if (newPass.Length < 6 || rePass.Length < 6)
                MessageBox.Show("Độ dài mật khẩu quá ngắn. Vui lòng thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (!CorrectSubmit(newPass, rePass))
                    MessageBox.Show("Mật khẩu xác nhận không hợp lệ. Vui lòng thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (UpdatePass(convertpass) > 0)
                    {
                        DialogResult result = MessageBox.Show("Khôi phục tài khoản thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            DisplayNewForm();
                        }
                    }
                }
            }
        }
        private void ReturnSignIn()
        {
            Application.Run(new Form1());
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplayNewForm();
        }
        bool CorrectSubmit(string pass, string repass)
        {
            return pass == repass;
        }
        int UpdatePass(string pass)
        {
            string query = "UPDATE UserAccount SET MATKHAU = '" + pass + "' WHERE EMAIL = '" + EmailResetPass.Instance.GetEmail() + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        bool showpass = true;
        bool showrepass = true;
        private void hidepass_Click(object sender, EventArgs e)
        {
            if (!showpass)
            {
                showpass = true;
                passText.UseSystemPasswordChar = true;
                hidepass.Image = global::QuenMatKhau.Properties.Resources.hide;
            }
            else
            {
                showpass = false;
                passText.UseSystemPasswordChar = false;
                hidepass.Image = global::QuenMatKhau.Properties.Resources.show;
            }
        }

        private void hiderepass_Click(object sender, EventArgs e)
        {
            if (!showrepass)
            {
                showrepass = true;
                repassText.UseSystemPasswordChar = true;
                hiderepass.Image = global::QuenMatKhau.Properties.Resources.hide;

            }
            else
            {
                showrepass = false;
                repassText.UseSystemPasswordChar = false;
                hiderepass.Image = global::QuenMatKhau.Properties.Resources.show;
            }
        }
        void DisplayNewForm()
        {
            th = new Thread(ReturnSignIn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
