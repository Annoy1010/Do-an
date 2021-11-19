using QuenMatKhau.DAO;
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

namespace QuenMatKhau
{
    public partial class OTP : Form
    {
        Thread th;
        public OTP()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (otpText.Text == OTPCode.Instance.GetOTP())
            {
                MessageBox.Show("Xác thực mã thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                DisplayNewForm();
            }
            else
                MessageBox.Show("Mã OTP không chính xác. Vui lòng kiểm tra lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void DisplayNewForm()
        {
            th = new Thread(OpenCreateNewPassForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenCreateNewPassForm()
        {
            Application.Run(new CreateNewPass());
        }
    }
}
