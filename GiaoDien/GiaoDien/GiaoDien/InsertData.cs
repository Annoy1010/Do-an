using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
            ShowBookData();
        }
        void ShowBookData()
        {
            string query = "SELECT MASA 'Mã sách', TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string bookTitle = bookTitleText.Text;
            string bookType = bookTypeText.Text;
            string publisher = publishText.Text;
            string author = authorText.Text;
            string edition = editText.Text;
            string quantity = quantityText.Text;
            if (IsNullData(bookTitle, bookType, publisher, author, edition, quantity))
                MessageBox.Show("Nhập không đủ dữ liệu. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!IsValidNumber(edition))
                    MessageBox.Show("Thông tin 'Lần tái bản' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!IsValidNumber(quantity))
                    MessageBox.Show("Thông tin 'Số lượng' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    InsertBookData(bookTitle, bookType, publisher, author, edition, quantity);
                    MessageBox.Show("Thêm dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bookTitleText.Clear();
                    bookTypeText.Clear();
                    publishText.Clear();
                    authorText.Clear();
                    editText.Clear();
                    quantityText.Clear();
                    ShowBookData();
                }
            }
        }
        bool IsNullData(string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            if ( String.IsNullOrEmpty(bookTitle) || String.IsNullOrEmpty(bookType) || String.IsNullOrEmpty(publisher) || String.IsNullOrEmpty(author) || String.IsNullOrEmpty(edition) || String.IsNullOrEmpty(quantity))
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
        void InsertBookData(string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            string bookId;
            int SuccessRows = 0;
            while (SuccessRows <= 0)
            {
                bookId = Random().ToString();
                string query = "EXEC Add_Book @MASA , @TENSA , @LOAISA , @NXB , @TACGIA , @TAIBAN , @SOLUONG";
                SuccessRows = DataProvider.Instance.ExecuteNonQuery(query, new object[] { bookId, bookTitle, bookType, publisher, author, edition, quantity });
            }
        }
        int Random()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999);
        }

        
    }
}
