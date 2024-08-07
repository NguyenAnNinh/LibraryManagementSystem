using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Chỉ cần sử dụng thư viện này

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";

        public RegisterForm()
        {
            InitializeComponent();
            register_password.PasswordChar = '*';


        }

        private void register_signinBtn_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void register_registerBtn_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
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

                            string checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

                            using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                int count = (int)cmd.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show(register_username.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO users (email, username, password, date_register)" +
                                        " VALUES(@email, @username, @password, @date)";
                                    
                                    using(SqlCommand cmdinsertData  = new SqlCommand(insertData, connect))
                                    {
                                        cmdinsertData.Parameters.AddWithValue("@email", register_email.Text.Trim());
                                        cmdinsertData.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                        cmdinsertData.Parameters.AddWithValue("@password", register_password.Text.Trim());

                                        DateTime today = DateTime.Today;
                                        cmdinsertData.Parameters.AddWithValue("@date", today);

                                        cmdinsertData.ExecuteNonQuery();

                                        MessageBox.Show("Register Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                        LoginForm lForm = new LoginForm();
                                        lForm.Show();

                                        this.Hide();
                                    }
                                }
                            }
                        }
                        catch(Exception ex) 
                        {
                            MessageBox.Show("Error connection Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
