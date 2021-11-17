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
   
    public partial class MuonSach : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=LESYHOI;Initial Catalog=LTTQDA;Integrated Security=True");
        SqlCommand com;
       
        string sql;
        string Masa;
        string Tensa;
        string Loaisa;
        string Nxb;
        string Tacgia;
        int Taiban;
        int Soluong;

        public MuonSach(string masa,string tensa, string loaisa, string nxb, string tacgia, int taiban, int soluong)
        {
            InitializeComponent();
            Masa = masa;
            Tensa = tensa;
            Tacgia = tacgia;
            Nxb = nxb;
            Taiban = taiban;
            Soluong = soluong;
            Loaisa = loaisa;
            
        }
        

        private void MuonSach_Load(object sender, EventArgs e)
        {
            label1.Text = Tensa;
            label3.Text = Tacgia;
            label10.Text = Nxb;
            label11.Text = Taiban.ToString();
            label7.Text = Soluong.ToString();
            label9.Text = Loaisa;
            numUpDown.Maximum = Soluong;
            
        }

        private void Muon_Click(object sender, EventArgs e)
        {
            if (numUpDown.Value ==0)
            {
                MessageBox.Show("Mời bạn chọn số lượng sách muốn mượn!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string text = string.Format("Bạn chắc chắn muốn mượn sách {0} này!", Tensa);
            string caption = "THÔNG BÁO!";
            MessageBoxButtons mesbt = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(text, caption, mesbt);
            if (result == DialogResult.Yes)
            {
                DateTime day = DateTime.Now;
                DateTime lastDay = new DateTime(day.Year, day.Month, day.Day + 15);
                string tendn = "lesyhoi";
                sql = @"INSERT INTO BORROW VALUES(N'" + tendn + @"',N'" + Masa + @"',N'" + day + @"',N'" + lastDay + @"',N'" + numUpDown.Value + @"')";
                cnn.Open();
                com = new SqlCommand(sql, cnn);
                int i = com.ExecuteNonQuery();
                cnn.Close();
                if (i != 0)
                {
                    MessageBox.Show("Mượn sách thành công!");
                }
            }
        }
    }
}
