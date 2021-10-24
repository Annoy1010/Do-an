using HuyQuyenMuon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuyQuyenMuon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            object usernameData = dataGridView2.SelectedCells[0].Value;
            string username = usernameData.ToString();
            RemoveBorrow(username);
        }
        void RemoveBorrow(string username)
        {
            string query = "UPDATE UserAccount SET QUYENMUON = 1 WHERE TENDN = '" + username + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
