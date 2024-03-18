using StudentGradeManagement.Desktop.DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentGradeManagement.Desktop
{
    public partial class GradingForm : Form
    {
        public GradingForm()
        {

            InitializeComponent();
            PopulateDataViews();
        }

        private void PopulateDataViews()
        {
            var instructorId = SessionManager.AuthenticatedInstructor.InstructorId;

            cbClasses.DataSource = GetStudentClass(instructorId);
            cbClasses.ValueMember = "Class Id";
            cbClasses.DisplayMember = "Class Name";

            cbCourses.DataSource = GetCourses(instructorId);
            cbCourses.ValueMember = "Course Id";
            cbCourses.DisplayMember = "Course Name";



        }

        private DataTable GetStudentClass(string instructorId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT c.ClassId as ""Class Id"",
                       CONCAT(c.ClassId, ' - ', c.ClassName) as ""Class Name""
                FROM Classes c
	                WHERE c.ClassId IN (
		                SELECT DISTINCT t.ClassId
				                FROM Teachings t
				                WHERE t.InstructorId = @instructorId
	                );
             ";
            try
            {
                SqlConnection connection = SqlDataAccess.ConnectionInstance;

                SqlDataAccess.OpenConnection();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@instructorId", instructorId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                SqlDataAccess.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }


            return dt;
        }

        private DataTable GetCourses(string instructorId)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT c.CourseId as ""Course Id"",
                    CONCAT(c.CourseId, ' - ', c.CourseName) as ""Course Name""
                FROM Courses c
	                WHERE c.CourseId IN (
		                SELECT DISTINCT t.CourseId
				                FROM Teachings t
				                WHERE t.InstructorId = @InstructorId
	            );
             ";
            try
            {
                SqlConnection connection = SqlDataAccess.ConnectionInstance;

                SqlDataAccess.OpenConnection();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@instructorId", instructorId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                }

                SqlDataAccess.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }


            return dt;
        }
        private DataTable GetStudentGrades(string classId, string courseId, string instructorId)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT s.StudentId, s.StudentName, c.CourseName, g.Score
                FROM Students s
                INNER JOIN Grades g ON s.StudentId = g.StudentId
                INNER JOIN Courses c ON c.CourseId = g.CourseId
                WHERE EXISTS (
                    SELECT 1
                    FROM Teachings
                    WHERE ClassId = @classId AND InstructorId = @instructorId AND CourseId = c.CourseId
                )
                AND c.CourseId = @courseId;
            ";
            try
            {
                SqlConnection connection = SqlDataAccess.ConnectionInstance;

                SqlDataAccess.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@classId", classId);
                    cmd.Parameters.AddWithValue("@courseId", courseId);
                    cmd.Parameters.AddWithValue("@instructorId", instructorId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                SqlDataAccess.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }
            return dt;
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateStudentGradingList();

        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateStudentGradingList();
        }

        private void PopulateStudentGradingList()
        {
            if (cbClasses.SelectedIndex != -1 && cbCourses.SelectedIndex != -1)
            {
                dgvStudentGradings.Columns.Clear();

                dgvStudentGradings.DataSource = GetStudentGrades(
                    cbClasses.SelectedValue.ToString(),
                    cbCourses.SelectedValue.ToString(),
                    SessionManager.AuthenticatedInstructor.InstructorId);

                dgvStudentGradings.Columns["StudentID"].ReadOnly = true;
                dgvStudentGradings.Columns["StudentName"].ReadOnly = true;

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "action";
                btnColumn.HeaderText = "Action";
                btnColumn.Text = "Save";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvStudentGradings.Columns.Add(btnColumn);
            }
        }

        private void dgvStudentGradings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStudentGradings.Columns["action"].Index && e.RowIndex >= 0)
            {
                // Save the individual row
                SaveIndividualRow(e.RowIndex);
            }
        }
        private void SaveIndividualRow(int rowIndex)
        {
            try
            {
                string studentId = dgvStudentGradings.Rows[rowIndex].Cells["StudentId"].Value.ToString();
                string courseId = cbCourses.SelectedValue.ToString();
                string grade = dgvStudentGradings.Rows[rowIndex].Cells["Score"].Value.ToString();

                UpdateGrade(studentId, courseId, grade);

                MessageBox.Show("Grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateGrade(string studentId, string courseId, string grade)
        {
            string query = @"
                UPDATE Grades
                SET Score = @Score
                WHERE StudentId = @StudentId AND CourseId = @CourseId;
    ";

            SqlConnection connection = SqlDataAccess.ConnectionInstance;


            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@Score", grade);
            command.Parameters.AddWithValue("@StudentId", studentId);
            command.Parameters.AddWithValue("@CourseId", courseId);

            SqlDataAccess.OpenConnection();
            
            command.ExecuteNonQuery();

            SqlDataAccess.CloseConnection();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvStudentGradings.Rows)
                {
                    // Check if the cell value is not null before accessing its Value property
                    if (row.Cells["Score"].Value != null)
                    {
                        string studentId = row.Cells["StudentId"].Value.ToString();
                        string courseId = cbCourses.SelectedValue.ToString();
                        string grade = row.Cells["Score"].Value.ToString();

                        UpdateGrade(studentId, courseId, grade);
                    }
                }

                MessageBox.Show("All changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
