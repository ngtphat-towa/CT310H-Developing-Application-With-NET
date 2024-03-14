using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Class
    {
        [Key]
        public string ClassId { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public  string DepartmentId { get; set; } = null!;
        public string? YearCode { get; set; } = null!;
        public  Department? Department { get; set; }
        [Browsable(false)]
        public ICollection<Section>? Sections { get; set; }

    }

}
