using StudentGradeManagement.Library.DataAccess;
using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;

namespace StudentGradeManagement.Library.Repositories
{
    public class CourseRepository : IBaseRepository<Course>
    {

        public Task<dynamic> CreateAsync(Course entity)
                => DataAccessHelper.ExecuteStoredProcedure("spCourse_Create", new
                {
                    entity.CourseId,
                    entity.CourseName,
                    entity.DepartmentId,
                    entity.CreditNumber
                });

        public Task DeleteAsync(dynamic id)
         => DataAccessHelper.ExecuteStoredProcedure("spCourse_Delete", new { CourseId = id });

        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            var result = await DataAccessHelper.QueryStoredProcedureData<Course, dynamic>("spCourse_GetAll", new { });

            return result;
        }

        public async Task<Course?> GetSingleAsync(dynamic id)
        {
            string CourseId = id;
            var result = await DataAccessHelper.QueryStoredProcedureData<Course, dynamic>("spCourse_GetSingle", new { CourseId });

            return result.FirstOrDefault();
        }

        public Task UpdateAsync(Course entity)
        => DataAccessHelper.
           ExecuteStoredProcedure(
            "spCourse_Update",
            new
            {
                entity.CourseId,
                entity.CourseName,
                entity.DepartmentId,
                entity.CreditNumber
            });
    }
}