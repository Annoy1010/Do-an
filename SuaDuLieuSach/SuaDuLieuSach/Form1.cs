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
namespace SuaDuLieuSach
{
    public partial class frm_SuaDuLieu : Form
    {
        public frm_SuaDuLieu()
        {
            InitializeComponent();
        }
        Table thongtin;
        private void Form1_Load(object sender, EventArgs e)
        {
            thongtin = new Table();
            try
            {
                dataGridView1.DataSource = thongtin.getTable();
            }
            catch(Exception)
            {
                MessageBox.Show("lỗi");
            }
        }
        public bool CheckData()
        {
            if(string.IsNullOrEmpty(txtMS.Text))
                {
                MessageBox.Show("bạn chưa nhập mã sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTS.Text))
            {
                MessageBox.Show("bạn chưa nhập tên sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLS.Text))
            {
                MessageBox.Show("bạn chưa nhập loại sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLS.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNXB.Text))
            {
                MessageBox.Show("bạn chưa nhập nhà xuất bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNXB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTG.Text))
            {
                MessageBox.Show("bạn chưa nhập tác giả", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTG.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTB.Text))
            {
                MessageBox.Show("bạn chưa nhập lần tái bản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSL.Text))
            {
                MessageBox.Show("bạn chưa nhập số lượng sách còn lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSL.Focus();
                return false;
            }
            return true;
        }
        private void bntSua_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                Sach sach = new Sach();
                sach.maSach = txtMS.Text;
                sach.tenSach = txtTS.Text;
                sach.loaiSach = txtLS.Text;
                sach.nhaXuatBan = txtNXB.Text;
                sach.soLuong =Int32.Parse( txtSL.Text);
                sach.taiBan =Int32.Parse( txtTB.Text);
                sach.tagGia = txtTG.Text;
                if (thongtin.Update(sach))
                {
                    dataGridView1.DataSource = thongtin.getTable();
                    MessageBox.Show("sửa thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("lỗi không sửa được", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                txtMS.Text = dataGridView1.Rows[index].Cells["MASA"].Value.ToString();
                txtTS.Text = dataGridView1.Rows[index].Cells["TENSA"].Value.ToString();
                txtLS.Text = dataGridView1.Rows[index].Cells["LOAISA"].Value.ToString();
                txtNXB.Text = dataGridView1.Rows[index].Cells["NXB"].Value.ToString();
                txtTG.Text = dataGridView1.Rows[index].Cells["TACGIA"].Value.ToString();
                txtTB.Text = dataGridView1.Rows[index].Cells["TAIBAN"].Value.ToString();
                txtSL.Text = dataGridView1.Rows[index].Cells["SOLUONG"].Value.ToString();
            }    
        }
    }
}
