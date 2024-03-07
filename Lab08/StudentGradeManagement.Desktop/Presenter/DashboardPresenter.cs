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
        }

        private void _view_LogoutEvent(object? sender, EventArgs e)
        {
            _view.LoginView.ShowView();
            _view.CloseView();
        }

        public void ShowView()
        {
            _view.ShowView();
        }
        
    }
}
