using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.DAO;
using System.Data.SqlClient;
namespace GiaoDien
{
    public partial class LoadImage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;User ID=sa;Password=123");
        SqlCommand com;
        string masach = "SA2";
        public LoadImage()
        {
            InitializeComponent();
        }       
        private void LoadImage_Load(object sender, EventArgs e)
        {
                   
            conn.Open();
            pictureBox1.Image = LoadData("IMAGE1");
            pictureBox2.Image = LoadData("IMAGE2");
            pictureBox3.Image = LoadData("IMAGE3");
            conn.Close();
        }
        private Image LoadData(string imageName)
        {
            String query = string.Format("SELECT {0} FROM Book WHERE MASA='{1}'",imageName,masach);
            com = new SqlCommand(query, conn);
            Byte[] image = (Byte[])com.ExecuteScalar(); ;
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }
    
    }
}
