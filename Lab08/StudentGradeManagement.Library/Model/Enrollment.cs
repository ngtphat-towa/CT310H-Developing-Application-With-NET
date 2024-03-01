using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Library.Model
{
    public class Enrollment
    {
        public string StudentId { get; set; } = null!;
        public int SectionId { get; set; }
        public decimal? Grade { get; set; }
        public Student? Student { get; set; }
        public Section? Section { get; set; }
    }
}
