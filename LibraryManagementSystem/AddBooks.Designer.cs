namespace LibraryManagementSystem
{
    partial class AddBooks
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            addbooks_importBtn = new Button();
            addbooks_pushlished = new DateTimePicker();
            addbooks_updateBtn = new Button();
            addbooks_addBtn = new Button();
            addbooks_status = new ComboBox();
            label9 = new Label();
            addbooks_clearBtn = new Button();
            addbooks_deleteBtn = new Button();
            label8 = new Label();
            addbooks_author = new TextBox();
            label7 = new Label();
            addbooks_booktitle = new TextBox();
            label6 = new Label();
            addbooks_picture = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_picture).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(307, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 532);
            panel2.TabIndex = 3;
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
            dataGridView1.Location = new Point(14, 51);
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
            dataGridView1.Size = new Size(528, 463);
            dataGridView1.TabIndex = 1;
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
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(addbooks_importBtn);
            panel1.Controls.Add(addbooks_pushlished);
            panel1.Controls.Add(addbooks_updateBtn);
            panel1.Controls.Add(addbooks_addBtn);
            panel1.Controls.Add(addbooks_status);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(addbooks_clearBtn);
            panel1.Controls.Add(addbooks_deleteBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addbooks_author);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(addbooks_booktitle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addbooks_picture);
            panel1.Location = new Point(15, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 532);
            panel1.TabIndex = 2;
            // 
            // addbooks_importBtn
            // 
            addbooks_importBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbooks_importBtn.FlatAppearance.BorderSize = 0;
            addbooks_importBtn.FlatStyle = FlatStyle.Flat;
            addbooks_importBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbooks_importBtn.ForeColor = Color.White;
            addbooks_importBtn.Location = new Point(90, 112);
            addbooks_importBtn.Name = "addbooks_importBtn";
            addbooks_importBtn.Size = new Size(100, 31);
            addbooks_importBtn.TabIndex = 22;
            addbooks_importBtn.Text = "Import";
            addbooks_importBtn.UseVisualStyleBackColor = false;
            addbooks_importBtn.Click += addbooks_importBtn_Click;
            // 
            // addbooks_pushlished
            // 
            addbooks_pushlished.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbooks_pushlished.Location = new Point(90, 245);
            addbooks_pushlished.Name = "addbooks_pushlished";
            addbooks_pushlished.Size = new Size(177, 23);
            addbooks_pushlished.TabIndex = 21;
            // 
            // addbooks_updateBtn
            // 
            addbooks_updateBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbooks_updateBtn.FlatAppearance.BorderSize = 0;
            addbooks_updateBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            addbooks_updateBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbooks_updateBtn.FlatStyle = FlatStyle.Flat;
            addbooks_updateBtn.Font = new Font("Arial Narrow", 9.75F);
            addbooks_updateBtn.ForeColor = Color.White;
            addbooks_updateBtn.Location = new Point(147, 427);
            addbooks_updateBtn.Name = "addbooks_updateBtn";
            addbooks_updateBtn.Size = new Size(99, 34);
            addbooks_updateBtn.TabIndex = 20;
            addbooks_updateBtn.Text = "UPDATE";
            addbooks_updateBtn.UseVisualStyleBackColor = false;
            addbooks_updateBtn.Click += addbooks_updateBtn_Click;
            // 
            // addbooks_addBtn
            // 
            addbooks_addBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbooks_addBtn.FlatAppearance.BorderSize = 0;
            addbooks_addBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            addbooks_addBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbooks_addBtn.FlatStyle = FlatStyle.Flat;
            addbooks_addBtn.Font = new Font("Arial Narrow", 9.75F);
            addbooks_addBtn.ForeColor = Color.White;
            addbooks_addBtn.Location = new Point(19, 427);
            addbooks_addBtn.Name = "addbooks_addBtn";
            addbooks_addBtn.Size = new Size(99, 34);
            addbooks_addBtn.TabIndex = 19;
            addbooks_addBtn.Text = "ADD";
            addbooks_addBtn.UseVisualStyleBackColor = false;
            addbooks_addBtn.Click += addbooks_addBtn_Click;
            // 
            // addbooks_status
            // 
            addbooks_status.Font = new Font("Tahoma", 9.75F);
            addbooks_status.FormattingEnabled = true;
            addbooks_status.Items.AddRange(new object[] { "Available", "Not Available" });
            addbooks_status.Location = new Point(90, 288);
            addbooks_status.Name = "addbooks_status";
            addbooks_status.Size = new Size(177, 24);
            addbooks_status.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 291);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 17;
            label9.Text = "Status:";
            // 
            // addbooks_clearBtn
            // 
            addbooks_clearBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbooks_clearBtn.FlatAppearance.BorderSize = 0;
            addbooks_clearBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            addbooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbooks_clearBtn.FlatStyle = FlatStyle.Flat;
            addbooks_clearBtn.Font = new Font("Arial Narrow", 9.75F);
            addbooks_clearBtn.ForeColor = Color.White;
            addbooks_clearBtn.Location = new Point(147, 481);
            addbooks_clearBtn.Name = "addbooks_clearBtn";
            addbooks_clearBtn.Size = new Size(99, 34);
            addbooks_clearBtn.TabIndex = 16;
            addbooks_clearBtn.Text = "CLEAR";
            addbooks_clearBtn.UseVisualStyleBackColor = false;
            addbooks_clearBtn.Click += addbooks_clearBtn_Click;
            // 
            // addbooks_deleteBtn
            // 
            addbooks_deleteBtn.BackColor = Color.FromArgb(14, 128, 87);
            addbooks_deleteBtn.FlatAppearance.BorderSize = 0;
            addbooks_deleteBtn.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            addbooks_deleteBtn.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            addbooks_deleteBtn.FlatStyle = FlatStyle.Flat;
            addbooks_deleteBtn.Font = new Font("Arial Narrow", 9.75F);
            addbooks_deleteBtn.ForeColor = Color.White;
            addbooks_deleteBtn.Location = new Point(19, 481);
            addbooks_deleteBtn.Name = "addbooks_deleteBtn";
            addbooks_deleteBtn.Size = new Size(99, 34);
            addbooks_deleteBtn.TabIndex = 15;
            addbooks_deleteBtn.Text = "DELETE";
            addbooks_deleteBtn.UseVisualStyleBackColor = false;
            addbooks_deleteBtn.Click += addbooks_deleteBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 250);
            label8.Name = "label8";
            label8.Size = new Size(66, 16);
            label8.TabIndex = 13;
            label8.Text = "Published:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addbooks_author
            // 
            addbooks_author.BorderStyle = BorderStyle.FixedSingle;
            addbooks_author.Location = new Point(90, 209);
            addbooks_author.Name = "addbooks_author";
            addbooks_author.Size = new Size(177, 23);
            addbooks_author.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 210);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 11;
            label7.Text = "Author:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addbooks_booktitle
            // 
            addbooks_booktitle.BorderStyle = BorderStyle.FixedSingle;
            addbooks_booktitle.Location = new Point(90, 170);
            addbooks_booktitle.Name = "addbooks_booktitle";
            addbooks_booktitle.Size = new Size(177, 23);
            addbooks_booktitle.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 171);
            label6.Name = "label6";
            label6.Size = new Size(68, 16);
            label6.TabIndex = 9;
            label6.Text = "Book Title:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addbooks_picture
            // 
            addbooks_picture.BackColor = SystemColors.ActiveBorder;
            addbooks_picture.Location = new Point(90, 14);
            addbooks_picture.Name = "addbooks_picture";
            addbooks_picture.Size = new Size(100, 100);
            addbooks_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addbooks_picture.TabIndex = 8;
            addbooks_picture.TabStop = false;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddBooks";
            Size = new Size(880, 565);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private ComboBox addbooks_status;
        private Label label9;
        private Button addbooks_clearBtn;
        private Button addbooks_deleteBtn;
        private Label label8;
        private TextBox addbooks_author;
        private Label label7;
        private TextBox addbooks_booktitle;
        private Label label6;
        private PictureBox addbooks_picture;
        private Button addbooks_updateBtn;
        private Button addbooks_addBtn;
        private DateTimePicker addbooks_pushlished;
        private Button addbooks_importBtn;
    }
}
