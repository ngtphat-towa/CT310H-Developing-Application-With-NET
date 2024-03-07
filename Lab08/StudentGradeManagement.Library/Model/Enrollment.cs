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
