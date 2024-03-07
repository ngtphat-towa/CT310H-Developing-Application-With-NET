namespace StudentGradeManagement.Library.View
{
    public interface ILoginView : IBaseView
    {
        // Feilds
        string InstructorId { get; set; }
        string Password { get; set; }
        // Event handler
        event EventHandler? LoginClicked;
        event EventHandler? ClearClicked;
        // Functions
        void ClearFields();
        void ShowMessage(string message);
        void HideView();
        void OpenView();
        // Views
        IDashboardView? DashboardView { get; }
    }

}
