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
using System.Configuration;
namespace TimKiemSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["CSDL"].ConnectionString;
        tb thongtin;
        private void Form1_Load(object sender, EventArgs e)
        {

            thongtin = new tb();
            try
            {
                dataGridView1.DataSource = thongtin.getTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        SqlDataAdapter DataAdapter;
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cs);
            string querry = "select *from book where TENSA  like N'%" + txtTimKiem.Text + "%'";
            DataTable dataTable = new DataTable();
            cn.Open();
            DataAdapter = new SqlDataAdapter(querry, cn);
            DataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            cn.Close();
        }
    }
}
