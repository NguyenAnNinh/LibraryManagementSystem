namespace LibraryManagementSystem
{
    partial class MainForm
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
            label2 = new Label();
            close = new Label();
            panel2 = new Panel();
            label4 = new Label();
            mainform_logoutBtn = new Button();
            mainform_issuebooksBtn = new Button();
            mainform_returnbooksBtn = new Button();
            mainform_addbooksBtn = new Button();
            mainform_dashboardBtn = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addBooks1 = new AddBooks();
            issueBooks1 = new IssueBooks();
            returnBooks1 = new ReturnBooks();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Size = new Size(286, 18);
            label2.TabIndex = 1;
            label2.Text = "Library Mamagement System | Main Form";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(1074, 9);
            close.Name = "close";
            close.Size = new Size(14, 16);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 128, 87);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(mainform_logoutBtn);
            panel2.Controls.Add(mainform_issuebooksBtn);
            panel2.Controls.Add(mainform_returnbooksBtn);
            panel2.Controls.Add(mainform_addbooksBtn);
            panel2.Controls.Add(mainform_dashboardBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 565);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 529);
            label4.Name = "label4";
            label4.Size = new Size(51, 16);
            label4.TabIndex = 7;
            label4.Text = "Log Out";
            // 
            // mainform_logoutBtn
            // 
            mainform_logoutBtn.Cursor = Cursors.Hand;
            mainform_logoutBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            mainform_logoutBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            mainform_logoutBtn.FlatStyle = FlatStyle.Flat;
            mainform_logoutBtn.ForeColor = Color.White;
            mainform_logoutBtn.Image = Properties.Resources.icons8_log_out_20;
            mainform_logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainform_logoutBtn.Location = new Point(9, 522);
            mainform_logoutBtn.Name = "mainform_logoutBtn";
            mainform_logoutBtn.Size = new Size(30, 30);
            mainform_logoutBtn.TabIndex = 6;
            mainform_logoutBtn.UseVisualStyleBackColor = true;
            mainform_logoutBtn.Click += mainform_logoutBtn_Click;
            // 
            // mainform_issuebooksBtn
            // 
            mainform_issuebooksBtn.Cursor = Cursors.Hand;
            mainform_issuebooksBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            mainform_issuebooksBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            mainform_issuebooksBtn.FlatStyle = FlatStyle.Flat;
            mainform_issuebooksBtn.Font = new Font("Tahoma", 9F);
            mainform_issuebooksBtn.ForeColor = Color.White;
            mainform_issuebooksBtn.Image = Properties.Resources.icons8_book_32;
            mainform_issuebooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainform_issuebooksBtn.Location = new Point(9, 325);
            mainform_issuebooksBtn.Name = "mainform_issuebooksBtn";
            mainform_issuebooksBtn.Size = new Size(200, 45);
            mainform_issuebooksBtn.TabIndex = 5;
            mainform_issuebooksBtn.Text = "ISSUE BOOKS";
            mainform_issuebooksBtn.UseVisualStyleBackColor = true;
            mainform_issuebooksBtn.Click += mainform_issuebooksBtn_Click;
            // 
            // mainform_returnbooksBtn
            // 
            mainform_returnbooksBtn.Cursor = Cursors.Hand;
            mainform_returnbooksBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            mainform_returnbooksBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            mainform_returnbooksBtn.FlatStyle = FlatStyle.Flat;
            mainform_returnbooksBtn.Font = new Font("Tahoma", 9F);
            mainform_returnbooksBtn.ForeColor = Color.White;
            mainform_returnbooksBtn.Image = Properties.Resources.icons8_return_book_32;
            mainform_returnbooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainform_returnbooksBtn.Location = new Point(9, 376);
            mainform_returnbooksBtn.Name = "mainform_returnbooksBtn";
            mainform_returnbooksBtn.Size = new Size(200, 45);
            mainform_returnbooksBtn.TabIndex = 4;
            mainform_returnbooksBtn.Text = "RETURN BOOKS";
            mainform_returnbooksBtn.UseVisualStyleBackColor = true;
            mainform_returnbooksBtn.Click += mainform_returnbooksBtn_Click;
            // 
            // mainform_addbooksBtn
            // 
            mainform_addbooksBtn.Cursor = Cursors.Hand;
            mainform_addbooksBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            mainform_addbooksBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            mainform_addbooksBtn.FlatStyle = FlatStyle.Flat;
            mainform_addbooksBtn.Font = new Font("Tahoma", 9F);
            mainform_addbooksBtn.ForeColor = Color.White;
            mainform_addbooksBtn.Image = Properties.Resources.icons8_add_book_32;
            mainform_addbooksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainform_addbooksBtn.Location = new Point(11, 274);
            mainform_addbooksBtn.Name = "mainform_addbooksBtn";
            mainform_addbooksBtn.Size = new Size(200, 45);
            mainform_addbooksBtn.TabIndex = 3;
            mainform_addbooksBtn.Text = "ADD BOOKS";
            mainform_addbooksBtn.UseVisualStyleBackColor = true;
            mainform_addbooksBtn.Click += mainform_addbooksBtn_Click;
            // 
            // mainform_dashboardBtn
            // 
            mainform_dashboardBtn.Cursor = Cursors.Hand;
            mainform_dashboardBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            mainform_dashboardBtn.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            mainform_dashboardBtn.FlatStyle = FlatStyle.Flat;
            mainform_dashboardBtn.Font = new Font("Tahoma", 9F);
            mainform_dashboardBtn.ForeColor = Color.White;
            mainform_dashboardBtn.Image = Properties.Resources.icons8_dashboard_32;
            mainform_dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            mainform_dashboardBtn.Location = new Point(11, 223);
            mainform_dashboardBtn.Name = "mainform_dashboardBtn";
            mainform_dashboardBtn.Size = new Size(200, 45);
            mainform_dashboardBtn.TabIndex = 2;
            mainform_dashboardBtn.Text = "DASHBOARD";
            mainform_dashboardBtn.UseVisualStyleBackColor = true;
            mainform_dashboardBtn.Click += mainform_dashboardBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 138);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 1;
            label3.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_library_100;
            pictureBox1.Location = new Point(64, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addBooks1);
            panel3.Controls.Add(issueBooks1);
            panel3.Controls.Add(returnBooks1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 565);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(880, 565);
            dashboard1.TabIndex = 8;
            // 
            // addBooks1
            // 
            addBooks1.Location = new Point(-2, 0);
            addBooks1.Name = "addBooks1";
            addBooks1.Size = new Size(880, 565);
            addBooks1.TabIndex = 8;
            // 
            // issueBooks1
            // 
            issueBooks1.Location = new Point(0, 0);
            issueBooks1.Name = "issueBooks1";
            issueBooks1.Size = new Size(880, 565);
            issueBooks1.TabIndex = 8;
            // 
            // returnBooks1
            // 
            returnBooks1.Location = new Point(0, 0);
            returnBooks1.Name = "returnBooks1";
            returnBooks1.Size = new Size(880, 565);
            returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Panel panel2;
        private Button mainform_dashboardBtn;
        private Label label3;
        private PictureBox pictureBox1;
        private Button mainform_addbooksBtn;
        private Button mainform_logoutBtn;
        private Button mainform_issuebooksBtn;
        private Button mainform_returnbooksBtn;
        private Label label4;
        private Panel panel3;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
        private Dashboard dashboard1;
    }
}