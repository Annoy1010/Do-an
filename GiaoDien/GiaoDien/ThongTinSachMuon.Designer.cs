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
            this.databorrowBook = new System.Windows.Forms.DataGridView();
            this.btnTraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databorrowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(469, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN SÁCH ĐÃ MƯỢN";
            // 
            // databorrowBook
            // 
            this.databorrowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databorrowBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.databorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databorrowBook.Location = new System.Drawing.Point(28, 107);
            this.databorrowBook.Name = "databorrowBook";
            this.databorrowBook.ReadOnly = true;
            this.databorrowBook.RowHeadersWidth = 51;
            this.databorrowBook.RowTemplate.Height = 24;
            this.databorrowBook.Size = new System.Drawing.Size(1326, 280);
            this.databorrowBook.TabIndex = 12;
            this.databorrowBook.Click += new System.EventHandler(this.dataBrowBook_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraSach.Location = new System.Drawing.Point(580, 422);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(174, 64);
            this.btnTraSach.TabIndex = 15;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // ThongTinSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1379, 529);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.databorrowBook);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinSachMuon";
            this.Text = "Thư viện";
            this.Load += new System.EventHandler(this.ThongTinSachMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databorrowBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView databorrowBook;
        private System.Windows.Forms.Button btnTraSach;
    }
}