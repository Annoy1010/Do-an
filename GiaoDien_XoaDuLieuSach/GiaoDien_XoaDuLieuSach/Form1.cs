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
using GiaoDien.DAO;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadBookList();
        }
        void LoadBookList()
        {
            string query = "select * from book";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExcuteQuery(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            object usernameData = dataGridView1.SelectedCells[0].Value;
            string username = usernameData.ToString();
            DialogResult acp = MessageBox.Show("Bạn có chắc chắn xóa hủy ?", "Thông báo", MessageBoxButtons.YesNo);
            if (acp == DialogResult.Yes)
            {
                RemoveSacH(username);
                MessageBox.Show("Bạn đã xóa thành công !", "Thông báo", MessageBoxButtons.OKCancel);
            }
        }
        void RemoveSacH(string username)
        {
            string query = "delete from book where MASA = '"+ username +"'";
            DataProvider provider = new DataProvider();
            dataGridView1.DataSource = provider.ExcuteQuery(query);
            LoadBookList();
        }


    }
}
