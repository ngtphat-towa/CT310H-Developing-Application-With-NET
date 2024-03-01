using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;
using StudentGradeManagement.Library.View;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagement.Desktop.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IBaseRepository<Instructor> _intructorRepository;

        public LoginPresenter(ILoginView view, IBaseRepository<Instructor> instructorRepository)
        {
            _intructorRepository = instructorRepository 
                ?? throw new ArgumentNullException(nameof(instructorRepository));
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LoginClicked += OnLoginClicked!;
            _view.ClearClicked += OnClearClicked!;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Get values
            string instructorId = _view.InstructorId;
            string password = _view.Password;

            // Check if the user or password 
            if (string.IsNullOrEmpty(instructorId) || string.IsNullOrEmpty(password))
            {
                _view.ShowMessage("Please enter both Instructor ID and Password.");
                return;
            }

            // Check if the intructor id exit or not
            var exsitingInstructor= await  _intructorRepository.GetSingleAsync(instructorId);
            if (exsitingInstructor == null)
            {
                _view.ShowMessage("The intructor id doesn't exist!");
                return;
            }
            // Check password
            if (!exsitingInstructor.Password.Equals(password)){
                _view.ShowMessage("The password is invalid!");
                return;
            }
            // TODO: show message login succesful and open main view
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            _view.ClearFields();
        }
        public void ShowView()
        {
            _view.OpenView();
        }
    }
}
