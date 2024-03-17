using System.ComponentModel;

namespace StudentGradeManagement.Library.View
{
    public interface ICourseView : IBaseView, IDataModelEventHandler
    {
        string CourseId { get; set; }
        string CourseName { get; set; }
        string DepartmentId { get; set; }
        public int CreditNumber { get; set; }
        
        void SetCourseListBindingSource(BindingSource courseList);
        void PopulateDepartmentListBindingSource(BindingSource departmentList);
        void Show();

    }
}
