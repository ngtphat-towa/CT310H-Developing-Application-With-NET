using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; } = null!;
        public string StudentName { get; set; } = null!;
        public string ClassId { get; set; } = null!;
        public int TotalCredits { get; set; }
        public Class? Class { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
