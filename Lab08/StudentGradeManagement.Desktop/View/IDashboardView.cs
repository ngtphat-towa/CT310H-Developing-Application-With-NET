using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.View
{
    public interface IDashboardView : IBaseView
    {
        event EventHandler? ShowDepartmentView;
        event EventHandler? ShowCourseView;
        event EventHandler? LogoutEvent;
    }
}
