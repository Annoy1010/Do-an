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
    public partial class ThongTinThanhVien : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        string sql;
        DataTable dt = new DataTable();
        public ThongTinThanhVien()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            //sql = string.Format("SELECT HOTEN,TUOI,CMND,SDT FROM UserAccount");
            cnn.Open();
            com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);
            da.Fill(dt);
            cnn.Close();
            
        }
        private void ThongTinThanhVien_Load(object sender, EventArgs e)
        {
            sql = string.Format("SELECT HOTEN,TUOI,CMND,SDT FROM UserAccount");
            Connect();
            dataGridView1.DataSource = dt;            
            dt.Clear();
            sql = string.Format("SELECT UA.HOTEN,UA.TUOI,UA.CMND,UA.SDT,BR.NGAYMUON FROM UserAccount UA FULL JOIN Borrow BR ON UA.TENDN = BR.TENDN");
            Connect();
            dataGridView2.DataSource = dt;
        }
    }
}
