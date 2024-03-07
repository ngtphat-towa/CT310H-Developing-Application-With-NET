using StudentGradeManagement.Library.DataAccess;
using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;

namespace StudentGradeManagement.Library.Repositories
{
    public class InstructorRepository : IBaseRepository<Instructor>
    {

    public Task<dynamic> CreateAsync(Instructor entity)
            => DataAccessHelper.ExecuteStoredProcedure("spIntructor_Insert", entity);

        public Task DeleteAsync(dynamic id)
         => DataAccessHelper.ExecuteStoredProcedure("spIntructor_Delete", new { InstructorId = id });

        public async Task<IEnumerable<Instructor>> GetAllAsync()
        {
            var result = await DataAccessHelper.QueryStoredProcedureData<Instructor, dynamic>("spIntructor_GetAll", new { });

            return result;
        }

        public async Task<Instructor?> GetSingleAsync(dynamic id)
        {
            string instructorId = id;
            var result = await DataAccessHelper.QueryStoredProcedureData<Instructor, dynamic>("spIntructor_GetSingle", new { instructorId });

            return result.FirstOrDefault();
        }

        public Task UpdateAsync(Instructor entity)
        => DataAccessHelper.ExecuteStoredProcedure<Instructor>("spIntructor_Update", entity);
    }
}
