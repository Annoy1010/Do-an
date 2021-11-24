namespace TraSach
{
    partial class ThongTinSachTra
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
            this.dataBorrowBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBorrowBook
            // 
            this.dataBorrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBorrowBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrowBook.Location = new System.Drawing.Point(61, 116);
            this.dataBorrowBook.Name = "dataBorrowBook";
            this.dataBorrowBook.ReadOnly = true;
            this.dataBorrowBook.RowHeadersWidth = 51;
            this.dataBorrowBook.Size = new System.Drawing.Size(1105, 286);
            this.dataBorrowBook.TabIndex = 0;
            this.dataBorrowBook.Click += new System.EventHandler(this.dataBorrowBook_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(352, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN SÁCH ĐÃ MƯỢN";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTraSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.Location = new System.Drawing.Point(527, 427);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(168, 66);
            this.btnTraSach.TabIndex = 2;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // ThongTinSachTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1216, 505);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataBorrowBook);
            this.Name = "ThongTinSachTra";
            this.Text = "Thư viện";
            this.Load += new System.EventHandler(this.ThongTinSachTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrowBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBorrowBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraSach;
    }
}

