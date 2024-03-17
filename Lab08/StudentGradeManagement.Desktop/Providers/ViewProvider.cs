using StudentGradeManagement.Desktop.Subject;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Providers
{
    public sealed class ViewProvider
    {
        private static readonly Dictionary<Type, Form> _singletonForms = new Dictionary<Type, Form>();

        private static T CreateSingletonView<T>(Form? parentForm = null) where T : Form, new()
        {
            Type formType = typeof(T);

            if (!_singletonForms.ContainsKey(formType) || _singletonForms[formType].IsDisposed)
            {
                var view = new T();

                // Set view to fill the parent form
                if (parentForm != null)
                {
                    view.MdiParent = parentForm;
                    view.Dock = DockStyle.Fill;
                    // Hide minimize and maximize buttons, show only close button
                    view.ControlBox = false;
                    view.ShowInTaskbar = false;
                    view.FormBorderStyle = FormBorderStyle.None;
                }

                _singletonForms[formType] = view;
            }

            return (T)_singletonForms[formType];
        }

        private static T CreateNewView<T>(Form? parentForm = null) where T : Form, new()
        {
            var view = new T();

            // Set view to fill the parent form
            if (parentForm != null)
            {
                view.MdiParent = parentForm;
                view.Dock = DockStyle.Fill;
            }

            // Hide minimize and maximize buttons, show only close button
            view.ControlBox = false;
            view.ShowInTaskbar = false;
            view.FormBorderStyle = FormBorderStyle.None;

            return view;
        }

        // Method for creating singleton views
        public static LoginForm GetLoginView()
        {
            return CreateSingletonView<LoginForm>();
        }

        // Method for creating singleton views
        public static IDashboardView GetDashboardView()
        {
            return CreateSingletonView<DashboardForm>();
        }

        // Method for creating new views each time
        public static DepartmentForm GetDepartmentView(Form? parentForm = null)
        {
            return CreateNewView<DepartmentForm>(parentForm);
        }

        // Method for creating new views each time
        public static ClassForm GetClassView(Form? parentForm = null)
        {
            return CreateNewView<ClassForm>(parentForm);
        }

        public static CourseForm GetCourseView(Form? parentForm = null)
        {
            return CreateNewView<CourseForm>(parentForm);
        }
    }
}
