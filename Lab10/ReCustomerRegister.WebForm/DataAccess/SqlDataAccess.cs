using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ReCustomerRegister.WebForm.DataAccess
{
    public static class SqlDataAccess
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["Lab_CustomerManagement"].ConnectionString;

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

        public static bool InsertCustomer(string username, string hashPassword, string fullName, string dateOfBirth, string gender, string email, decimal income)
        {
            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand("dbo.InsertCustomer", ConnectionInstance))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@HashPassword", hashPassword);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DataOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Income", income);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                // Handle exception here, such as logging or throwing it further
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}