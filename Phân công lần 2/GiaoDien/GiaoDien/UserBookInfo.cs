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
    public partial class UserBookInfo : Form
    {
        public UserBookInfo()
        {
            InitializeComponent();
            ShowBookData();
        }
        void ShowBookData()
        {
            string query = "SELECT TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        DataTable SearchBook()
        {
            string query = "SELECT TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book WHERE TENSA  like N'%" + booksearchText.Text + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBook().Rows.Count == 0)
                MessageBox.Show("Không thấy dữ liệu sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                data.DataSource = SearchBook();
        }

        private void bookListBtn_Click(object sender, EventArgs e)
        {
            ShowBookData();
        }
    }
}
