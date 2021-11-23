using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien_ThongKeSachDaDuocMuon.DAO;

namespace GiaoDien_ThongKeSachDaDuocMuon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadBooksWasBorrowed();
        }

        private void LoadBooksWasBorrowed()
        {
            DataProvider provider = new DataProvider();
            string query = "select Borrow.MASA, Book.TENSA, SUM(Borrow.Soluong) as sachdangmuon, (Book.SOLUONG - sum(Borrow.SOLUONG)) as soluongconlai   from Borrow, Book where (Borrow.MASA = Book.MASA and Borrow.DATRA = 0) Group by Borrow.MASA, Book.TENSA, book.SOLUONG order by Borrow.MASA asc";
            dataGridView1.DataSource = provider.ExcuteQuery(query);    
        }
    }
}
