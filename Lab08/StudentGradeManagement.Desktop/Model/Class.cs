using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Library.Model
{
    public class Class
    {
        [Key]
        [DisplayName("Class ID")]
        public string ClassId { get; set; } = null!;

        [DisplayName("Class Name")]
        public string ClassName { get; set; } = null!;

        [DisplayName("Department ID")]
        public string DepartmentId { get; set; } = null!;

        [DisplayName("Department Name")]
        public string? DepartmentName { get; set; } = null!;

        [DisplayName("Year Code")]
        public string YearCode { get; set; } = null!;

        [Browsable(false)]
        public Department? Department { get; set; }

        // Hide the Sections collection from the DataGridView
        [Browsable(false)]
        public ICollection<Section>? Sections { get; set; }
    }
}
