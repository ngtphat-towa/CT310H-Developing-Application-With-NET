using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Class
    {
        [Key]
        public required string ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        public  string DepartmentId { get; set; } = null!;
        public string? YearCode { get; set; }
        public  Department? Department { get; set; }
        public ICollection<Section>? Sections { get; set; }

    }

}
