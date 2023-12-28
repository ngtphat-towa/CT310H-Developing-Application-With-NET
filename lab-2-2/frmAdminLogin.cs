namespace lab_2_2
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
            {
                // Login successful, display Employee Details form
                frmEmployeeDetails employeeForm = new frmEmployeeDetails(this);
                employeeForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Login failed, display error message
                lblErrorMessage.Text = "Invalid username or password.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblErrorMessage.Text = "";  // Clear any error messages
            txtUsername.Focus();  // Set focus to the username 
        }
    }
}