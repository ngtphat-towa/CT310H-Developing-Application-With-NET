using System;
using System.Data.SqlClient;

namespace Part01.DVDLibraryMnt.Desktop.Database
{
    internal class DVDDatabase
    {
        private static readonly string _connectionString = "Data Source=NTPHAT;Initial Catalog=Lab_DVDLibrary;User ID=mylogin;Password=mylogin;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection ConnectionInstance = new SqlConnection(_connectionString);
        public static bool OpenConnection()
        {
            try
            {
                ConnectionInstance.Open();
            }catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        public static bool CloseConnection()
        {
            try
            {
                ConnectionInstance.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
