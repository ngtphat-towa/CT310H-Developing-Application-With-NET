namespace StudentGradeManagement.Library.View
{
    public interface IDepartmentView : IBaseView ,IDataModelEventHandler
    {
        //Properties - Fields
        string DepartmentId { get; set; } 
        string DepartmentName { get; set; }
        string? Building { get; set; }

        //Methods
        void PopulateBuildingBindingSource(BindingSource buildings);
        void SetDepartmentListBindingSource(BindingSource departments);
    }
}
