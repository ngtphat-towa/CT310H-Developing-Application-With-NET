using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class AcademicYear
    {
        [Key]
        public int AcademicYearTermId { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }

}
