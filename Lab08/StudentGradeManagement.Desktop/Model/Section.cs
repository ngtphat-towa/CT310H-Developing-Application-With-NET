using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        public string CourseId { get; set; } = null!;
        public int AcademicYearTermId { get; set; }
        public string ClassNumber { get; set; } = null!;
        public Course? Course { get; set; }
        public AcademicYear? AcademicYear { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<Teaches>? Teaches { get; set; }
    }

}
