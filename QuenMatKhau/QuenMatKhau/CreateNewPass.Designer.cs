
namespace QuenMatKhau
{
    partial class CreateNewPass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hiderepass = new System.Windows.Forms.PictureBox();
            this.hidepass = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.repassText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiderepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hiderepass);
            this.panel1.Controls.Add(this.hidepass);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.passText);
            this.panel1.Controls.Add(this.repassText);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 426);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "KHÔI PHỤC TÀI KHOẢN";
            // 
            // hiderepass
            // 
            this.hiderepass.BackColor = System.Drawing.Color.White;
            this.hiderepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hiderepass.Image = global::QuenMatKhau.Properties.Resources.hide;
            this.hiderepass.Location = new System.Drawing.Point(698, 196);
            this.hiderepass.Name = "hiderepass";
            this.hiderepass.Size = new System.Drawing.Size(38, 30);
            this.hiderepass.TabIndex = 17;
            this.hiderepass.TabStop = false;
            this.hiderepass.Click += new System.EventHandler(this.hiderepass_Click);
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.White;
            this.hidepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidepass.Image = global::QuenMatKhau.Properties.Resources.hide;
            this.hidepass.Location = new System.Drawing.Point(698, 134);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(38, 30);
            this.hidepass.TabIndex = 17;
            this.hidepass.TabStop = false;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(33, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(33, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Gray;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(481, 275);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 55);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Hủy bỏ";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.submitBtn.Location = new System.Drawing.Point(149, 275);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(165, 55);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.TabStop = false;
            this.submitBtn.Text = "Xác nhận";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // passText
            // 
            this.passText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passText.BackColor = System.Drawing.Color.White;
            this.passText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passText.Location = new System.Drawing.Point(363, 130);
            this.passText.MaxLength = 6;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(372, 34);
            this.passText.TabIndex = 9;
            this.passText.UseSystemPasswordChar = true;
            // 
            // repassText
            // 
            this.repassText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repassText.BackColor = System.Drawing.Color.White;
            this.repassText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repassText.Location = new System.Drawing.Point(363, 192);
            this.repassText.MaxLength = 6;
            this.repassText.Name = "repassText";
            this.repassText.Size = new System.Drawing.Size(372, 34);
            this.repassText.TabIndex = 11;
            this.repassText.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.White;
            this.passLabel.Location = new System.Drawing.Point(70, 196);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(234, 29);
            this.passLabel.TabIndex = 12;
            this.passLabel.Text = "Xác nhận mật khẩu";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(70, 134);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(169, 29);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Mật khẩu mới";
            // 
            // mainLayout
            // 
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(768, 3);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(674, 712);
            this.mainLayout.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainLayout, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1445, 718);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CreateNewPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1445, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateNewPass";
            this.Text = "Thư viện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiderepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hiderepass;
        private System.Windows.Forms.PictureBox hidepass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox repassText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel mainLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}