using StudentGradeManagement.Library.DataAccess;
using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;

namespace StudentGradeManagement.Library.Repositories
{
    public class ClassRepository : IBaseRepository<Class>
    {

        public Task<dynamic> CreateAsync(Class entity)
                => DataAccessHelper.ExecuteStoredProcedure("spClass_Create", new
                {
                    entity.ClassId,
                    entity.ClassName,
                    entity.DepartmentId,
                    entity.YearCode
                });

        public Task DeleteAsync(dynamic id)
         => DataAccessHelper.ExecuteStoredProcedure("spClass_Delete", new { ClassId = id });

        public async Task<IEnumerable<Class>> GetAllAsync()
        {
            var result = await DataAccessHelper.QueryStoredProcedureData<Class, dynamic>("spClass_GetAll", new { });

            return result;
        }

        public async Task<Class?> GetSingleAsync(dynamic id)
        {
            string ClassId = id;
            var result = await DataAccessHelper.QueryStoredProcedureData<Class, dynamic>("spClass_GetSingle", new { ClassId });

            return result.FirstOrDefault();
        }

        public Task UpdateAsync(Class entity)
        => DataAccessHelper.
           ExecuteStoredProcedure(
            "spClass_Update",
            new
            {
                entity.ClassId,
                entity.ClassName,
                entity.DepartmentId,
                entity.YearCode
            });
    }
}