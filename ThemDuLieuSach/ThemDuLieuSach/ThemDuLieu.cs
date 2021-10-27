using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemDuLieuSach.DAO;

namespace ThemDuLieuSach
{
    public partial class ThemDuLieu : Form
    {
        public ThemDuLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string bookId = textBox1.Text;
            string bookTitle = textBox2.Text;
            string bookType = textBox3.Text;
            string publisher = textBox4.Text;
            string author = textBox5.Text;
            string edition = textBox6.Text;
            string quantity = textBox7.Text;
            if (IsNullData(bookId, bookTitle, bookType, publisher, author, edition, quantity))
                MessageBox.Show("Nhập không đủ dữ liệu. Vui lòng kiểm tra lại.");
            else
            {
                if (!IsValidNumber(edition))
                    MessageBox.Show("Thông tin 'Lần tái bản' không hợp lệ. Vui lòng kiểm tra lại.");
                else if (!IsValidNumber(quantity))
                    MessageBox.Show("Thông tin 'Số lượng' không hợp lệ. Vui lòng kiểm tra lại.");
                else
                {
                    if (InsertBookData(bookId, bookTitle, bookType, publisher, author, edition, quantity) == 0)
                        MessageBox.Show("Mã sách đã tồn tại. Vui lòng kiểm tra lại.");
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        bool IsNullData(string bookId, string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            if (String.IsNullOrEmpty(bookId) || String.IsNullOrEmpty(bookTitle) || String.IsNullOrEmpty(bookType) || String.IsNullOrEmpty(publisher) || String.IsNullOrEmpty(author) || String.IsNullOrEmpty(edition) || String.IsNullOrEmpty(quantity))
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
        int InsertBookData(string bookId, string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            string query = "EXEC Add_Book @MASA , @TENSA , @LOAISA , @NXB , @TACGIA , @TAIBAN , @SOLUONG";
            int SuccessRows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { bookId, bookTitle, bookType, publisher, author, edition, quantity });
            return SuccessRows;
        }
    }
}
