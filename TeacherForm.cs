using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcademicSystem
{
    public partial class TeacherForm : Form
    {
        string connectionString = "server=localhost;database=academic_system;user=root;password=yourpassword;";
        int LoggedInTeacherId;

        public TeacherForm(int teacherId)
        {
            InitializeComponent();
            LoggedInTeacherId = teacherId;
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, subject_name FROM subjects WHERE teacher_id = @teacherId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teacherId", LoggedInTeacherId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbSubjects.DataSource = dt;
                cmbSubjects.DisplayMember = "subject_name";
                cmbSubjects.ValueMember = "id";
            }
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubjects.SelectedValue != null)
            {
                int subjectId = Convert.ToInt32(cmbSubjects.SelectedValue);
                LoadStudents(subjectId);
            }
        }

        private void LoadStudents(int subjectId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT students.id, students.first_name, students.last_name, grades.grade " +
                               "FROM students " +
                               "LEFT JOIN grades ON students.id = grades.student_id AND grades.subject_id = @subjectId " +
                               "WHERE students.group_id IN (SELECT group_id FROM group_subjects WHERE subject_id = @subjectId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells[0].Value);
                int subjectId = Convert.ToInt32(cmbSubjects.SelectedValue);
                decimal grade;

                if (!decimal.TryParse(txtGrade.Text, out grade))
                {
                    MessageBox.Show("Please enter a valid grade.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO grades (student_id, subject_id, grade) " +
                                   "VALUES (@s, @sub, @g) ON DUPLICATE KEY UPDATE grade = @g";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@s", studentId);
                    cmd.Parameters.AddWithValue("@sub", subjectId);
                    cmd.Parameters.AddWithValue("@g", grade);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grade saved successfully.");
                    LoadStudents(subjectId);
                }
            }
        }
    }
}
