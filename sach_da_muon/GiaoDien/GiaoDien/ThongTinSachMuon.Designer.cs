namespace GiaoDien
{
    partial class ThongTinSachMuon
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
            this.MASA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(500, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN SÁCH ĐÃ MƯỢN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASA,
            this.TENSA,
            this.LOAISA,
            this.NXB,
            this.TacGia,
            this.TaiBan,
            this.NgayMuon,
            this.NgayTra});
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 201);
            this.dataGridView1.TabIndex = 12;
            // 
            // MASA
            // 
            this.MASA.DataPropertyName = "MASA";
            this.MASA.HeaderText = "Mã sách";
            this.MASA.MinimumWidth = 6;
            this.MASA.Name = "MASA";
            this.MASA.Width = 125;
            // 
            // TENSA
            // 
            this.TENSA.DataPropertyName = "TENSA";
            this.TENSA.HeaderText = "Tên sách";
            this.TENSA.MinimumWidth = 6;
            this.TENSA.Name = "TENSA";
            this.TENSA.Width = 200;
            // 
            // LOAISA
            // 
            this.LOAISA.DataPropertyName = "LOAISA";
            this.LOAISA.HeaderText = "Loại sách";
            this.LOAISA.MinimumWidth = 6;
            this.LOAISA.Name = "LOAISA";
            this.LOAISA.Width = 200;
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            this.NXB.Width = 200;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TACGIA";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 200;
            // 
            // TaiBan
            // 
            this.TaiBan.DataPropertyName = "TAIBAN";
            this.TaiBan.HeaderText = "Lần tái bản";
            this.TaiBan.MinimumWidth = 6;
            this.TaiBan.Name = "TaiBan";
            this.TaiBan.Width = 125;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NGAYMUON";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 125;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NGAYTRA";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 125;
            // 
            // ThongTinSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinSachMuon";
            this.Text = "Thư viện";
            this.Load += new System.EventHandler(this.ThongTinSachMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}