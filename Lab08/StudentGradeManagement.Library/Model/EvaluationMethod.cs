using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class EvaluationMethod
    {
        [Key]
        public int EvaluationMethodId { get; set; }
        public string EvaluationMethodName { get; set; } = null!;
        public decimal Weight { get; set; }
        public ICollection<Grade>? Grades { get; set; }
    }
}
