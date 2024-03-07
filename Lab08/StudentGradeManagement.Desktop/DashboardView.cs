using StudentGradeManagement.Library.Repositories;
using StudentGradeManagement.Library.View;


namespace StudentGradeManagement.Desktop
{
    public partial class DashboardForm : Form, IDashboardView
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        public void CloseView()
        {
            Application.Exit();
        }

        public void ShowView()
        {
            this.Show();
        }



        public event EventHandler? LogoutEvent;
        private static IDashboardView? _dashboardView;

        public static IDashboardView? GetDashboardView()
        {
            if (_dashboardView == null || ((Form)_dashboardView).IsDisposed)
            {
                _dashboardView = new DashboardForm();
            }
            return _dashboardView;
        }

        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mangeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageIntructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogoutEvent?.Invoke(this, EventArgs.Empty);
        }

        private ILoginView? _loginView;
        public ILoginView LoginView => _loginView ?? throw new ArgumentNullException(nameof(LoginView));

        public void setLoginView(ILoginView loginView)
        {
            _loginView = loginView;
        }

    
    }
}
