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
    public partial class RemoveData : Form
    {
        public RemoveData()
        {
            InitializeComponent();
            LoadBookList();
        }
        void LoadBookList()
        {
            string query = "SELECT MASA 'Mã sách', TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBook().Rows.Count == 0)
                MessageBox.Show("Không thấy dữ liệu sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                data.DataSource = SearchBook();
        }
        DataTable SearchBook()
        {
            string query = "SELECT TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book WHERE TENSA  like N'%" + booksearchText.Text + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            object bookID = data.SelectedCells[0].Value;
            string ID = bookID.ToString();
            DialogResult acp = MessageBox.Show("Bạn có chắc chắn xóa hủy?", "Thông báo", MessageBoxButtons.YesNo);
            if (acp == DialogResult.Yes)
            {
                RemoveBook(ID);
                MessageBox.Show("Bạn đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OKCancel);
                LoadBookList();
            }
        }
        void RemoveBook(string ID)
        {
            string query = "DELETE FROM Book WHERE MASA = '" + ID + "'";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
