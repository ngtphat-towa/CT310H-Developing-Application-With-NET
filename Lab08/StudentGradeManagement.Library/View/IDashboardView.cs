using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.View
{
    public interface IDashboardView : IBaseView
    {
        event EventHandler? LogoutEvent;
        ILoginView LoginView { get; }
        void setLoginView(ILoginView loginView);
    }
}
