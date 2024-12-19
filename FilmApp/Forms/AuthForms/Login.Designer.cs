namespace FilmApp.Forms.AuthForms
{
    partial class Login
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
            this.sPanel1 = new SPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordInput = new PlaceHolderTextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.emailInput = new PlaceHolderTextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.linkLabel1);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.pictureBox1);
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Controls.Add(this.panelEmail);
            this.sPanel1.Controls.Add(this.loginBtn);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(64, 129);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(796, 557);
            this.sPanel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(443, 461);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register Now !";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "You don\'t have account ? ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilmApp.Properties.Resources.filmlogo;
            this.pictureBox1.Location = new System.Drawing.Point(347, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Location = new System.Drawing.Point(185, 340);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panel1.Size = new System.Drawing.Size(438, 38);
            this.panel1.TabIndex = 14;
            this.panel1.Tag = "";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.White;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.passwordInput.ForeColor = System.Drawing.Color.Gray;
            this.passwordInput.Location = new System.Drawing.Point(11, 7);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PlaceHolderText = "";
            this.passwordInput.Size = new System.Drawing.Size(414, 23);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // panelEmail
            // 
            this.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmail.Controls.Add(this.emailInput);
            this.panelEmail.Location = new System.Drawing.Point(185, 262);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panelEmail.Size = new System.Drawing.Size(438, 38);
            this.panelEmail.TabIndex = 12;
            this.panelEmail.Tag = "";
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.White;
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.emailInput.ForeColor = System.Drawing.Color.Gray;
            this.emailInput.Location = new System.Drawing.Point(11, 7);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceHolderText = "Enter your email ...";
            this.emailInput.Size = new System.Drawing.Size(414, 23);
            this.emailInput.TabIndex = 2;
            this.emailInput.Text = "Enter your email ...";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.loginBtn.Location = new System.Drawing.Point(331, 403);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(129, 44);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Đăng Nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(181, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(181, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(260, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELLCOME BACK";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(912, 744);
            this.Controls.Add(this.sPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panelEmail;
        private PlaceHolderTextBox emailInput;
        private System.Windows.Forms.Panel panel1;
        private PlaceHolderTextBox passwordInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SPanel sPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}