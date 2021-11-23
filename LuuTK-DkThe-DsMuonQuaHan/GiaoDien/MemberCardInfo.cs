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
    public partial class MemberCardInfo : Form
    {
        public MemberCardInfo()
        {
            InitializeComponent();
            LoadInfo();
        }
        void LoadInfo()
        {
            string query = "SELECT MATV , TENDN, HOTEN,  CMND,  HSD FROM MemberCard WHERE TENDN = '" + CurrentMemberCard.Instance.GetMemberCard() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            IdMemberText.Text = data.Rows[0]["MATV"].ToString();
            userNameText.Text = data.Rows[0]["TENDN"].ToString();           
            nameText.Text = data.Rows[0]["HOTEN"].ToString(); 
            passportText.Text = data.Rows[0]["CMND"].ToString();
            expiryText.Text = data.Rows[0]["HSD"].ToString();
        }

    }
}
