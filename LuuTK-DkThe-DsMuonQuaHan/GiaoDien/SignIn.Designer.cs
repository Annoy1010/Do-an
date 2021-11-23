namespace GiaoDien
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.signinBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Panel();
            this.checkSave = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hidepass = new System.Windows.Forms.PictureBox();
            this.forgotpassLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.usernameLabel.Location = new System.Drawing.Point(48, 123);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(182, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Tên đăng nhập";
            // 
            // heading
            // 
            this.heading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Indigo;
            this.heading.Location = new System.Drawing.Point(242, 27);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(200, 45);
            this.heading.TabIndex = 0;
            this.heading.Text = "ĐĂNG NHẬP";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Indigo;
            this.passLabel.Location = new System.Drawing.Point(48, 185);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(117, 29);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Mật khẩu";
            // 
            // passText
            // 
            this.passText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passText.BackColor = System.Drawing.Color.Gainsboro;
            this.passText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passText.Location = new System.Drawing.Point(254, 181);
            this.passText.MaxLength = 6;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(372, 34);
            this.passText.TabIndex = 2;
            this.passText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usernameText.Location = new System.Drawing.Point(254, 119);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(372, 34);
            this.usernameText.TabIndex = 1;
            // 
            // signinBtn
            // 
            this.signinBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.signinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signinBtn.Location = new System.Drawing.Point(91, 295);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(165, 55);
            this.signinBtn.TabIndex = 5;
            this.signinBtn.TabStop = false;
            this.signinBtn.Text = "Đăng nhập";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupBtn.BackColor = System.Drawing.Color.Gray;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.Transparent;
            this.signupBtn.Location = new System.Drawing.Point(416, 295);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(165, 55);
            this.signupBtn.TabIndex = 6;
            this.signupBtn.TabStop = false;
            this.signupBtn.Text = "Đăng ký";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Controls.Add(this.checkSave);
            this.login.Controls.Add(this.pictureBox3);
            this.login.Controls.Add(this.pictureBox2);
            this.login.Controls.Add(this.hidepass);
            this.login.Controls.Add(this.forgotpassLink);
            this.login.Controls.Add(this.signupBtn);
            this.login.Controls.Add(this.signinBtn);
            this.login.Controls.Add(this.usernameText);
            this.login.Controls.Add(this.passText);
            this.login.Controls.Add(this.passLabel);
            this.login.Controls.Add(this.heading);
            this.login.Controls.Add(this.usernameLabel);
            this.login.Location = new System.Drawing.Point(657, 125);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(644, 432);
            this.login.TabIndex = 8;
            // 
            // checkSave
            // 
            this.checkSave.AutoSize = true;
            this.checkSave.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSave.ForeColor = System.Drawing.Color.Indigo;
            this.checkSave.Location = new System.Drawing.Point(254, 228);
            this.checkSave.Name = "checkSave";
            this.checkSave.Size = new System.Drawing.Size(190, 31);
            this.checkSave.TabIndex = 3;
            this.checkSave.Text = "Lưu tài khoản";
            this.checkSave.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GiaoDien.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(11, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GiaoDien.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(11, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // hidepass
            // 
            this.hidepass.BackColor = System.Drawing.Color.Gainsboro;
            this.hidepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidepass.Image = global::GiaoDien.Properties.Resources.hide;
            this.hidepass.Location = new System.Drawing.Point(583, 183);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(38, 30);
            this.hidepass.TabIndex = 7;
            this.hidepass.TabStop = false;
            this.hidepass.Click += new System.EventHandler(this.hidepass_Click);
            // 
            // forgotpassLink
            // 
            this.forgotpassLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.forgotpassLink.AutoSize = true;
            this.forgotpassLink.BackColor = System.Drawing.Color.Transparent;
            this.forgotpassLink.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotpassLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.forgotpassLink.Location = new System.Drawing.Point(450, 229);
            this.forgotpassLink.Name = "forgotpassLink";
            this.forgotpassLink.Size = new System.Drawing.Size(180, 27);
            this.forgotpassLink.TabIndex = 4;
            this.forgotpassLink.TabStop = true;
            this.forgotpassLink.Text = "Quên mật khẩu?";
            this.forgotpassLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpassLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.siginlayout;
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 626);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.login, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 682);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1306, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện";
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.LinkLabel forgotpassLink;
        private System.Windows.Forms.PictureBox hidepass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}