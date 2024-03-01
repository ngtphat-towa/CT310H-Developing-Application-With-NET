using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Course
    {
        [Key]
        public required string CourseId { get; set; }
        public required string CourseName { get; set; }
        public required string DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int CreditNumber { get; set; }
        public ICollection<Section>? Sections { get; set; }
    }
}
