
namespace DangNhap
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsernames = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsernames = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.bntDangNhap = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ck_nhomatkhau = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsernames
            // 
            this.txtUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernames.Location = new System.Drawing.Point(358, 149);
            this.txtUsernames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsernames.Name = "txtUsernames";
            this.txtUsernames.Size = new System.Drawing.Size(565, 37);
            this.txtUsernames.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(358, 246);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(565, 37);
            this.txtPass.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(404, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 46);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // lblUsernames
            // 
            this.lblUsernames.AutoSize = true;
            this.lblUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernames.Location = new System.Drawing.Point(107, 149);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(183, 30);
            this.lblUsernames.TabIndex = 3;
            this.lblUsernames.Text = "Tên đăng nhập";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(107, 246);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(118, 30);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Mật khẩu";
            // 
            // bntDangNhap
            // 
            this.bntDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangNhap.Location = new System.Drawing.Point(278, 386);
            this.bntDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntDangNhap.Name = "bntDangNhap";
            this.bntDangNhap.Size = new System.Drawing.Size(209, 45);
            this.bntDangNhap.TabIndex = 5;
            this.bntDangNhap.Text = "Đăng nhập";
            this.bntDangNhap.UseVisualStyleBackColor = true;
            this.bntDangNhap.Click += new System.EventHandler(this.bntDangNhap_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(543, 386);
            this.bntThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(209, 45);
            this.bntThoat.TabIndex = 6;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DangNhap.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(938, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DangNhap.Properties.Resources.mo1;
            this.pictureBox1.Location = new System.Drawing.Point(938, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ck_nhomatkhau
            // 
            this.ck_nhomatkhau.AutoSize = true;
            this.ck_nhomatkhau.Location = new System.Drawing.Point(789, 397);
            this.ck_nhomatkhau.Name = "ck_nhomatkhau";
            this.ck_nhomatkhau.Size = new System.Drawing.Size(134, 24);
            this.ck_nhomatkhau.TabIndex = 9;
            this.ck_nhomatkhau.Text = "Nhớ mật khẩu";
            this.ck_nhomatkhau.UseVisualStyleBackColor = true;
            this.ck_nhomatkhau.CheckedChanged += new System.EventHandler(this.ck_nhomatkhau_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 515);
            this.Controls.Add(this.ck_nhomatkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntDangNhap);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsernames);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsernames);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsernames;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsernames;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button bntDangNhap;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ck_nhomatkhau;
    }
}

