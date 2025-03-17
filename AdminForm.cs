using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcademicSystem
{
    public partial class AdminForm : Form
    {
        string connectionString = "server=localhost;database=academic_system;user=root;";

        public AdminForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadSubjects();
            LoadGroups();
        }


        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, first_name, last_name, role FROM users";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }


        private void LoadSubjects()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, subject_name FROM subjects";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSubjects.DataSource = dt;
            }
        }


        private void LoadGroups()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, group_name FROM groups";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvGroups.DataSource = dt;
            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Enter valid First Name, Last Name, and Role.");
                return;
            }

            string username = firstName.ToLower();
            string password = lastName.ToLower();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (first_name, last_name, username, password, role) VALUES (@f, @l, @u, @p, @r)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@f", firstName);
                cmd.Parameters.AddWithValue("@l", lastName);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.ExecuteNonQuery();
                LoadUsers();
            }
        }


        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                    LoadUsers();
                }
            }
        }


        private void btnAddSubject_Click_1(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Enter a valid subject name.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO subjects (subject_name) VALUES (@subject)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@subject", subjectName);
                cmd.ExecuteNonQuery();
                LoadSubjects();
            }
        }


        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0)
            {
                int subjectId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells[0].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM subjects WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    cmd.ExecuteNonQuery();
                    LoadSubjects();
                }
            }
        }


        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text.Trim();

            if (string.IsNullOrWhiteSpace(groupName))
            {
                MessageBox.Show("Enter a valid group name.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO groups (group_name) VALUES (@group)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@group", groupName);
                cmd.ExecuteNonQuery();
                LoadGroups();
            }
        }


        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count > 0)
            {
                int groupId = Convert.ToInt32(dgvGroups.SelectedRows[0].Cells[0].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM groups WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", groupId);
                    cmd.ExecuteNonQuery();
                    LoadGroups();
                }
            }
        }

    }
}
