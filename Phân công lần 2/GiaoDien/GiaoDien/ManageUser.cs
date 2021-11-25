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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            OpenChildForm(new PersonalInfo());
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

        private void personalBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalInfo());
        }

        private void bookInfoBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserBookInfo());
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowBook());
        }

        private void RentBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GiveBook());
        }

        private void policyBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LibraryRule());
        }

        private void secureBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Introduction());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
