using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainform_logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show();

                this.Hide();
            }
        }

        private void mainform_dashboardBtn_Click(object sender, EventArgs e)
        {
            addBooks1.Visible = false;
            issueBooks1.Visible = false;
            dashboard1.Visible = true;
            returnBooks1.Visible = false;

            Dashboard dashboard = dashboard1 as Dashboard;
            if (dashboard != null)
            {
                dashboard.refreshData();
            }
        }

        private void mainform_addbooksBtn_Click(object sender, EventArgs e)
        {
            addBooks1.Visible = true;
            issueBooks1.Visible = false;
            dashboard1.Visible = false;
            returnBooks1.Visible = false;

            AddBooks aBook = addBooks1 as AddBooks;
            if (aBook != null)
            {
                aBook.refreshData();
            }
        }

        private void mainform_issuebooksBtn_Click(object sender, EventArgs e)
        {
            addBooks1.Visible = false;
            issueBooks1.Visible = true;
            dashboard1.Visible = false;
            returnBooks1.Visible = false;

            IssueBooks iBook = issueBooks1 as IssueBooks;
            if (iBook != null)
            {
                iBook.refreshData();
            }
        }

        private void mainform_returnbooksBtn_Click(object sender, EventArgs e)
        {
            addBooks1.Visible = false;
            issueBooks1.Visible = false;
            dashboard1.Visible = false;
            returnBooks1.Visible = true;

            ReturnBooks rBook = returnBooks1 as ReturnBooks;
            if (rBook != null)
            {
                rBook.refreshData();
            }
        }
    }
}
