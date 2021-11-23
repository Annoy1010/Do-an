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
    public partial class ThongTinSachMuon : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        string sql;
        DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu      
        string MAND = "lesyho";
        
        public ThongTinSachMuon()
        {
            InitializeComponent();
            //Loaddata();
            
        }

        
        private void Loaddata()
        {
            sql = string.Format("SELECT Book.MASA,Book.TENSA,Book.LOAISA,Book.NXB,Book.TACGIA,Book.TAIBAN,Borrow.NGAYMUON,Borrow.NGAYTRA FROM Borrow JOIN Book ON Borrow.MASA = Book.MASA WHERE Borrow.TENDN = N'{0}'", MAND);
            cnn.Open();
            com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com); //chuyen du lieu ve                   
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();
            dataGridView1.DataSource = dt;
        }
       
        private void ThongTinSachMuon_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        
    }
}
