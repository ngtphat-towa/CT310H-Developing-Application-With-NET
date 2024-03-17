using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Presenter
{
    public class CoursePresenter
    {
        // View - Services
        private readonly ICourseView _view;
        private readonly IBaseRepository<Course> _courseRepository;
        private readonly IBaseRepository<Department> _departmentRepository;

        // State values
        private readonly BindingSource _bindingSource;
        private IEnumerable<Course>? _coursees;
        private IEnumerable<Department>? _departments;

        public  CoursePresenter(ICourseView view,
                                   IBaseRepository<Course> courseRepository,
                                   IBaseRepository<Department> departmentRepository)
        {
            // DI
            _departmentRepository = departmentRepository;
            _courseRepository = courseRepository;
            _view = view;
            // Wire up event
            _view.AddNewEvent += _view_AddNewEvent;
            _view.EditEvent += _view_EditEvent;
            _view.DeleteEvent += _view_DeleteEventAsync;
            _view.SearchEvent += _view_SearchEventAsync;
            _view.SaveEvent += _view_SaveEvent;
            _view.CancelEvent += _view_CancelEvent;
            // Data
            _bindingSource = [];
            _view.SetCourseListBindingSource(_bindingSource);

            _ = initView();
        }

        private async Task initView()
        {
            await LoadDepartmentList();

            await LoadcourseList();

        }

        private async Task LoadcourseList()
        {
            // Populate the Course data grid view
            _coursees = await _courseRepository.GetAllAsync();
            _bindingSource.DataSource = _coursees;
        }

        private async Task LoadDepartmentList()
        {
            // Create a temporary list of buildings
            _departments = await _departmentRepository.GetAllAsync();

            // Populate the building view
            _view.PopulateDepartmentListBindingSource(new BindingSource(_departments, null));
        }

        private async void _view_SaveEvent(object? sender, EventArgs e)
        {
            var model = new Course()
            {
                CourseId = _view.CourseId,
                CourseName = _view.CourseName,
                DepartmentId = _view.DepartmentId,
                CreditNumber = _view.CreditNumber
            };

            // Check if it is a editing mode
            if (_view.IsEdit)
            {
                // Update the Course
                // TODO: validate model
                await _courseRepository.UpdateAsync(model);
                _view.Message = "Course update succesfully";
                _view.IsEdit = false;
            }
            else
            {
                // Add new Course
                _view.Message = "Course add succesfully";
                await _courseRepository.CreateAsync(model);

            }
            await LoadcourseList();
            _view.ShowMessage(_view.Message);
            _view_CancelEvent(sender, e);
        }


        private void _view_CancelEvent(object? sender, EventArgs e)
        {
            _view.CourseId = "";
            _view.CourseName = "";
            _view.DepartmentId = "";
            _view.CreditNumber = 1;
            _view.IsEdit = false;
        }

        private async void _view_SearchEventAsync(object? sender, EventArgs e)
        {
            var searchValue = _view.SearchValue?.Trim();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                _coursees = (await _courseRepository.GetAllAsync())
                        .Where(d => d.CourseName.Contains(searchValue));
                _bindingSource.DataSource = _coursees;
            }
            else
            {
                await LoadcourseList();
            }
        }

        private async void _view_DeleteEventAsync(object? sender, EventArgs e)
        {
            var current = _bindingSource.Current as Course;
            if (current != null)
            {
                try
                {
                    await _courseRepository.DeleteAsync(current.CourseId);
                    _view.Message = "Course deleted successfully";
                    await LoadcourseList();
                }
                catch (Exception ex)
                {
                    _view.Message = $"Error: {ex.Message}";
                }
            }
            else
            {
                _view.Message = "No Course selected for deletion";
            }

            _view.ShowMessage(_view.Message);
        }

        private void _view_EditEvent(object? sender, EventArgs e)
        {
            var model = (Course)_bindingSource.Current;
            _view.CourseId = model.CourseId;
            _view.CourseName = model.CourseName;
            _view.DepartmentId = model.DepartmentId;
            _view.CreditNumber = model.CreditNumber;
            _view.IsEdit = true;
        }

        private void _view_AddNewEvent(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
            _view_CancelEvent(sender, e);
        }
    }
}