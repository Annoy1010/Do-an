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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passText.Text;
            if (CheckCorrectUser(user, pass).Rows.Count == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameText.Focus();
                usernameText.SelectAll();
                passText.Clear();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (IsAdmin(user).Rows.Count == 0)
                {
                    CurrentAccount.Instance.SetAccount(user);
                    ManageUser userMg = new ManageUser();
                    this.Hide();
                    userMg.ShowDialog();
                    this.Show();
                    usernameText.Clear();
                    passText.Clear();
                }
                else
                {
                    CurrentAccount.Instance.SetAccount(user);
                    ManageAdmin adminMg = new ManageAdmin();
                    this.Hide();
                    adminMg.ShowDialog();
                    this.Show();
                    usernameText.Clear();
                    passText.Clear();
                }
            }

        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.ShowDialog();
            this.Show();
            passText.Clear();
            usernameText.Clear();
        }

        bool showpass = true;
        DataTable CheckCorrectUser(string user, string pass)
        {
            SHA256 sha256Hash = SHA256.Create();
            string query = "SELECT * FROM UserAccount WHERE TENDN = '" + user + "' AND MATKHAU = '" + EnCode.GetHash(sha256Hash, pass) + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        DataTable IsAdmin(string user)
        {
            string query = "SELECT* FROM UserAccount WHERE TENDN = '" + user + "' AND QUYENQL = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        private void hidepass_Click(object sender, EventArgs e)
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

        private void forgotpassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpassLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }
    }
}
