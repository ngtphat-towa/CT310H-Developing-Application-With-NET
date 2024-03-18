using StudentGradeManagement.Desktop.Model;

namespace StudentGradeManagement.Desktop
{
    public static class SessionManager
    {
        private static AuthenticatedInstructor _authenticatedInstructor;

        public static AuthenticatedInstructor AuthenticatedInstructor { get => _authenticatedInstructor; set => _authenticatedInstructor = value; }
    }
}
