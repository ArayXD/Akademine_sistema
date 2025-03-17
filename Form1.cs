using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcademicSystem
{
    public partial class Form1 : Form
    {
        // MySQL connection string
        string connectionString = "server=localhost;database=academic_system;user=root;password=yourpassword;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter username and password.";
                lblMessage.Visible = true;
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username = @username AND password = @password;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Login successful! Role: {role}");

                        // Redirect based on role
                        if (role == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (role == "teacher")
                        {
                            TeacherForm teacherForm = new TeacherForm();
                            teacherForm.Show();
                        }
                        else if (role == "student")
                        {
                            StudentForm studentForm = new StudentForm();
                            studentForm.Show();
                        }

                        this.Hide(); // Hide login form after successful login
                    }
                    else
                    {
                        lblMessage.Text = "Invalid username or password.";
                        lblMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
