
namespace Top3SachMuon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartSach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSA,
            this.TenSA,
            this.LoaiSA,
            this.NXB,
            this.TacGia,
            this.TaiBan,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(12, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartSach
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSach.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSach.Legends.Add(legend1);
            this.chartSach.Location = new System.Drawing.Point(198, 51);
            this.chartSach.Name = "chartSach";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.LabelForeColor = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Sách";
            this.chartSach.Series.Add(series1);
            this.chartSach.Size = new System.Drawing.Size(495, 385);
            this.chartSach.TabIndex = 1;
            this.chartSach.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Top 3 sách được mượn nhiều nhất";
            this.chartSach.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "SÁCH ĐƯỢC MƯỢN NHIỀU NHẤT CỦA THƯ VIỆN";
            // 
            // MaSA
            // 
            this.MaSA.DataPropertyName = "MaSA";
            this.MaSA.HeaderText = "Mã Sách";
            this.MaSA.MinimumWidth = 6;
            this.MaSA.Name = "MaSA";
            // 
            // TenSA
            // 
            this.TenSA.DataPropertyName = "TenSA";
            this.TenSA.HeaderText = "Tên Sách";
            this.TenSA.MinimumWidth = 6;
            this.TenSA.Name = "TenSA";
            // 
            // LoaiSA
            // 
            this.LoaiSA.DataPropertyName = "LoaiSA";
            this.LoaiSA.HeaderText = "Loại Sách";
            this.LoaiSA.MinimumWidth = 6;
            this.LoaiSA.Name = "LoaiSA";
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "Nhà Xuất Bản";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            // 
            // TaiBan
            // 
            this.TaiBan.DataPropertyName = "TaiBan";
            this.TaiBan.HeaderText = "Lần Tái Bản";
            this.TaiBan.MinimumWidth = 6;
            this.TaiBan.Name = "TaiBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSach);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}

