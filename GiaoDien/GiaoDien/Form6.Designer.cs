namespace GiaoDien
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(334, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.LoaiSach,
            this.NXB,
            this.TacGia,
            this.TaiBan,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(188, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(186, 55);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(472, 361);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(186, 55);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa dữ liệu";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(748, 361);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(186, 55);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 200;
            // 
            // LoaiSach
            // 
            this.LoaiSach.HeaderText = "Loại sách";
            this.LoaiSach.MinimumWidth = 6;
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.ReadOnly = true;
            this.LoaiSach.Width = 200;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.ReadOnly = true;
            this.NXB.Width = 125;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Width = 150;
            // 
            // TaiBan
            // 
            this.TaiBan.HeaderText = "Lần tái bản";
            this.TaiBan.MinimumWidth = 6;
            this.TaiBan.Name = "TaiBan";
            this.TaiBan.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng còn lại";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 150;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Thư viện";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}