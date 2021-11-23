using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using LuuTaiKhoan.DAO;
namespace LuuTaiKhoan
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
                        /*CurrentAccount.Instance.SetAccount(user);
                        ManageUser userMg = new ManageUser();
                        this.Hide();
                        userMg.ShowDialog();
                        this.Show();*/
                        if (checkSave.Checked == false)//Chỉ thêm phần code này thôi nha
                        {
                            usernameText.Clear();
                            passText.Clear();
                        }

                    }
                    else
                    {
                        /*CurrentAccount.Instance.SetAccount(user);
                        ManageAdmin adminMg = new ManageAdmin();
                        this.Hide();
                       adminMg.ShowDialog();
                        this.Show();*/

                        if (checkSave.Checked == false)//Chỉ thêm phần code này thôi nha
                        {
                            usernameText.Clear();
                            passText.Clear();
                        }
                    }
                }

            
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

  
    }
}

