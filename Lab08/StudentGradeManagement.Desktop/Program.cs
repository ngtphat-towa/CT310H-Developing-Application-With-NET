using StudentGradeManagement.Desktop.Presenter;
using StudentGradeManagement.Library.Repositories;

namespace StudentGradeManagement.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            
            var loginView = new LoginForm();
           
            var intructorRepository = new InstructorRepository();
            var loginPresenter = new LoginPresenter(loginView, intructorRepository);
            loginPresenter.ShowView();
        }
    }
}