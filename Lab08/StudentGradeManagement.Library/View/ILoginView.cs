namespace StudentGradeManagement.Library.View
{
    public interface ILoginView : IBaseView
    {
        string InstructorId { get; set; }
        string Password { get; set; }
        event EventHandler? LoginClicked;
        event EventHandler? ClearClicked;
        void ClearFields();
        void ShowMessage(string message);
    }

}
