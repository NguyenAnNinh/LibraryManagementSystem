using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    internal class DataAddBooks
    {
        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";
        public int ID { set; get; }

        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string Published { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }

        public List<DataAddBooks> addDataBooks()
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();


            using (SqlConnection connect = new SqlConnection(conect))
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
            
                        string selectData = "SELECT * FROM books WHERE date_delete is NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();


                            while (reader.Read()) 
                            { 
                                DataAddBooks abData = new DataAddBooks();

                                abData.ID = (int)reader["id"];
                                abData.BookTitle = reader["book_title"].ToString();
                                abData.Author = reader["author"].ToString();
                                abData.Published = reader["published_date"].ToString();
                                abData.Image = reader["image"].ToString();
                                abData.Status = reader["status"].ToString();

                                listData.Add(abData);
                            }
                        }
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
