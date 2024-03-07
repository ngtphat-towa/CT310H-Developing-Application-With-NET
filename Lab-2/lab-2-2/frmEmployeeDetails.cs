namespace lab_2_2
{
    public partial class frmEmployeeDetails : Form
    {
        private frmAdminLogin loginForm;

        public frmEmployeeDetails(frmAdminLogin loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtAddress.Text = "";
            dateTimePicker1.Value = DateTime.Now;  // Reset to current date
            cboEducation.SelectedIndex = -1;  // Assuming no default selection
            cboDepartment.SelectedIndex = -1;
            txtFullName.Focus();  // Set focus to the first field
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string confirmationMessage = "Are you sure you want to save the following information?\n" +
                                         "Full Name: " + txtFullName.Text + "\n" +
                                         "Employee Address: " + txtAddress.Text + "\n" +
                                         "Date of Employment: " + dateTimePicker1.Value.ToString() + "\n" +
                                         "Education: " + cboEducation.SelectedItem + "\n" +
                                         "Department: " + cboDepartment.SelectedItem;

            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the entire application?",
                                                  "Exit Options",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exit employee form and show login form
                this.Hide();  // Hide employee form
                this.loginForm.Show();  // Show login form
            }
            else if (result == DialogResult.No)
            {
                // Exit both forms (close application)
                Application.Exit();
            }

        }

    }
}