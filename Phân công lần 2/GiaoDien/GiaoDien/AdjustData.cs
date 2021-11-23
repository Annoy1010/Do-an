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
    public partial class AdjustData : Form
    {
        public AdjustData()
        {
            InitializeComponent();
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;
            ShowBookData();
        }
        void ShowBookData()
        {
            string query = "SELECT MASA 'Mã sách', TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void updBtn_Click(object sender, EventArgs e)
        {
            string bookId = bookIDText.Text;
            string bookTitle = bookTitleText.Text;
            string bookType = bookTypeText.Text;
            string publisher = publishText.Text;
            string author = authorText.Text;
            string edition = editText.Text;
            string quantity = quantityText.Text;
            if (IsNullData(bookId, bookTitle, bookType, publisher, author, edition, quantity))
                MessageBox.Show("Nhập không đủ dữ liệu. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!IsValidNumber(edition))
                    MessageBox.Show("Thông tin 'Lần tái bản' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!IsValidNumber(quantity))
                    MessageBox.Show("Thông tin 'Số lượng' không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (UpdateBook(bookId, bookTitle, bookType, publisher, author, edition, quantity) == 0)
                        MessageBox.Show("Mã sách không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowBookData();
                        bookTitleText.Clear();
                        bookTypeText.Clear();
                        publishText.Clear();
                        authorText.Clear();
                        editText.Clear();
                        quantityText.Clear();
                    }
                }
            }
        }
        bool IsNullData(string bookID, string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            if (String.IsNullOrEmpty(bookID) || String.IsNullOrEmpty(bookTitle) || String.IsNullOrEmpty(bookType) || String.IsNullOrEmpty(publisher) || String.IsNullOrEmpty(author) || String.IsNullOrEmpty(edition) || String.IsNullOrEmpty(quantity))
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
        int UpdateBook(string bookID, string bookTitle, string bookType, string publisher, string author, string edition, string quantity)
        {
            string query = "UPDATE Book SET TENSA = N'" + bookTitle + "', LOAISA = N'" + bookType + "', NXB = N'" + publisher + "', TACGIA = N'" + author + "', TAIBAN = " + edition + ", SOLUONG = " + quantity + " WHERE MASA = '" + bookID + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                bookIDText.Text = data.Rows[index].Cells["Mã sách"].Value.ToString();
                bookTitleText.Text = data.Rows[index].Cells["Tên sách"].Value.ToString();
                bookTypeText.Text = data.Rows[index].Cells["Loại sách"].Value.ToString();
                publishText.Text = data.Rows[index].Cells["Nhà xuất bản"].Value.ToString();
                authorText.Text = data.Rows[index].Cells["Tác giả"].Value.ToString();
                editText.Text = data.Rows[index].Cells["Tái bản"].Value.ToString();
                quantityText.Text = data.Rows[index].Cells["Số lượng"].Value.ToString();
            }
        }

        
    }
}
