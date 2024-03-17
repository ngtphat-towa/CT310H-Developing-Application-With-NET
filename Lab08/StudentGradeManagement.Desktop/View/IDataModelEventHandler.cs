namespace StudentGradeManagement.Library.View
{
    public interface IDataModelEventHandler
    {
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string? Message { get; set; }

        event EventHandler? SearchEvent;
        event EventHandler? AddNewEvent;
        event EventHandler? EditEvent;
        event EventHandler? DeleteEvent;
        event EventHandler? SaveEvent;
        event EventHandler? CancelEvent;
    }
}
