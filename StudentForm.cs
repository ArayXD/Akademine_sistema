using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcademicSystem
{
    public partial class StudentForm : Form
    {
        string connectionString = "server=localhost;database=academic_system;user=root;password=yourpassword;";
        public int LoggedInStudentId;

        public StudentForm()
        {
            InitializeComponent();
        }

        public void LoadGrades()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT subjects.subject_name, grades.grade " +
                               "FROM grades " +
                               "INNER JOIN subjects ON grades.subject_id = subjects.id " +
                               "WHERE grades.student_id = @studentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", LoggedInStudentId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvGrades.DataSource = dt;
            }
        }
    }
}
