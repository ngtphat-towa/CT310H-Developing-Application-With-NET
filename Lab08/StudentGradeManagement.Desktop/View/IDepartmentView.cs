namespace StudentGradeManagement.Library.View
{
    public interface IDepartmentView : IBaseView ,IDataModelEventHandler
    {
        //Properties - Fields
        string DepartmentId { get; set; } 
        string DepartmentName { get; set; }
        string? Building { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string? Message { get; set; }

        //Methods
        void PopulateBuildingBindingSource(BindingSource buildings);
        void SetDepartmentListBindingSource(BindingSource departments);
    }
}
