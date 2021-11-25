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
    public partial class InsertImage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;User ID=sa;Password=123");
        SqlCommand com;
        public InsertImage()
        {
            InitializeComponent();
        }

        
        private void loadImage(PictureBox picBoxClick)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string strFile = file.FileName;
                Image img = Image.FromFile(strFile);
                picBoxClick.Image = img;
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            loadImage(pictureBox2);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            loadImage(pictureBox1);
        }
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            loadImage(pictureBox3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bImage1 = ImageToByte(pictureBox1.Image);
            byte[] bImage2 = ImageToByte(pictureBox2.Image);
            byte[] bImage3 = ImageToByte(pictureBox3.Image);
           
            conn.Open();
            com = new SqlCommand("INSERT INTO Book VALUES ('SA2','TÊN NÈ HE','LOAISANE','NXBNE','TGA',3,5,@image1,@image2,@image3)",conn);
            com.Parameters.Add("@image1", bImage1);
            com.Parameters.Add("@image2", bImage2);
            com.Parameters.Add("@image3", bImage3);                     
            if (com.ExecuteNonQuery() >0)
            {
                MessageBox.Show("thêm thành công");
            }
            else
            {
                MessageBox.Show("lỗi rồi");
            }
            conn.Close();
        }
        byte[] ImageToByte(Image img)
        {
            MemoryStream mStream = new MemoryStream();
            img.Save(mStream, System.Drawing.Imaging.ImageFormat.Png);
            return mStream.ToArray();
        }
    }
}
