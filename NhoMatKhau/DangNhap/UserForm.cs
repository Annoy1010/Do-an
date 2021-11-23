using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class UserForm : Form
    {
        public UserForm(string user, string pass)
        {
            InitializeComponent();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
