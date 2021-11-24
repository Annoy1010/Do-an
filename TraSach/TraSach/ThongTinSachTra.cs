using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TraSach
{
    public partial class ThongTinSachTra : Form
    {

        string user = "Lilwuyn";
        string maSa;
        string soLuong;
        int index;
        string ngayTra;
        string updateBor;
        string updateBook;
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strcon = @"Data Source=LAPTOP-317MM1BK\SQLEXPRESS;Initial Catalog=SQL_Library;Persist Security Info=True;User ID=panda;Password=17032003";
        SqlDataAdapter sqlAdar = new SqlDataAdapter();
        DataTable dtTable = new DataTable();
        public ThongTinSachTra()
        {
            InitializeComponent();
        }

        private void ThongTinSachTra_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strcon);
            sqlCon.Open();
            this.LoadData();
            sqlCon.Close();
        }

        private void LoadData()
        {
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = " SELECT *FROM Borrow WHERE TENDN ='" + user + "'";
            sqlAdar.SelectCommand = sqlCmd;
            dtTable.Clear();
            sqlAdar.Fill(dtTable);
            dataBorrowBook.DataSource = dtTable;
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {

            if (ngayTra != "")
            {
                MessageBox.Show("Sách đã trả!");
            }
            else
            {              
                string day = DateTime.Now.ToShortDateString();
                try
                {
                    sqlCon = new SqlConnection(strcon);
                    sqlCon.Open();
                    updateBor = "update Borrow set NGAYTRA = '" + day + "' where TENDN ='" + user + "' AND maSa = '" + maSa + "'";
                    updateBook = "update Book set SOLUONG = (SOLUONG + " + soLuong + ") where  maSa = '" + maSa + "'";
                    sqlCmd = new SqlCommand(updateBor, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd = new SqlCommand(updateBook, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Trả sách thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void dataBorrowBook_Click(object sender, EventArgs e)
        {
            index = dataBorrowBook.CurrentRow.Index;
            maSa = dataBorrowBook.Rows[index].Cells[1].Value.ToString();
            ngayTra = dataBorrowBook.Rows[index].Cells[3].Value.ToString();
            soLuong = dataBorrowBook.Rows[index].Cells[4].Value.ToString();
        }
    }
}
