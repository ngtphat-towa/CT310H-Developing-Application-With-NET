using System.Windows.Forms;

using StudentGradeManagement.Desktop.Presenter;
using StudentGradeManagement.Desktop.Providers;
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

            
            var loginView = ViewProvider.GetLoginView();
           
            var intructorRepository = new InstructorRepository();
            _ = new LoginPresenter(loginView, intructorRepository);
            Application.Run((Form)loginView);
        }
    }
}