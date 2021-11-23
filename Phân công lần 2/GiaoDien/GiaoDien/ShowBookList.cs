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
    public partial class ShowBookList : Form
    {
        int iClicking;
        bool clicked;
        public ShowBookList()
        {
            InitializeComponent();
            ShowBookData();
            clicked = false;
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
                CurrentFormChild.Close();
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            subLayout.Controls.Add(ChildForm);
            subLayout.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        void ShowBookData()
        {
            string query = "SELECT MASA 'Mã sách', TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        DataTable SearchBook()
        {
            string query = "SELECT MASA 'Mã sách', TENSA 'Tên sách', LOAISA 'Loại sách', NXB 'Nhà xuất bản', TACGIA 'Tác giả', TAIBAN 'Tái bản', SOLUONG 'Số lượng' FROM Book WHERE TENSA  like N'%" + booksearchText.Text + "%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBook().Rows.Count == 0)
                MessageBox.Show("Không thấy dữ liệu sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                data.DataSource = SearchBook();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                MessageBox.Show("Mời chọn sách muốn mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string bookId = data.Rows[iClicking].Cells[0].Value.ToString();
                string bookTitle = data.Rows[iClicking].Cells[1].Value.ToString();
                string bookType = data.Rows[iClicking].Cells[2].Value.ToString();
                string publisher = data.Rows[iClicking].Cells[3].Value.ToString();
                string author = data.Rows[iClicking].Cells[4].Value.ToString();
                string edition = data.Rows[iClicking].Cells[5].Value.ToString();
                string quantity = data.Rows[iClicking].Cells[6].Value.ToString();
                ChosedBook.Instance.SetData(bookId, bookTitle, bookType, publisher, author, edition, quantity);
                OpenChildForm(new ChosedBorrowedBook());
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iClicking = data.CurrentRow.Index;
            clicked = true;
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentRow.Index;
            string bookId = data.Rows[i].Cells[0].Value.ToString();
            string bookTitle = data.Rows[i].Cells[3].Value.ToString();
            string bookType = data.Rows[i].Cells[5].Value.ToString();
            string publisher = data.Rows[i].Cells[6].Value.ToString();
            string author = data.Rows[i].Cells[4].Value.ToString();
            string edition = data.Rows[i].Cells[1].Value.ToString();
            string quantity = data.Rows[i].Cells[2].Value.ToString();
            ChosedBook.Instance.SetData(bookId, bookTitle, bookType, publisher, author, edition, quantity);
            OpenChildForm(new ChosedBorrowedBook());
        }
    }
}
