
namespace TimKiemSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemTen = new System.Windows.Forms.TextBox();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASA,
            this.TENSA,
            this.LOAISA,
            this.NXB,
            this.TACGIA,
            this.TAIBAN,
            this.SOLUONG});
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // MASA
            // 
            this.MASA.DataPropertyName = "MASA";
            this.MASA.HeaderText = "Mã sách";
            this.MASA.MinimumWidth = 6;
            this.MASA.Name = "MASA";
            // 
            // TENSA
            // 
            this.TENSA.DataPropertyName = "TENSA";
            this.TENSA.HeaderText = "Tên sách";
            this.TENSA.MinimumWidth = 6;
            this.TENSA.Name = "TENSA";
            // 
            // LOAISA
            // 
            this.LOAISA.DataPropertyName = "LOAISA";
            this.LOAISA.HeaderText = "Loại sách";
            this.LOAISA.MinimumWidth = 6;
            this.LOAISA.Name = "LOAISA";
            // 
            // NXB
            // 
            this.NXB.DataPropertyName = "NXB";
            this.NXB.HeaderText = "Nhà xuất bản";
            this.NXB.MinimumWidth = 6;
            this.NXB.Name = "NXB";
            // 
            // TACGIA
            // 
            this.TACGIA.DataPropertyName = "TACGIA";
            this.TACGIA.HeaderText = "Tác giả";
            this.TACGIA.MinimumWidth = 6;
            this.TACGIA.Name = "TACGIA";
            // 
            // TAIBAN
            // 
            this.TAIBAN.DataPropertyName = "TAIBAN";
            this.TAIBAN.HeaderText = "Lần tái bản";
            this.TAIBAN.MinimumWidth = 6;
            this.TAIBAN.Name = "TAIBAN";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng còn lại";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN SÁCH";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(393, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mượn sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(797, 140);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 33);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(229, 140);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(549, 32);
            this.txtTimKiemTen.TabIndex = 5;
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "Chính trị – pháp luật",
            "Khoa học công nghệ – Kinh tế",
            "Văn học nghệ thuật",
            "Văn hóa xã hội – Lịch sử",
            "Giáo trình",
            "Sách Truyện, tiểu thuyết",
            "Tâm lý, tâm linh, tôn giáo",
            "Thiếu nhi",
            "∅"});
            this.combobox.Location = new System.Drawing.Point(229, 69);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(549, 30);
            this.combobox.TabIndex = 9;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.AutoSize = true;
            this.lblLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSach.Location = new System.Drawing.Point(92, 73);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(105, 26);
            this.lblLoaiSach.TabIndex = 10;
            this.lblLoaiSach.Text = "Loại sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoaiSach);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.txtTimKiemTen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemTen;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Label lblLoaiSach;
        private System.Windows.Forms.Label label2;
    }
}

