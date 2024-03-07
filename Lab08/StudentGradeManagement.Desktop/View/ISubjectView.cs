using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
