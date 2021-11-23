namespace ĐK_TheThanhVien
{
    partial class CardRegistration
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
            this.RegisterCard = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(321, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH THÀNH VIÊN CHƯA LÀM THẺ";
            // 
            // RegisterCard
            // 
            this.RegisterCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegisterCard.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RegisterCard.Location = new System.Drawing.Point(472, 518);
            this.RegisterCard.Name = "RegisterCard";
            this.RegisterCard.Size = new System.Drawing.Size(313, 64);
            this.RegisterCard.TabIndex = 4;
            this.RegisterCard.Text = "Đăng ký làm thẻ";
            this.RegisterCard.UseVisualStyleBackColor = true;
            this.RegisterCard.Click += new System.EventHandler(this.RegisterCard_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(41, 144);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(1219, 325);
            this.data.TabIndex = 3;
            this.data.VirtualMode = true;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // CardRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1288, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterCard);
            this.Controls.Add(this.data);
            this.Name = "CardRegistration";
            this.Text = "CardRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterCard;
        private System.Windows.Forms.DataGridView data;
    }
}

