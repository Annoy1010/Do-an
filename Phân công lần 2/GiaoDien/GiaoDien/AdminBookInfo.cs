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
    public partial class AdminBookInfo : Form
    {
       public AdminBookInfo()
        {
            InitializeComponent();
            OpenChildForm(new BookInfoAdmin());
        }
        private Form CurrentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null)
                CurrentFormChild.Close();
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            bookControl.Controls.Add(ChildForm);
            bookControl.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void bookListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookInfoAdmin());
        }

        private void insertDataBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsertData());
        }

        private void adjustDataBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdjustData());
        }

        private void removeDataBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RemoveData());
        }
    }
}
