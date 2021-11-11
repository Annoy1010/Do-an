namespace GiaoDien
{
    partial class QuanLyAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(314, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ";
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhVien.Location = new System.Drawing.Point(259, 149);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(294, 69);
            this.btnThanhVien.TabIndex = 1;
            this.btnThanhVien.Text = "Thông tin thành viên";
            this.btnThanhVien.UseVisualStyleBackColor = true;
            // 
            // btnSach
            // 
            this.btnSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.Location = new System.Drawing.Point(259, 278);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(294, 69);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "Thông tin sách";
            this.btnSach.UseVisualStyleBackColor = true;
            // 
            // QuanLyAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnThanhVien);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyAdmin";
            this.Text = "Thư Viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhVien;
        private System.Windows.Forms.Button btnSach;
    }
}