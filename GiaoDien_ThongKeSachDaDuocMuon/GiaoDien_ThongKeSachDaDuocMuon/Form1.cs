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
            string query = "SELECT BORROW.MASA, BOOK.TENSA, COUNT(Borrow.MASA) AS SOLUONGDAMUON, (BOOK.SOLUONG - COUNT(Borrow.MASA)) AS SOLUONGCONLAI FROM BORROW, BOOK WHERE BORROW.MASA = BOOK.MASA GROUP BY Borrow.MASA, BOOK.TENSA, BOOK.SOLUONG";
            dataGridView1.DataSource = provider.ExcuteQuery(query);    
        }
    }
}
