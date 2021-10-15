namespace GiaoDien
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TeSach,
            this.LoaiSach,
            this.NXB,
            this.TacGia,
            this.TaiBan,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(50, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(468, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "LIỆU SỬA DỮ LIỆU";
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TeSach
            // 
            this.TeSach.HeaderText = "Tên sách";
            this.TeSach.MinimumWidth = 6;
            this.TeSach.Name = "TeSach";
            this.TeSach.Width = 200;
            // 
            // LoaiSach
            // 
            this.LoaiSach.HeaderText = "Loại sách";
            this.LoaiSach.MinimumWidth = 6;
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.Width = 200;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.Width = 200;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 200;
            // 
            // TaiBan
            // 
            this.TaiBan.HeaderText = "Lần tái bản";
            this.TaiBan.MinimumWidth = 6;
            this.TaiBan.Name = "TaiBan";
            this.TaiBan.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng còn lại";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(477, 344);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(263, 56);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
    }
}