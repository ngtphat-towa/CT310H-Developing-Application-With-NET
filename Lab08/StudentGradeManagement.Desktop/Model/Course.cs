using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Course
    {
        [Key]
        [DisplayName("Course Id")]
        public required string CourseId { get; set; }
        [DisplayName("Course Name")]
        [Required(ErrorMessage = "Course name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public required string CourseName { get; set; }
        [Browsable(false)]
        public required string DepartmentId { get; set; }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 characters")]
        public Department? Department { get; set; }
        public int CreditNumber { get; set; }
        [Browsable(false)]
        [DisplayName("Sections")]
        public ICollection<Section>? Sections { get; set; }
    }
}
