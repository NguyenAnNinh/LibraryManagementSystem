using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {

        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";

        public ReturnBooks()
        {
            InitializeComponent();

            displayReturnBooksData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayReturnBooksData();
        }

        public void displayReturnBooksData()
        {
            DataIssueBooks rData = new DataIssueBooks();
            List<DataIssueBooks> listData = rData.ReturnBooksData();

            dataGridView1.DataSource = listData;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void returnbooks_returnBtn_Click(object sender, EventArgs e)
        {
            if(returnbooks_issueid.Text == ""
                || returnbooks_name.Text == ""
                || returnbooks_contact.Text == ""
                || returnbooks_email.Text == ""
                || returnbooks_booktitle.Text == ""
                || returnbooks_author.Text == ""
                || returnbooks_bookissued.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    try
                    {
                        if(connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE issues SET status = @status, date_update = @dateupdate WHERE issue_id = @issueid";

                        if(MessageBox.Show("Are you sure that Issue ID: " + returnbooks_issueid.Text.Trim() + " is return alraedy?", "Confirmation Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                        {
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateupdate", today);
                                cmd.Parameters.AddWithValue("@issueid", returnbooks_issueid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayReturnBooksData();

                                MessageBox.Show("Returned Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                clearFields();
                            }
                        }
 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public int returnID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                returnID = (int)row.Cells[0].Value;
                returnbooks_issueid.Text = row.Cells[1].Value.ToString();
                returnbooks_name.Text = row.Cells[2].Value.ToString();
                returnbooks_contact.Text = row.Cells[3].Value.ToString();
                returnbooks_email.Text = row.Cells[4].Value.ToString();
                returnbooks_booktitle.Text = row.Cells[5].Value.ToString();
                returnbooks_author.Text = row.Cells[6].Value.ToString();
                returnbooks_bookissued.Text = row.Cells[7].Value.ToString();
            }
        }

        public void clearFields()
        {
            returnbooks_issueid.Text = "";
            returnbooks_name.Text = "";
            returnbooks_contact.Text = "";
            returnbooks_email.Text = "";
            returnbooks_booktitle.Text = "";
            returnbooks_author.Text = "";
        }

        private void returnbooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
