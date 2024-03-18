
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentGradeManagement.Desktop.DataAccess
{
    public class SqlDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["Lab_StudentGradeManagement"].ConnectionString;


        public static SqlConnection ConnectionInstance = new SqlConnection(connectionString);
        
        public static bool OpenConnection()
        {
            try
            {
                if (ConnectionInstance.State != System.Data.ConnectionState.Open)
                {
                    ConnectionInstance.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        public static bool CloseConnection()
        {
            try
            {
                if (ConnectionInstance.State != System.Data.ConnectionState.Closed)
                {
                    ConnectionInstance.Close();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
