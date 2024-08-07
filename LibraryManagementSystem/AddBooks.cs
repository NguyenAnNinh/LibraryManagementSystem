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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {

        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";

        public AddBooks()
        {
            InitializeComponent();

            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }

        public void displayBooks()
        {
            DataAddBooks abData = new DataAddBooks();
            List<DataAddBooks> listData = abData.addDataBooks();

            dataGridView1.DataSource = listData;
        }

        private void addbooks_importBtn_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)| *.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addbooks_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addbooks_addBtn_Click(object sender, EventArgs e)
        {
            if (addbooks_picture.Image == null
                || addbooks_booktitle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_pushlished.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image == null)
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

                            string insertData = "INSERT INTO books " +
                                "(book_title, author, published_date, status, image, date_insert)" +
                                " VALUES(@booktitle, @author, @published, @status, @image, @dateinsert)";

                            DateTime today = DateTime.Today;

                            string path = Path.Combine(@"C:\Users\Admin\source\repos\LibraryManagementSystem\LibraryManagementSystem\Books Directory\" +
                                  addbooks_booktitle.Text.Trim() + addbooks_author.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(addbooks_picture.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@booktitle", addbooks_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addbooks_pushlished.Value);
                                cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);


                                cmd.Parameters.AddWithValue("@dateinsert", today);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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

        private int bookID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                bookID = (int)row.Cells[0].Value;
                addbooks_booktitle.Text = row.Cells[1].Value.ToString();
                addbooks_author.Text = row.Cells[2].Value.ToString();
                addbooks_pushlished.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();

                if (imagePath != null || imagePath.Length >= 1)
                {
                    addbooks_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addbooks_picture.Image = null;
                }

                addbooks_status.Text = row.Cells[5].Value.ToString();
            }
        }

        public void clearFields()
        {
            addbooks_booktitle.Text = "";
            addbooks_author.Text = "";
            addbooks_picture.Image = null;
            addbooks_status.SelectedIndex = -1;
        }

        private void addbooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addbooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (addbooks_picture.Image == null
                || addbooks_booktitle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_pushlished.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to UPDATE Book ID:" + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conect))
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            try
                            {
                                connect.Open();
                                DateTime today = DateTime.Today;
                                string updateData = "UPDATE books SET book_title = @booktitle," +
                                    " author = @author, published_date = @published, status = @status," +
                                    " date_update = @dateupdate WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@booktitle", addbooks_booktitle.Text.Trim());
                                    cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                                    cmd.Parameters.AddWithValue("@published", addbooks_pushlished.Value);
                                    cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateupdate", today);
                                    cmd.Parameters.AddWithValue("@id", bookID);

                                    cmd.ExecuteNonQuery();

                                    displayBooks();

                                    MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        else
                        {
                            MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
        }

        private void addbooks_deleteBtn_Click(object sender, EventArgs e)
        {


            if (addbooks_picture.Image == null
                || addbooks_booktitle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_pushlished.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to DELETE Book ID:" + bookID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conect))
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            try
                            {
                                connect.Open();
                                DateTime today = DateTime.Today;
                                string deleteData = "UPDATE books SET date_delete = @datedelete WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@datedelete", today);
                                    cmd.Parameters.AddWithValue("@id", bookID);

                                    cmd.ExecuteNonQuery();

                                    displayBooks();

                                    MessageBox.Show("Delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        else
                        {
                            MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }

        }
    }
}
