using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Providers
{
    public sealed class ViewProvider
    {
        private static LoginForm? _loginView;
        public static LoginForm GetLoginView()
        {
            if (_loginView == null || ((Form)_loginView).IsDisposed)
            {
                _loginView  =new LoginForm();
            }
            return _loginView;
        }

        private static IDashboardView? _dashboardView;
        public static IDashboardView GetDashboardView()
        {
            if (_dashboardView == null || ((Form)_dashboardView).IsDisposed)
            {
                _dashboardView = new DashboardForm();
            }
            return _dashboardView;
        }

        public static DepartmentForm GetDepartmentView(Form? parentForm = null)
        {
            var departmentView = new DepartmentForm();

            // Set departmentView to fill the parent form
            if (parentForm != null)
            {
                departmentView.MdiParent = parentForm;
                departmentView.Dock = DockStyle.Fill;
            }

            // Hide minimize and maximize buttons, show only close button
            departmentView.ControlBox = false;
            departmentView.ShowInTaskbar = false;
            departmentView.FormBorderStyle = FormBorderStyle.None;

            return departmentView;
        }
        public static ClassForm GetClassView(Form? parentForm = null)
        {
            var classView = new ClassForm();

            // Set departmentView to fill the parent form
            if (parentForm != null)
            {
                classView.MdiParent = parentForm;
                classView.Dock = DockStyle.Fill;
            }

            // Hide minimize and maximize buttons, show only close button
            classView.ControlBox = false;
            classView.ShowInTaskbar = false;
            classView.FormBorderStyle = FormBorderStyle.None;

            return classView;
        }
    }
}
