using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Library.View
{
    public interface IClassView : IBaseView, IDataModelEventHandler
    {
        //Properties - Fields
        string ClassId { get; set; } 
        string ClassName { get; set; } 
        string DepartmentId { get; set; } 
        string YearCode { get; set; } 

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string? Message { get; set; }

        //Methods
        void PopulateDepartmentBindingSource(BindingSource buildings);
        void SetClassListBindingSource(BindingSource Classs);
    }
  
}
