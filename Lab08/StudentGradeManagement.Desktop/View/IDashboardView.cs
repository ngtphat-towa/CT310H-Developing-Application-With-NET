namespace StudentGradeManagement.Library.View
{
    public interface IDashboardView : IBaseView
    {
        event EventHandler? ShowDepartmentView;
        event EventHandler? ShowClassView;
        event EventHandler? ShowCourseView;
        event EventHandler? LogoutEvent;
    }
}
