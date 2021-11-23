using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class CardRegistration : Form
    {
      
        string username;
        string name;
        string passport;
        string expiry;
        bool itemClick = false;
        int currentRowPos;
        public CardRegistration()
        {
            InitializeComponent();
        }
        private void CardRegistration_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT US.TENDN 'Tên đăng nhập', US.HOTEN 'Họ và tên', US.TUOI 'Tuổi', US.CMND 'Chứng minh nhân dân', SDT 'Số điện thoại', EMAIL 'Email' FROM UserAccount US left outer join MemberCard MB on US.TENDN = MB.TENDN WHERE MB.TENDN IS NULL AND US.QUYENQL = 0";
            data.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void data_Click(object sender, EventArgs e)
        {
            currentRowPos = data.CurrentRow.Index;
            username = data.Rows[currentRowPos].Cells[0].Value.ToString();
            name = data.Rows[currentRowPos].Cells[2].Value.ToString();          
            passport = data.Rows[currentRowPos].Cells[3].Value.ToString();
            itemClick = true;
        }

        private void RegisterCard_Click(object sender, EventArgs e)
        {

            if (itemClick == false) 
                MessageBox.Show("Vui lòng chọn thành viên làm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult result = MessageBox.Show("Bạn đã chắc chắn muốn đăng ký?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CurrentMemberCard.Instance.SetMemberCard(username);
                    expiry = DateTime.Now.AddYears(1).ToString("MM-dd-yyyy");
                    InsertMemberCard(username, name, passport, expiry);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Hide();
                    MemberCardInfo memberCardInfo = new MemberCardInfo();
                    memberCardInfo.ShowDialog();
                    this.LoadData();
                    this.Show();

                }
            }
        }

        void InsertMemberCard(string userName, string memberName, string Passport, string Expiry)
        {
            int SuccessRows = 0;
            string MemberID;
            while (SuccessRows <= 0)
            {
                MemberID = Random().ToString();
                string query =string.Format("INSERT INTO MemberCard VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", MemberID, userName, memberName, Passport, Expiry);
                SuccessRows = DataProvider.Instance.ExecuteNonQuery(query);
            }
        }    
                
        int Random()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999);
        }      

    }
}
