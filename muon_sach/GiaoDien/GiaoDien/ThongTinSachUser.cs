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

namespace GiaoDien
{
    public partial class ThongTinSachUser : Form
    {
        List<books> listBooks;
        SqlConnection cnn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        int iClicking;
        bool clicked ;
        private List<books> SetListBooks(DataTable dta)
        {
            List<books> list = new List<books>();
            foreach (DataRow item in dta.Rows)
            {
                books book = new books(item);
                list.Add(book);
            }
            return list;
        }
        private List<books> Connect(string sql)
        {
            cnn.Open();            
            com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu          
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();
            List<books> conListBooks = SetListBooks(dt);
            return conListBooks;
        }
        private void Loaddata()
        {
            listBooks= Connect("select * from Book");
            dataGridView1.DataSource = listBooks; //đổ dữ liệu vào datagridview
        }
        private void searchBooksByName(string name)
        {
            string sql = string.Format("SELECT * FROM dbo.Book WHERE dbo.fuConvertToUnsign1(TENSA) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            List<books> searchList = Connect(sql);
            dataGridView1.DataSource = searchList;
        }
        public ThongTinSachUser()
        {
            InitializeComponent();
            clicked = false;
        }

        private void ThongTinSachUser_Load(object sender, EventArgs e)
        {
            
            Loaddata();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtDangNhap != null)
            {
                searchBooksByName(txtDangNhap.Text);
            }
            else
            {
                Loaddata();
            }
            
        }

       

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                MessageBox.Show("Mời chọn sách muốn thuê","THÔNG BÁO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                string masa = dataGridView1.Rows[iClicking].Cells[0].Value.ToString();
                string tensa = dataGridView1.Rows[iClicking].Cells[3].Value.ToString();
                string loaisa= dataGridView1.Rows[iClicking].Cells[5].Value.ToString();
                string nxb= dataGridView1.Rows[iClicking].Cells[6].Value.ToString();
                string tacgia= dataGridView1.Rows[iClicking].Cells[4].Value.ToString();
                int taiban=(int)dataGridView1.Rows[iClicking].Cells[1].Value;
                int soluong =(int)dataGridView1.Rows[iClicking].Cells[2].Value;
                //books bookClick = new books(masa,tensa,loaisa,nxb,tacgia,taiban,soluong);
                MuonSach form1 = new MuonSach(masa,tensa, loaisa, nxb, tacgia, taiban, soluong);
                
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            string masa = dataGridView1.Rows[i].Cells[0].Value.ToString();
            string tensa = dataGridView1.Rows[i].Cells[3].Value.ToString();
            string loaisa = dataGridView1.Rows[i].Cells[5].Value.ToString();
            string nxb = dataGridView1.Rows[i].Cells[6].Value.ToString();
            string tacgia = dataGridView1.Rows[i].Cells[4].Value.ToString();
            int taiban = (int)dataGridView1.Rows[i].Cells[1].Value;
            int soluong = (int)dataGridView1.Rows[i].Cells[2].Value;
            MuonSach form2 = new MuonSach(masa,tensa, loaisa, nxb, tacgia, taiban, soluong);
            
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iClicking = dataGridView1.CurrentRow.Index;
            //maClicking = (int)dataGridView1.Rows[i].Cells[0].Value;
            clicked = true;
        }
    
    }
}
