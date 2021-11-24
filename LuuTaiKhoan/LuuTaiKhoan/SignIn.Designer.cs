namespace LuuTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.checkSave = new System.Windows.Forms.CheckBox();
            this.signinBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.usernameLabel.Location = new System.Drawing.Point(83, 179);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(182, 29);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Tên đăng nhập";
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usernameText.Location = new System.Drawing.Point(311, 179);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(372, 34);
            this.usernameText.TabIndex = 3;
            // 
            // passText
            // 
            this.passText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passText.BackColor = System.Drawing.Color.Gainsboro;
            this.passText.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passText.Location = new System.Drawing.Point(311, 247);
            this.passText.MaxLength = 6;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(372, 34);
            this.passText.TabIndex = 4;
            this.passText.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Cascadia Code", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Indigo;
            this.passLabel.Location = new System.Drawing.Point(93, 252);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(117, 29);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Mật khẩu";
            // 
            // checkSave
            // 
            this.checkSave.AutoSize = true;
            this.checkSave.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSave.ForeColor = System.Drawing.Color.Indigo;
            this.checkSave.Location = new System.Drawing.Point(311, 301);
            this.checkSave.Name = "checkSave";
            this.checkSave.Size = new System.Drawing.Size(190, 31);
            this.checkSave.TabIndex = 9;
            this.checkSave.Text = "Lưu tài khoản";
            this.checkSave.UseVisualStyleBackColor = true;
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
            this.signinBtn.Location = new System.Drawing.Point(236, 356);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(165, 55);
            this.signinBtn.TabIndex = 10;
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
            this.signupBtn.Location = new System.Drawing.Point(464, 356);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(165, 55);
            this.signupBtn.TabIndex = 11;
            this.signupBtn.TabStop = false;
            this.signupBtn.Text = "Đăng ký";
            this.signupBtn.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.checkSave);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.CheckBox checkSave;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.Button signupBtn;
    }
}

