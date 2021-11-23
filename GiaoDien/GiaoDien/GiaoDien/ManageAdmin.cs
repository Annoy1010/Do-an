using GiaoDien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
            OpenChildForm(new MemberInfo());
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
                CurrentFormChild.Close();
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            mainLayout.Controls.Add(ChildForm);
            mainLayout.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void memberMgBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MemberInfo());
        }

        private void bookMgBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminBookInfo());
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {

        }

        private void membercarđBtn_Click(object sender, EventArgs e)
        {

        }

        private void secureBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
