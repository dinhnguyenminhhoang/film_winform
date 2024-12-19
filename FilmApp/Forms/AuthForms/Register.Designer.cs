namespace FilmApp.Forms.AuthForms
{
    partial class Register
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.confirmPasswordInput = new PlaceHolderTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameInput = new PlaceHolderTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordInput = new PlaceHolderTextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.emailInput = new PlaceHolderTextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.sPanel1.Controls.Add(this.panel3);
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.panel2);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.pictureBox1);
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Controls.Add(this.panelEmail);
            this.sPanel1.Controls.Add(this.registerBtn);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(224, 27);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(809, 662);
            this.sPanel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(442, 572);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 16);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login Now !";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.confirmPasswordInput);
            this.panel3.Location = new System.Drawing.Point(204, 461);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panel3.Size = new System.Drawing.Size(438, 38);
            this.panel3.TabIndex = 16;
            this.panel3.Tag = "";
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.BackColor = System.Drawing.Color.White;
            this.confirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.confirmPasswordInput.ForeColor = System.Drawing.Color.Gray;
            this.confirmPasswordInput.Location = new System.Drawing.Point(11, 7);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.PlaceHolderText = "";
            this.confirmPasswordInput.Size = new System.Drawing.Size(414, 23);
            this.confirmPasswordInput.TabIndex = 3;
            this.confirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "You have account ? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(200, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Confirm Password";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nameInput);
            this.panel2.Location = new System.Drawing.Point(204, 229);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.panel2.Size = new System.Drawing.Size(438, 38);
            this.panel2.TabIndex = 14;
            this.panel2.Tag = "";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.White;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.nameInput.ForeColor = System.Drawing.Color.Gray;
            this.nameInput.Location = new System.Drawing.Point(11, 7);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceHolderText = "Enter your name ...";
            this.nameInput.Size = new System.Drawing.Size(414, 23);
            this.nameInput.TabIndex = 2;
            this.nameInput.Text = "Enter your name ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(200, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilmApp.Properties.Resources.filmlogo;
            this.pictureBox1.Location = new System.Drawing.Point(347, 59);
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
            this.panel1.Location = new System.Drawing.Point(204, 383);
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
            this.panelEmail.Location = new System.Drawing.Point(204, 305);
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
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.registerBtn.Location = new System.Drawing.Point(347, 516);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(129, 44);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.Text = "Đăng Kí";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(200, 360);
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
            this.label2.Location = new System.Drawing.Point(200, 282);
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
            this.label1.Location = new System.Drawing.Point(250, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELLCOME TO FILMS";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1248, 701);
            this.Controls.Add(this.sPanel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private PlaceHolderTextBox passwordInput;
        private System.Windows.Forms.Panel panelEmail;
        private PlaceHolderTextBox emailInput;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private PlaceHolderTextBox nameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private PlaceHolderTextBox confirmPasswordInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
    }
}