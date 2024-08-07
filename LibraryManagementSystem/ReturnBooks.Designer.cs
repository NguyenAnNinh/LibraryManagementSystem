namespace LibraryManagementSystem
{
    partial class ReturnBooks
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
            returnbooks_bookissued = new DateTimePicker();
            label3 = new Label();
            returnbooks_clearBtn = new Button();
            returnbooks_returnBtn = new Button();
            label8 = new Label();
            returnbooks_author = new TextBox();
            label7 = new Label();
            returnbooks_booktitle = new TextBox();
            label6 = new Label();
            returnbooks_name = new TextBox();
            label5 = new Label();
            returnbooks_contact = new TextBox();
            label4 = new Label();
            returnbooks_email = new TextBox();
            returnbooks_issueid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(returnbooks_bookissued);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(returnbooks_clearBtn);
            panel1.Controls.Add(returnbooks_returnBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(returnbooks_author);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(returnbooks_booktitle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(returnbooks_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(returnbooks_contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(returnbooks_email);
            panel1.Controls.Add(returnbooks_issueid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 532);
            panel1.TabIndex = 0;
            // 
            // returnbooks_bookissued
            // 
            returnbooks_bookissued.Font = new Font("Tahoma", 9.75F);
            returnbooks_bookissued.Location = new Point(87, 282);
            returnbooks_bookissued.Name = "returnbooks_bookissued";
            returnbooks_bookissued.Size = new Size(177, 23);
            returnbooks_bookissued.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 169);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 19;
            label3.Text = "Email:";
            // 
            // returnbooks_clearBtn
            // 
            returnbooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            returnbooks_clearBtn.FlatAppearance.BorderSize = 0;
            returnbooks_clearBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            returnbooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            returnbooks_clearBtn.FlatStyle = FlatStyle.Flat;
            returnbooks_clearBtn.Font = new Font("Arial Narrow", 9.75F);
            returnbooks_clearBtn.ForeColor = Color.White;
            returnbooks_clearBtn.Location = new Point(148, 376);
            returnbooks_clearBtn.Name = "returnbooks_clearBtn";
            returnbooks_clearBtn.Size = new Size(99, 34);
            returnbooks_clearBtn.TabIndex = 16;
            returnbooks_clearBtn.Text = "CLEAR";
            returnbooks_clearBtn.UseVisualStyleBackColor = false;
            returnbooks_clearBtn.Click += returnbooks_clearBtn_Click;
            // 
            // returnbooks_returnBtn
            // 
            returnbooks_returnBtn.BackColor = Color.FromArgb(14, 128, 87);
            returnbooks_returnBtn.FlatAppearance.BorderSize = 0;
            returnbooks_returnBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            returnbooks_returnBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            returnbooks_returnBtn.FlatStyle = FlatStyle.Flat;
            returnbooks_returnBtn.Font = new Font("Arial Narrow", 9.75F);
            returnbooks_returnBtn.ForeColor = Color.White;
            returnbooks_returnBtn.Location = new Point(20, 376);
            returnbooks_returnBtn.Name = "returnbooks_returnBtn";
            returnbooks_returnBtn.Size = new Size(99, 34);
            returnbooks_returnBtn.TabIndex = 15;
            returnbooks_returnBtn.Text = "RETURN";
            returnbooks_returnBtn.UseVisualStyleBackColor = false;
            returnbooks_returnBtn.Click += returnbooks_returnBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1, 287);
            label8.Name = "label8";
            label8.Size = new Size(80, 16);
            label8.TabIndex = 13;
            label8.Text = "Book Issued:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnbooks_author
            // 
            returnbooks_author.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_author.Location = new Point(87, 246);
            returnbooks_author.Name = "returnbooks_author";
            returnbooks_author.Size = new Size(177, 23);
            returnbooks_author.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 247);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 11;
            label7.Text = "Author:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnbooks_booktitle
            // 
            returnbooks_booktitle.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_booktitle.Location = new Point(87, 207);
            returnbooks_booktitle.Name = "returnbooks_booktitle";
            returnbooks_booktitle.Size = new Size(177, 23);
            returnbooks_booktitle.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 208);
            label6.Name = "label6";
            label6.Size = new Size(68, 16);
            label6.TabIndex = 9;
            label6.Text = "Book Title:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // returnbooks_name
            // 
            returnbooks_name.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_name.Location = new Point(87, 92);
            returnbooks_name.Name = "returnbooks_name";
            returnbooks_name.Size = new Size(177, 23);
            returnbooks_name.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 93);
            label5.Name = "label5";
            label5.Size = new Size(45, 16);
            label5.TabIndex = 6;
            label5.Text = "Name:";
            // 
            // returnbooks_contact
            // 
            returnbooks_contact.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_contact.Location = new Point(87, 130);
            returnbooks_contact.Name = "returnbooks_contact";
            returnbooks_contact.Size = new Size(177, 23);
            returnbooks_contact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 137);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 4;
            label4.Text = "Contact #:";
            // 
            // returnbooks_email
            // 
            returnbooks_email.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_email.Location = new Point(87, 168);
            returnbooks_email.Name = "returnbooks_email";
            returnbooks_email.Size = new Size(177, 23);
            returnbooks_email.TabIndex = 3;
            returnbooks_email.TextChanged += textBox2_TextChanged;
            // 
            // returnbooks_issueid
            // 
            returnbooks_issueid.BorderStyle = BorderStyle.FixedSingle;
            returnbooks_issueid.Location = new Point(87, 51);
            returnbooks_issueid.Name = "returnbooks_issueid";
            returnbooks_issueid.Size = new Size(177, 23);
            returnbooks_issueid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 52);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 0;
            label2.Text = "Issue ID:";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(308, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 532);
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
            dataGridView1.Location = new Point(14, 50);
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
            dataGridView1.Size = new Size(529, 464);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 0;
            label1.Text = "All Issued Books";
            label1.Click += label1_Click;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReturnBooks";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox returnbooks_issueid;
        private Label label2;
        private TextBox returnbooks_name;
        private Label label5;
        private TextBox returnbooks_contact;
        private Label label4;
        private TextBox returnbooks_email;
        private Label label8;
        private TextBox returnbooks_author;
        private Label label7;
        private TextBox returnbooks_booktitle;
        private Label label6;
        private Button returnbooks_clearBtn;
        private Button returnbooks_returnBtn;
        private Label label3;
        private DateTimePicker returnbooks_bookissued;
    }
}
