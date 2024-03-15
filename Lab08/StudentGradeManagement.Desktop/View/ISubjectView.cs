using System.ComponentModel;

namespace StudentGradeManagement.Library.View
{
    public interface ISubjectView : IBaseView, IDataModelEventHandler
    {
        string CourseId { get; set; }
        string CourseName { get; set; }
        [Browsable(false)]
        string DepartmentId { get; set; }
        public int CreditNumber { get; set; }

        void SetCourseListBindingSource(BindingSource courseList);
        void PopulateCourseListBindingSource(BindingSource departmentList);
        void Show();

    }
}
