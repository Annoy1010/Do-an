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
        provider thongtin;
        string querry;
        private void Form1_Load(object sender, EventArgs e)
        {

            thongtin = new provider();
            try
            {
                querry = "select* from book";
                dataGridView1.DataSource = thongtin.ExecuteQuery(querry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(combobox.Text))
                {
                    querry = "select *from book where TENSA like N'%" + txtTimKiemTen.Text + "%'";
                }
                else if (string.IsNullOrEmpty(txtTimKiemTen.Text))
                {
                    querry = "select *from book where LOAISA=N'" + combobox.Text + "'";
                }
                else
                {
                    querry = "select *from book where TENSA like N'%" + txtTimKiemTen.Text + "%' and LOAISA=N'" + combobox.Text + "'";
                }
                dataGridView1.DataSource = thongtin.ExecuteQuery(querry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combobox.SelectedIndex.ToString() == "8")
                {
                    combobox.Text = null;
                }
                if (string.IsNullOrEmpty(combobox.Text))
                {
                    querry = "select *from book";
                }
                else
                {
                    querry = "select *from book where LOAISA = N'" + combobox.Text + "'";
                }
                dataGridView1.DataSource = thongtin.ExecuteQuery(querry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
