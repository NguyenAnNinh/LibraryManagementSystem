namespace LibraryManagementSystem
{
    partial class RegisterForm
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
            label1 = new Label();
            register_signinBtn = new Button();
            register_showPass = new CheckBox();
            register_registerBtn = new Button();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            close = new Label();
            register_email = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 460);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 21;
            label1.Text = "I have account";
            // 
            // register_signinBtn
            // 
            register_signinBtn.BackColor = Color.FromArgb(14, 128, 87);
            register_signinBtn.Cursor = Cursors.Hand;
            register_signinBtn.FlatAppearance.BorderSize = 0;
            register_signinBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            register_signinBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            register_signinBtn.FlatStyle = FlatStyle.Flat;
            register_signinBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signinBtn.ForeColor = Color.White;
            register_signinBtn.Location = new Point(12, 482);
            register_signinBtn.Name = "register_signinBtn";
            register_signinBtn.Size = new Size(296, 31);
            register_signinBtn.TabIndex = 20;
            register_signinBtn.Text = "SIGN IN";
            register_signinBtn.UseVisualStyleBackColor = false;
            register_signinBtn.Click += register_signinBtn_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(12, 375);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(108, 19);
            register_showPass.TabIndex = 19;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_registerBtn
            // 
            register_registerBtn.BackColor = Color.FromArgb(14, 128, 87);
            register_registerBtn.Cursor = Cursors.Hand;
            register_registerBtn.FlatAppearance.BorderSize = 0;
            register_registerBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            register_registerBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            register_registerBtn.FlatStyle = FlatStyle.Flat;
            register_registerBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_registerBtn.ForeColor = Color.White;
            register_registerBtn.Location = new Point(12, 417);
            register_registerBtn.Name = "register_registerBtn";
            register_registerBtn.Size = new Size(296, 40);
            register_registerBtn.TabIndex = 18;
            register_registerBtn.Text = "REGISTER";
            register_registerBtn.UseVisualStyleBackColor = false;
            register_registerBtn.Click += register_registerBtn_Click;
            // 
            // register_password
            // 
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Tahoma", 11.25F);
            register_password.Location = new Point(12, 339);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.Size = new Size(296, 30);
            register_password.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 318);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 16;
            label4.Text = "Password:";
            // 
            // register_username
            // 
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Tahoma", 11.25F);
            register_username.Location = new Point(12, 276);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(296, 30);
            register_username.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 153);
            label2.Name = "label2";
            label2.Size = new Size(161, 22);
            label2.TabIndex = 13;
            label2.Text = "Registration Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_100;
            pictureBox1.Location = new Point(102, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 11;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(293, 9);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_email
            // 
            register_email.BorderStyle = BorderStyle.FixedSingle;
            register_email.Font = new Font("Tahoma", 11.25F);
            register_email.Location = new Point(12, 212);
            register_email.Multiline = true;
            register_email.Name = "register_email";
            register_email.Size = new Size(296, 30);
            register_email.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 22;
            label5.Text = "Email Address:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 525);
            Controls.Add(register_email);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(register_signinBtn);
            Controls.Add(register_showPass);
            Controls.Add(register_registerBtn);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button register_signinBtn;
        private CheckBox register_showPass;
        private Button register_registerBtn;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label close;
        private TextBox register_email;
        private Label label5;
    }
}