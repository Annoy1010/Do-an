namespace GiaoDien
{
    partial class Form1
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(256, 99);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(212, 72);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.Location = new System.Drawing.Point(256, 204);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(212, 72);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGioiThieu.Location = new System.Drawing.Point(256, 322);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(212, 72);
            this.btnGioiThieu.TabIndex = 2;
            this.btnGioiThieu.Text = "Giới Thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btnGioiThieu);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "Form1";
            this.Text = "Thư Viện";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnGioiThieu;
    }
}

