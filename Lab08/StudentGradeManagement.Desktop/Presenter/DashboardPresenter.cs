using StudentGradeManagement.Desktop.Presenter;
using StudentGradeManagement.Desktop.Providers;
using StudentGradeManagement.Desktop.Repositories;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Library.Presenter
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;

        public DashboardPresenter(IDashboardView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LogoutEvent += _view_LogoutEvent;
            _view.ShowDepartmentView += _view_ShowDepartmentView;
            _view.ShowClassView += _view_ShowClassView;

        }

        private void _view_ShowClassView(object? sender, EventArgs e)
        {
            var view = ViewProvider.GetClassView((Form?)_view);
            var classRepository = RepositoryProvider.GetClassRepository();
            var departmentRepository = RepositoryProvider.GetDepartmentRepository();

            _ = new ClassPresenter(view, classRepository, departmentRepository);
            view!.Show();
        }

        private void _view_ShowDepartmentView(object? sender, EventArgs e)
        {
            var view = ViewProvider.GetDepartmentView((Form?)_view);
            var departmentRepository = RepositoryProvider.GetDepartmentRepository();
            _ = new DepartmentPresenter(view, departmentRepository);
            view!.Show();
        }

        private void _view_LogoutEvent(object? sender, EventArgs e)
        {
            ViewProvider.GetLoginView().Show();
            ((Form)_view).Close();
        }

        public void ShowView()
        {
            _view.ShowView();
        }
        
    }
}
