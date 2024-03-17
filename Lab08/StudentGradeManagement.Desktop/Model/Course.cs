using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Course
    {
        [Key]
        [DisplayName("Course Id")]
        public string CourseId { get; set; } = null!;

        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string CourseName { get; set; } = null!;

        [DisplayName("Department Id")]
        [Required(ErrorMessage = "Department name is requerid")]
        public string DepartmentId { get; set; } = null!;

        [Browsable(false)]
        public Department? Department { get; set; }

        [DisplayName("Credit Number")]
        public int CreditNumber { get; set; }

        [Browsable(false)]
        [DisplayName("Sections")]
        public ICollection<Section>? Sections { get; set; }
    }
}
