using StudentGradeManagement.Library.DataAccess;
using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;

namespace StudentGradeManagement.Library.Repositories
{
    public class DepartmentRepository : IBaseRepository<Department>
    {

        public Task<dynamic> CreateAsync(Department entity)
                => DataAccessHelper.ExecuteStoredProcedure("spDepartment_Create", new
                {
                    entity.DepartmentId,
                    entity.DepartmentName,
                    entity.Building
                });

        public Task DeleteAsync(dynamic id)
         => DataAccessHelper.ExecuteStoredProcedure("spDepartment_Delete", new { DepartmentId = id });

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            var result = await DataAccessHelper.QueryStoredProcedureData<Department, dynamic>("spDepartment_GetAll", new { });

            return result;
        }

        public async Task<Department?> GetSingleAsync(dynamic id)
        {
            string DepartmentId = id;
            var result = await DataAccessHelper.QueryStoredProcedureData<Department, dynamic>("spDepartment_GetSingle", new { DepartmentId });

            return result.FirstOrDefault();
        }

        public Task UpdateAsync(Department entity)
        => DataAccessHelper.
            ExecuteStoredProcedure<dynamic>(
            "spDepartment_Update",
            new
            {
                entity.DepartmentId,
                entity.DepartmentName,
                entity.Building
            });
    }
}