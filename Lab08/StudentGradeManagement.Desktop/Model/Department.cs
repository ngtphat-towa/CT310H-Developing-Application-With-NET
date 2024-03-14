using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Department
    {
        [Key]
        [DisplayName("Department ID")]
        public string DepartmentId { get; set; } = null!;

        [DisplayName("Department Name")]
        public string DepartmentName { get; set; } = null!;

        public string? Building { get; set; }

        // Hide the Classes collection from the DataGridView
        [Browsable(false)]
        public ICollection<Class>? Classes { get; set; }

        // Hide the Courses collection from the DataGridView
        [Browsable(false)]
        public ICollection<Course>? Courses { get; set; }

        // Hide the Instructors collection from the DataGridView
        [Browsable(false)]
        public ICollection<Instructor>? Instructors { get; set; }
    }
}
