using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Instructor
    {
        [Key]
        public string InstructorId { get; set; } = null!;
        public string InstructorName { get; set; } = null!;
        public string DepartmentId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Department? Department { get; set; }
        public List<Teaches>? Teaches { get; set; }
    }
}