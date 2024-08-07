namespace LibraryManagementSystem
{
    partial class IssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label10 = new Label();
            label3 = new Label();
            issuebooks_status = new ComboBox();
            issuebooks_clearBtn = new Button();
            issuebooks_deleteBtn = new Button();
            issuebooks_updateBtn = new Button();
            issuebooks_addBtn = new Button();
            issuebooks_picture = new PictureBox();
            issuebooks_returndate = new DateTimePicker();
            issuebooks_issuedate = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            issuebooks_author = new ComboBox();
            label7 = new Label();
            issuebooks_booktitle = new ComboBox();
            issuebooks_name = new TextBox();
            label6 = new Label();
            issuebooks_contact = new TextBox();
            label5 = new Label();
            issuebooks_email = new TextBox();
            label4 = new Label();
            issuebooks_issueid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)issuebooks_picture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(issuebooks_status);
            panel1.Controls.Add(issuebooks_clearBtn);
            panel1.Controls.Add(issuebooks_deleteBtn);
            panel1.Controls.Add(issuebooks_updateBtn);
            panel1.Controls.Add(issuebooks_addBtn);
            panel1.Controls.Add(issuebooks_picture);
            panel1.Controls.Add(issuebooks_returndate);
            panel1.Controls.Add(issuebooks_issuedate);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(issuebooks_author);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(issuebooks_booktitle);
            panel1.Controls.Add(issuebooks_name);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(issuebooks_contact);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(issuebooks_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(issuebooks_issueid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 211);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(533, 22);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 25;
            label10.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(284, 22);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 24;
            label3.Text = "Book Title:";
            // 
            // issuebooks_status
            // 
            issuebooks_status.Font = new Font("Tahoma", 9.75F);
            issuebooks_status.FormattingEnabled = true;
            issuebooks_status.Items.AddRange(new object[] { "Return", "Not Return" });
            issuebooks_status.Location = new Point(587, 19);
            issuebooks_status.Name = "issuebooks_status";
            issuebooks_status.Size = new Size(133, 24);
            issuebooks_status.TabIndex = 23;
            issuebooks_status.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // issuebooks_clearBtn
            // 
            issuebooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            issuebooks_clearBtn.FlatAppearance.BorderSize = 0;
            issuebooks_clearBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            issuebooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issuebooks_clearBtn.FlatStyle = FlatStyle.Flat;
            issuebooks_clearBtn.Font = new Font("Arial Narrow", 9.75F);
            issuebooks_clearBtn.ForeColor = Color.White;
            issuebooks_clearBtn.Location = new Point(562, 165);
            issuebooks_clearBtn.Name = "issuebooks_clearBtn";
            issuebooks_clearBtn.Size = new Size(99, 34);
            issuebooks_clearBtn.TabIndex = 21;
            issuebooks_clearBtn.Text = "CLEAR";
            issuebooks_clearBtn.UseVisualStyleBackColor = false;
            issuebooks_clearBtn.Click += issuebooks_clearBtn_Click;
            // 
            // issuebooks_deleteBtn
            // 
            issuebooks_deleteBtn.BackColor = Color.FromArgb(14, 128, 87);
            issuebooks_deleteBtn.FlatAppearance.BorderSize = 0;
            issuebooks_deleteBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            issuebooks_deleteBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issuebooks_deleteBtn.FlatStyle = FlatStyle.Flat;
            issuebooks_deleteBtn.Font = new Font("Arial Narrow", 9.75F);
            issuebooks_deleteBtn.ForeColor = Color.White;
            issuebooks_deleteBtn.Location = new Point(418, 165);
            issuebooks_deleteBtn.Name = "issuebooks_deleteBtn";
            issuebooks_deleteBtn.Size = new Size(99, 34);
            issuebooks_deleteBtn.TabIndex = 20;
            issuebooks_deleteBtn.Text = "DELETE";
            issuebooks_deleteBtn.UseVisualStyleBackColor = false;
            issuebooks_deleteBtn.Click += issuebooks_deleteBtn_Click;
            // 
            // issuebooks_updateBtn
            // 
            issuebooks_updateBtn.BackColor = Color.FromArgb(14, 128, 87);
            issuebooks_updateBtn.FlatAppearance.BorderSize = 0;
            issuebooks_updateBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            issuebooks_updateBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issuebooks_updateBtn.FlatStyle = FlatStyle.Flat;
            issuebooks_updateBtn.Font = new Font("Arial Narrow", 9.75F);
            issuebooks_updateBtn.ForeColor = Color.White;
            issuebooks_updateBtn.Location = new Point(283, 165);
            issuebooks_updateBtn.Name = "issuebooks_updateBtn";
            issuebooks_updateBtn.Size = new Size(99, 34);
            issuebooks_updateBtn.TabIndex = 19;
            issuebooks_updateBtn.Text = "UPDATE";
            issuebooks_updateBtn.UseVisualStyleBackColor = false;
            issuebooks_updateBtn.Click += issuebooks_updateBtn_Click;
            // 
            // issuebooks_addBtn
            // 
            issuebooks_addBtn.BackColor = Color.FromArgb(14, 128, 87);
            issuebooks_addBtn.FlatAppearance.BorderSize = 0;
            issuebooks_addBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            issuebooks_addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            issuebooks_addBtn.FlatStyle = FlatStyle.Flat;
            issuebooks_addBtn.Font = new Font("Arial Narrow", 9.75F);
            issuebooks_addBtn.ForeColor = Color.White;
            issuebooks_addBtn.Location = new Point(152, 165);
            issuebooks_addBtn.Name = "issuebooks_addBtn";
            issuebooks_addBtn.Size = new Size(99, 34);
            issuebooks_addBtn.TabIndex = 18;
            issuebooks_addBtn.Text = "ADD";
            issuebooks_addBtn.UseVisualStyleBackColor = false;
            issuebooks_addBtn.Click += issuebooks_addBtn_Click;
            // 
            // issuebooks_picture
            // 
            issuebooks_picture.BackColor = SystemColors.ActiveBorder;
            issuebooks_picture.Location = new Point(739, 12);
            issuebooks_picture.Name = "issuebooks_picture";
            issuebooks_picture.Size = new Size(100, 100);
            issuebooks_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            issuebooks_picture.TabIndex = 17;
            issuebooks_picture.TabStop = false;
            // 
            // issuebooks_returndate
            // 
            issuebooks_returndate.Font = new Font("Tahoma", 9.75F);
            issuebooks_returndate.Location = new Point(358, 134);
            issuebooks_returndate.Name = "issuebooks_returndate";
            issuebooks_returndate.Size = new Size(201, 23);
            issuebooks_returndate.TabIndex = 16;
            // 
            // issuebooks_issuedate
            // 
            issuebooks_issuedate.Font = new Font("Tahoma", 9.75F);
            issuebooks_issuedate.Location = new Point(358, 96);
            issuebooks_issuedate.Name = "issuebooks_issuedate";
            issuebooks_issuedate.Size = new Size(201, 23);
            issuebooks_issuedate.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(310, 101);
            label9.Name = "label9";
            label9.Size = new Size(42, 16);
            label9.TabIndex = 14;
            label9.Text = "Issue:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(302, 139);
            label8.Name = "label8";
            label8.Size = new Size(50, 16);
            label8.TabIndex = 13;
            label8.Text = "Return:";
            // 
            // issuebooks_author
            // 
            issuebooks_author.Font = new Font("Tahoma", 9.75F);
            issuebooks_author.FormattingEnabled = true;
            issuebooks_author.Location = new Point(358, 56);
            issuebooks_author.Name = "issuebooks_author";
            issuebooks_author.Size = new Size(133, 24);
            issuebooks_author.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 58);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 11;
            label7.Text = "Author:";
            // 
            // issuebooks_booktitle
            // 
            issuebooks_booktitle.Font = new Font("Tahoma", 9.75F);
            issuebooks_booktitle.FormattingEnabled = true;
            issuebooks_booktitle.Location = new Point(358, 17);
            issuebooks_booktitle.Name = "issuebooks_booktitle";
            issuebooks_booktitle.Size = new Size(133, 24);
            issuebooks_booktitle.TabIndex = 10;
            issuebooks_booktitle.SelectedIndexChanged += issuebooks_booktitle_SelectedIndexChanged;
            // 
            // issuebooks_name
            // 
            issuebooks_name.BorderStyle = BorderStyle.FixedSingle;
            issuebooks_name.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuebooks_name.Location = new Point(81, 56);
            issuebooks_name.Name = "issuebooks_name";
            issuebooks_name.Size = new Size(175, 23);
            issuebooks_name.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 58);
            label6.Name = "label6";
            label6.Size = new Size(45, 16);
            label6.TabIndex = 8;
            label6.Text = "Name:";
            // 
            // issuebooks_contact
            // 
            issuebooks_contact.BorderStyle = BorderStyle.FixedSingle;
            issuebooks_contact.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuebooks_contact.Location = new Point(81, 96);
            issuebooks_contact.Name = "issuebooks_contact";
            issuebooks_contact.Size = new Size(175, 23);
            issuebooks_contact.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 98);
            label5.Name = "label5";
            label5.Size = new Size(68, 16);
            label5.TabIndex = 6;
            label5.Text = "Contact #:";
            // 
            // issuebooks_email
            // 
            issuebooks_email.BorderStyle = BorderStyle.FixedSingle;
            issuebooks_email.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuebooks_email.Location = new Point(81, 134);
            issuebooks_email.Name = "issuebooks_email";
            issuebooks_email.Size = new Size(175, 23);
            issuebooks_email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 136);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // issuebooks_issueid
            // 
            issuebooks_issueid.BorderStyle = BorderStyle.FixedSingle;
            issuebooks_issueid.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            issuebooks_issueid.Location = new Point(81, 15);
            issuebooks_issueid.Name = "issuebooks_issueid";
            issuebooks_issueid.Size = new Size(175, 23);
            issuebooks_issueid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 0;
            label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 310);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(14, 128, 87);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(827, 250);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 1;
            label1.Text = "All Issued Books";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)issuebooks_picture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private TextBox issuebooks_name;
        private Label label6;
        private TextBox issuebooks_contact;
        private Label label5;
        private TextBox issuebooks_email;
        private Label label4;
        private TextBox issuebooks_issueid;
        private DateTimePicker issuebooks_issuedate;
        private Label label9;
        private Label label8;
        private ComboBox issuebooks_author;
        private Label label7;
        private ComboBox issuebooks_booktitle;
        private PictureBox issuebooks_picture;
        private DateTimePicker issuebooks_returndate;
        private Button issuebooks_clearBtn;
        private Button issuebooks_deleteBtn;
        private Button issuebooks_updateBtn;
        private Button issuebooks_addBtn;
        private ComboBox issuebooks_status;
        private Label label10;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
