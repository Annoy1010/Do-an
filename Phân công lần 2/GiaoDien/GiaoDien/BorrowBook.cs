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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
            OpenChildForm(new ShowBookList());
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
                CurrentFormChild.Close();
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            subLayout.Controls.Add(ChildForm);
            subLayout.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowBookList());
        }
    }
}
