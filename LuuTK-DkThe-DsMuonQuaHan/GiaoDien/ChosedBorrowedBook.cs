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
    public partial class ChosedBorrowedBook : Form
    {
        public ChosedBorrowedBook()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            bookTitle.Text = ChosedBook.Instance.GetBookTitle();
            bookType.Text = ChosedBook.Instance.GetBookType();
            publisher.Text = ChosedBook.Instance.GetPublisher();
            author.Text = ChosedBook.Instance.GetAuthor();
            edition.Text = ChosedBook.Instance.GetEdition();
            quantity.Text = ChosedBook.Instance.GetQuantity();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            if (BorrowRule().Rows.Count == 0)
                MessageBox.Show("Bạn không còn quyền mượn sách!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (numUpDown.Value == 0)
                {
                    MessageBox.Show("Mời bạn chọn số lượng sách muốn mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string text = string.Format("Bạn chắc chắn muốn mượn sách '{0}'!", bookTitle.Text);
                string caption = "Thông báo";
                MessageBoxButtons mesbt = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(text, caption, mesbt);
                if (result == DialogResult.Yes)
                {
                    DateTime day = DateTime.Now;
                    DateTime lastDay = day.AddDays(15);
                    if (BorrowBook(day, lastDay, numUpDown.Value.ToString()) > 0)
                    {
                        MessageBox.Show("Mượn sách thành công!", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(lastDay.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable data = CurrentBookQuantity();
                        int CurrentQuantity = Int32.Parse(data.Rows[0]["SOLUONG"].ToString());
                        int AfterBorrowQuantity = CurrentQuantity - Int32.Parse(numUpDown.Value.ToString());
                        UpdateAfterBorrow(AfterBorrowQuantity.ToString());
                        quantity.Text = AfterBorrowQuantity.ToString();
                    }
                }
            }
        }
        int BorrowBook(DateTime now, DateTime end, string quantity)
        {
            int nRowSuccess = 0;
            try
            {
                string query = "INSERT INTO Borrow VALUES ('" + CurrentAccount.Instance.GetAccount() + "', '" + ChosedBook.Instance.GetBookID() + "', '" + now.ToString("MM-dd-yyyy") + "', '" + end.ToString("MM-dd-yyyy") + "', NULL, " + quantity + ", 0)";
                nRowSuccess = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã mượn sách này. Vui lòng trả sách trước khi muốn mượn lần tiếp theo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return nRowSuccess;
        }
        DataTable CurrentBookQuantity()
        {
            string query = "SELECT SOLUONG FROM Book WHERE MASA = '" + ChosedBook.Instance.GetBookID() + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        DataTable UpdateAfterBorrow(string number)
        {
            string query = "UPDATE Book SET SOLUONG = " + number + " WHERE MASA = '" + ChosedBook.Instance.GetBookID() + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        DataTable BorrowRule()
        {
            string query = "SELECT * FROM UserAccount WHERE TENDN = '" + CurrentAccount.Instance.GetAccount() + "' AND QUYENMUON = 1";
            return DataProvider.Instance.ExecuteQuery(query);
        } 
    }
}
