using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Grade
    {
        [Key]
        public string StudentId { get; set; } = null!;
        public int SectionId { get; set; }
        public int EvaluationMethodId { get; set; }
        public decimal? Score { get; set; }
        public Student? Student { get; set; }
        public Section? Section { get; set; }
        public EvaluationMethod? EvaluationMethod { get; set; }
    }
}
