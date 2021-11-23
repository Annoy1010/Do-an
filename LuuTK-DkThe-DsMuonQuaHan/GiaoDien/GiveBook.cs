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
    public partial class GiveBook : Form
    {
        bool itemClick = false;
        int CurrentRowPos;
        string bookId;
        string status;
        string quantity;
        public GiveBook()
        {
            InitializeComponent();
            ShowBorrowData();
        }
        void ShowBorrowData()
        {
            string query = string.Format("SELECT Borrow.MASA 'Mã sách', Book.TENSA 'Tên sách',Book.LOAISA 'Loại sách', Book.TACGIA 'Tác giả', Borrow.NGAYMUON 'Ngày mượn',Borrow.HANTRA 'Hạn ngày trả', Borrow.NGAYTRA 'Ngày trả', Borrow.SOLUONG 'Số lượng đã mượn', Borrow.DATRA 'Đã trả' FROM Borrow JOIN Book ON Borrow.MASA = Book.MASA WHERE Borrow.TENDN = N'{0}'", CurrentAccount.Instance.GetAccount());
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void borrowBookListBtn_Click(object sender, EventArgs e)
        {
            ShowBorrowData();
        }

        private void giveBookBtn_Click(object sender, EventArgs e)
        {
            if (itemClick == false)
                MessageBox.Show("Vui lòng chọn thông tin sách muốn trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (status == "True")
                {
                    MessageBox.Show("Sách đã trả!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (GiveBookToLibrary() > 0)
                    {
                        MessageBox.Show("Trả sách thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateBookData();
                        ShowBorrowData();
                    }
                
                }
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRowPos = data.CurrentRow.Index;
            bookId = data.Rows[CurrentRowPos].Cells[0].Value.ToString();
            quantity = data.Rows[CurrentRowPos].Cells[7].Value.ToString();
            status = data.Rows[CurrentRowPos].Cells[8].Value.ToString();
            itemClick = true;
        }

        int GiveBookToLibrary()
        {
            int nRowSuccess = 0;
            try
            {
                string query = "UPDATE Borrow SET NGAYTRA = '" + DateTime.Now.ToString("MM-dd-yyyy") + "', DATRA = 1 WHERE TENDN = '" + CurrentAccount.Instance.GetAccount() + "' AND MASA = '" + bookId + "'";
                nRowSuccess = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return nRowSuccess;
        }
        void UpdateBookData()
        {
            string query = "UPDATE Book SET SOLUONG = (SOLUONG + " + quantity + ") WHERE  MASA = '" + bookId + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
