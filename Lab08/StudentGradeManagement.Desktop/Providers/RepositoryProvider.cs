using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories;
using StudentGradeManagement.Library.Repositories.Contracts;

namespace StudentGradeManagement.Desktop.Providers
{
    public sealed class RepositoryProvider
    {
        private static IBaseRepository<Department>? _departmentRepository;
        public static IBaseRepository<Department> GetDepartmentRepository()
        {
            if (_departmentRepository != null)
            {
                return _departmentRepository;
            }
            _departmentRepository = new DepartmentRepository();
            return _departmentRepository;
        }

        private static IBaseRepository<Class>? _classRepository;
        public static IBaseRepository<Class> GetClassRepository()
        {
            if (_classRepository != null)
            {
                return _classRepository;
            }
            _classRepository = new ClassRepository();
            return _classRepository;
        }

        private static IBaseRepository<Course>? _coursesRepository;
        public static IBaseRepository<Course> GetCourseRepository()
        {
            if (_coursesRepository != null)
            {
                return _coursesRepository;
            }
            _coursesRepository = new CourseRepository();
            return _coursesRepository;
        }
    }
}
