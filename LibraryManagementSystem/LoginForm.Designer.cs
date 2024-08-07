namespace LibraryManagementSystem
{
    partial class LoginForm
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
            panel1 = new Panel();
            close = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_loginBtn = new Button();
            login_showPass = new CheckBox();
            login_signupBtn = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_100;
            pictureBox1.Location = new Point(102, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 165);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 2;
            label2.Text = "Welcome, User!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 221);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Tahoma", 11.25F);
            login_username.Location = new Point(12, 242);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(296, 30);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Tahoma", 11.25F);
            login_password.Location = new Point(12, 314);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.Size = new Size(296, 30);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_loginBtn
            // 
            login_loginBtn.BackColor = Color.FromArgb(14, 128, 87);
            login_loginBtn.Cursor = Cursors.Hand;
            login_loginBtn.FlatAppearance.BorderSize = 0;
            login_loginBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            login_loginBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            login_loginBtn.FlatStyle = FlatStyle.Flat;
            login_loginBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_loginBtn.ForeColor = Color.White;
            login_loginBtn.Location = new Point(12, 384);
            login_loginBtn.Name = "login_loginBtn";
            login_loginBtn.Size = new Size(296, 40);
            login_loginBtn.TabIndex = 7;
            login_loginBtn.Text = "LOGIN";
            login_loginBtn.UseVisualStyleBackColor = false;
            login_loginBtn.Click += login_loginBtn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(12, 350);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(14, 128, 87);
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(12, 482);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(296, 31);
            login_signupBtn.TabIndex = 9;
            login_signupBtn.Text = "SIGN UP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 460);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 10;
            label1.Text = "Register Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 525);
            Controls.Add(label1);
            Controls.Add(login_signupBtn);
            Controls.Add(login_showPass);
            Controls.Add(login_loginBtn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private Button login_loginBtn;
        private CheckBox login_showPass;
        private Button login_signupBtn;
        private Label label1;
    }
}