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
    public partial class LoginForm : Form
    {

        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=library;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
            login_password.PasswordChar = '*';
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rForm = new RegisterForm();
            rForm.Show();


            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
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

                            string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    MainForm mForm = new MainForm();
                                    mForm.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
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
    }
}
