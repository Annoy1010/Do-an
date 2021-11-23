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
    public partial class PersonalInfo : Form
    {
        public PersonalInfo()
        {
            InitializeComponent();
            LoadInfo();
        }
        void LoadInfo()
        {
            string query = "SELECT HOTEN, TUOI, CMND, SDT, EMAIL FROM UserAccount WHERE TENDN = '" + CurrentAccount.Instance.GetAccount() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            nameText.Text = data.Rows[0]["HOTEN"].ToString();
            ageText.Text = data.Rows[0]["TUOI"].ToString();
            passportText.Text = data.Rows[0]["CMND"].ToString();
            phoneText.Text = data.Rows[0]["SDT"].ToString();
            emailText.Text = data.Rows[0]["EMAIL"].ToString();
        }

        private void personalBtn_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
