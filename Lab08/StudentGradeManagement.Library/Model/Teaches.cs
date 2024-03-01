using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Teaches
    {
        [Key]
        public string InstructorId { get; set; } = null!;
        public int SectionId { get; set; }
        public bool IsPrimary { get; set; }
        public Instructor? Instructor { get; set; }
        public Section? Section { get; set; }
    }
}
