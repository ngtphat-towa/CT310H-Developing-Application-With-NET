
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop
{
    public partial class LoginForm : Form, ILoginView
    {
        public string InstructorId { get => txtInstructorId.Text; set => txtInstructorId.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public event EventHandler? LoginClicked;
        public event EventHandler? ClearClicked;

        public void ClearFields()
        {
            txtInstructorId.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearClicked?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowView()
        {
            this.Show();
        }

        public void CloseView()
        {
            this.Close();
        }

        public void HideView()
        {
            this.Hide();
        }

        public void OpenView()
        {
            Application.Run(this);
        }
    }
}
