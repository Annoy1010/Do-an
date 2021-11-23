using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace CapNhatMatKhau
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cs))
            {
                try
                {
                    if (check())
                    {
                        cn.Open();
                        SHA256 sha256Hash = SHA256.Create();
                        string querry = "select *from LoginUser where MATKHAU='" + MaHoa.GetHash(sha256Hash, txtCurrentPass.Text) + "'";
                        string querry1 = "update LoginUser set MATKHAU='" + MaHoa.GetHash(sha256Hash,txtNewPass.Text) + "'";
                        string querry2 = "update UserAccount set MATKHAU='" + MaHoa.GetHash(sha256Hash,txtNewPass.Text) + "'where exists (select * from LoginUser where UserAccount.TENDN=LoginUser.TENDN)";
                        SqlCommand cmd = new SqlCommand(querry, cn);
                        SqlCommand cmd1 = new SqlCommand(querry1, cn);
                        SqlCommand cmd2 = new SqlCommand(querry2, cn);
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.Read())
                        {
                            dataReader.Close();
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            txtCurrentPass.Clear();
                            txtNewPass.Clear();
                            txtReNewPass.Clear();
                            MessageBox.Show("cập nhật mật khẩu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                        }
                        else
                        {
                            MessageBox.Show("mật khẩu hiện tại không đúng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        bool check()
        {
            if (string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                MessageBox.Show("bạn chưa nhập mật khẩu hiện tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("bạn chưa nhập mật khẩu mới", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtReNewPass.Text))
            {
                MessageBox.Show("bạn chưa xác nhận lại mật khẩu mới", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtNewPass.Text != txtReNewPass.Text)
            {
                MessageBox.Show("mật khẩu không trùng khớp", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReNewPass.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void txtReNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtReNewPass.Text != "")
            {
                if (txtReNewPass.Text != txtNewPass.Text)
                {
                    txtReNewPass.ForeColor = Color.Red;
                    pictureBox1.Show();
                    lblthongBao.ForeColor = Color.Red;
                    lblthongBao.Text = "mật khẩu không trùng khớp";
                }
                else
                {
                    txtReNewPass.ForeColor = Color.Black;
                    pictureBox1.Hide();
                    lblthongBao.Text = "";
                }
            }
            else
            {
                pictureBox1.Hide();
                lblthongBao.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrentPass.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtReNewPass.PasswordChar = '*';
        }
    }
}
