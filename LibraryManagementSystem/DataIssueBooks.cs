using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{


    internal class DataIssueBooks
    {
        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";
        
        public int ID { set; get; }
        public string IssueID { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        // public string Image { set; get; }
        public string DateIssue { set; get; }
        public string DateReturn { set; get; }
        public string Status { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();

            using(SqlConnection connect = new SqlConnection(conect))
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData,connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read()) 
                            { 
                                DataIssueBooks iData = new DataIssueBooks();

                                iData.ID = (int)reader["id"];
                                iData.IssueID = reader["issue_id"].ToString();
                                iData.Name = reader["full_name"].ToString();
                                iData.Contact = reader["contact"].ToString();
                                iData.Email = reader["email"].ToString();
                                iData.BookTitle = reader["book_title"].ToString();
                                iData.Author = reader["author"].ToString();
                                //iData.Image = reader["image"].ToString();
                                iData.DateIssue = reader["issue_date"].ToString();
                                iData.DateReturn = reader["return_date"].ToString();
                                iData.Status = reader["status"].ToString();

                                listData.Add(iData);
                            }
                        }

                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            return listData;
        }

        public List<DataIssueBooks> ReturnBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();

            using (SqlConnection connect = new SqlConnection(conect))
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE  status = 'Not Return' AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                DataIssueBooks iData = new DataIssueBooks();

                                iData.ID = (int)reader["id"];
                                iData.IssueID = reader["issue_id"].ToString();
                                iData.Name = reader["full_name"].ToString();
                                iData.Contact = reader["contact"].ToString();
                                iData.Email = reader["email"].ToString();
                                iData.BookTitle = reader["book_title"].ToString();
                                iData.Author = reader["author"].ToString();
                                //iData.Image = reader["image"].ToString();
                                iData.DateIssue = reader["issue_date"].ToString();
                                iData.DateReturn = reader["return_date"].ToString();
                                iData.Status = reader["status"].ToString();

                                listData.Add(iData);
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
            return listData;
        }

    }

}

