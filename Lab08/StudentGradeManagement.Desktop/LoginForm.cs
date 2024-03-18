using StudentGradeManagement.Desktop.DataAccess;
using StudentGradeManagement.Desktop.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentGradeManagement.Desktop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // TODO: for manual testing purpose
            txtInstructorId.Text = "001";
            txtPassword.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtInstructorId.Text;
            string password = txtPassword.Text;

            SqlConnection connection = SqlDataAccess.ConnectionInstance;

            try
            {
                SqlDataAccess.OpenConnection();

                string query = "SELECT InstructorId, InstructorName FROM Instructors WHERE InstructorId = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Setting authenticated instructor information
                        AuthenticatedInstructor instructor = new AuthenticatedInstructor()
                        {
                            InstructorId = reader["InstructorId"].ToString(),
                            InstructorName = reader["InstructorName"].ToString()
                        };
                        SessionManager.AuthenticatedInstructor = instructor;

                    }
                    reader.Close();

                    // Login successful, open main form
                    this.Hide(); 
                    GradingForm mainForm = new GradingForm(); 
                    mainForm.Show(); 
                }
                else
                {
                    lblMessage.Text = "Invalid username or password."; 
                }

                reader.Close();
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtInstructorId.Text = "";
            txtPassword.Text = "";
        }

    }
}
