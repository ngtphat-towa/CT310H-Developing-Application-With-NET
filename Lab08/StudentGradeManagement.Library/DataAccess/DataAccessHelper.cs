using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace StudentGradeManagement.Library.DataAccess
{
    public static class DataAccessHelper
    {
        private static string ConnectionString = "Data Source=NTPHAT;Initial Catalog=Lab_StudentGradeManagement;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static async Task<IEnumerable<T>> QueryStoredProcedureData<T, U>(
               string storeProcedure,
               U parameters)
        {

            using IDbConnection connection = new SqlConnection(ConnectionString);
            return await connection.QueryAsync<T>(
                storeProcedure,
                parameters);
        }

        public static async Task<dynamic> ExecuteStoredProcedure<U>(
            string storeProcedure,
            U parameters)
        {

            using IDbConnection connection = new SqlConnection(ConnectionString);
            return  await connection.ExecuteAsync(
                storeProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);
        }

    }
}
