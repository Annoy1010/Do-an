namespace GiaoDien
{
    partial class QuanLyUser
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
            this.btnThongTinCN = new System.Windows.Forms.Button();
            this.btnThongTinSach = new System.Windows.Forms.Button();
            this.btnQuyDinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(345, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ";
            // 
            // btnThongTinCN
            // 
            this.btnThongTinCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongTinCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinCN.Location = new System.Drawing.Point(323, 149);
            this.btnThongTinCN.Name = "btnThongTinCN";
            this.btnThongTinCN.Size = new System.Drawing.Size(251, 72);
            this.btnThongTinCN.TabIndex = 1;
            this.btnThongTinCN.Text = "Thông tin cá nhân";
            this.btnThongTinCN.UseVisualStyleBackColor = true;
            this.btnThongTinCN.Click += new System.EventHandler(this.btnThongTinCN_Click);
            // 
            // btnThongTinSach
            // 
            this.btnThongTinSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongTinSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongTinSach.Location = new System.Drawing.Point(323, 263);
            this.btnThongTinSach.Name = "btnThongTinSach";
            this.btnThongTinSach.Size = new System.Drawing.Size(251, 72);
            this.btnThongTinSach.TabIndex = 2;
            this.btnThongTinSach.Text = "Thông tin sách";
            this.btnThongTinSach.UseVisualStyleBackColor = true;
            this.btnThongTinSach.Click += new System.EventHandler(this.btnThongTinSach_Click);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuyDinh.Location = new System.Drawing.Point(323, 379);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Size = new System.Drawing.Size(251, 72);
            this.btnQuyDinh.TabIndex = 3;
            this.btnQuyDinh.Text = "Quy định của thư viện";
            this.btnQuyDinh.UseVisualStyleBackColor = true;
            // 
            // QuanLyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 504);
            this.Controls.Add(this.btnQuyDinh);
            this.Controls.Add(this.btnThongTinSach);
            this.Controls.Add(this.btnThongTinCN);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyUser";
            this.Text = "Thư viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongTinCN;
        private System.Windows.Forms.Button btnThongTinSach;
        private System.Windows.Forms.Button btnQuyDinh;
    }
}