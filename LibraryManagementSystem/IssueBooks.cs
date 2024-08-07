using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {

        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";

        public IssueBooks()
        {
            InitializeComponent();

            displayIssueData();
            DataBookTitle();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssueData();
            DataBookTitle();
        }

        public void displayIssueData()
        {
            DataIssueBooks iData = new DataIssueBooks();
            List<DataIssueBooks> listData = iData.IssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void issuebooks_addBtn_Click(object sender, EventArgs e)
        {
            if (issuebooks_issueid.Text == ""
                || issuebooks_name.Text == ""
                || issuebooks_contact.Text == ""
                || issuebooks_email.Text == ""
                || issuebooks_booktitle.Text == ""
                || issuebooks_author.Text == ""
                || issuebooks_issuedate.Text == null
                || issuebooks_returndate.Text == null
                || issuebooks_status.Text == ""
                || issuebooks_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            DateTime today = DateTime.Today;

                            string insertData = "INSERT INTO issues " +
                                "(issue_id, full_name, contact, email, book_title, author" +
                                ", status, issue_date, return_date, date_insert) " +
                                "VALUES(@issueid, @fullname, @contact, @email, @booktitle, @author" +
                                ", @status, @issuedate, @returndate, @dateinsert)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@issueid", issuebooks_issueid.Text.Trim());
                                cmd.Parameters.AddWithValue("@fullname", issuebooks_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", issuebooks_contact.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", issuebooks_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@booktitle", issuebooks_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", issuebooks_author.Text.Trim());
                                //cmd.Parameters.AddWithValue("@image", issuebooks_picture.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", issuebooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@issuedate", issuebooks_issuedate.Value);
                                cmd.Parameters.AddWithValue("@returndate", issuebooks_returndate.Value);
                                cmd.Parameters.AddWithValue("@dateinsert", today);


                                cmd.ExecuteNonQuery();

                                displayIssueData();

                                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
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
        }

        public void DataBookTitle()
        {
            using (SqlConnection connect = new SqlConnection(conect))
            {

                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM books WHERE status ='Available' AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            issuebooks_booktitle.DataSource = table;
                            issuebooks_booktitle.DisplayMember = "book_title";
                            issuebooks_booktitle.ValueMember = "id";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void issuebooks_booktitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conect))
            {
                if (connect.State != ConnectionState.Open)
                {
                    if (issuebooks_booktitle.SelectedValue != null)
                    {
                        DataRowView selectRow = (DataRowView)issuebooks_booktitle.SelectedItem;
                        int selectID = Convert.ToInt32(selectRow["id"]);

                        try
                        {
                            connect.Open();

                            string selectData = "SELECT * FROM books WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", selectID);

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    issuebooks_author.Text = table.Rows[0]["author"].ToString();

                                    string imagePath = table.Rows[0]["image"].ToString();

                                    if (imagePath != null)
                                    {
                                        issuebooks_picture.Image = Image.FromFile(imagePath);
                                    }
                                    else
                                    {
                                        issuebooks_picture.Image = null;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

        }
        public void clearFields()
        {
            issuebooks_issueid.Text = "";
            issuebooks_name.Text = "";
            issuebooks_contact.Text = "";
            issuebooks_email.Text = "";
            issuebooks_booktitle.SelectedIndex = -1;
            issuebooks_author.SelectedIndex = -1;
            issuebooks_issuedate.Text = null;
            issuebooks_returndate.Text = null;
            issuebooks_status.SelectedIndex = -1;
            issuebooks_picture.Image = null;
        }

        private int issueID = 0;

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                issueID = (int)row.Cells[0].Value;
                issuebooks_issueid.Text = row.Cells[1].Value.ToString();
                issuebooks_name.Text = row.Cells[2].Value.ToString();
                issuebooks_contact.Text = row.Cells[3].Value.ToString();
                issuebooks_email.Text = row.Cells[4].Value.ToString();
                issuebooks_booktitle.Text = row.Cells[5].Value.ToString();
                issuebooks_author.Text = row.Cells[6].Value.ToString();
                issuebooks_issuedate.Text = row.Cells[7].Value.ToString();
                issuebooks_returndate.Text = row.Cells[8].Value.ToString();
                issuebooks_status.Text = row.Cells[9].Value.ToString();
            }
        }

        private void issuebooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (issuebooks_issueid.Text == ""
                || issuebooks_name.Text == ""
                || issuebooks_contact.Text == ""
                || issuebooks_email.Text == ""
                || issuebooks_booktitle.Text == ""
                || issuebooks_author.Text == ""
                || issuebooks_issuedate.Text == null
                || issuebooks_returndate.Text == null
                || issuebooks_status.Text == ""
                || issuebooks_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE issues SET full_name = @fullname, contact = @contact," +
                            " email = @email, book_title = @booktitle, author = @author, status = @status," +
                            " issue_date = @issuedate, return_date = @returndate, date_update = @dateupdate" +
                            " WHERE issue_id = @issueid";

                        if (MessageBox.Show("Are you sure you want to UPDATE issueID: " + issuebooks_issueid.Text.Trim() + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@fullname", issuebooks_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", issuebooks_contact.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", issuebooks_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@booktitle", issuebooks_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", issuebooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", issuebooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@issuedate", issuebooks_issuedate.Value);
                                cmd.Parameters.AddWithValue("@returndate", issuebooks_returndate.Value);
                                cmd.Parameters.AddWithValue("@dateupdate", today);
                                cmd.Parameters.AddWithValue("@issueid", issuebooks_issueid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayIssueData();

                                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void issuebooks_deleteBtn_Click(object sender, EventArgs e)
        {
            if (issuebooks_issueid.Text == ""
                || issuebooks_name.Text == ""
                || issuebooks_contact.Text == ""
                || issuebooks_email.Text == ""
                || issuebooks_booktitle.Text == ""
                || issuebooks_author.Text == ""
                || issuebooks_issuedate.Text == null
                || issuebooks_returndate.Text == null
                || issuebooks_status.Text == ""
                || issuebooks_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE issues SET date_delete = @datedelete WHERE issue_id = @issueid";

                        if (MessageBox.Show("Are you sure you want to DELETE issueID " + issuebooks_issueid.Text.Trim() + " ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@datedelete", today);
                                cmd.Parameters.AddWithValue("@issueid", issuebooks_issueid.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayIssueData();

                                MessageBox.Show("Delete Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void issuebooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}

