using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories.Contracts;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Presenter
{
    public class ClassPresenter
    {
        // View - Services
        private readonly IClassView _view;
        private readonly IBaseRepository<Class> _classRepository;
        private readonly IBaseRepository<Department> _departmentRepository;

        // State values
        private readonly BindingSource _bindingSource;
        private IEnumerable<Class>? _classes;
        private IEnumerable<Department>? _departments;

        public ClassPresenter(IClassView view,
                                   IBaseRepository<Class> classRepository,
                                   IBaseRepository<Department> departmentRepository)
        {
            // DI
            _departmentRepository = departmentRepository;
            _classRepository = classRepository;
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
            _view.SetClassListBindingSource(_bindingSource);

            _ = initView();
        }

        private async Task initView()
        {
            await LoadDepartmentList();

            await LoadClassList();

        }

        private async Task LoadClassList()
        {
            // Populate the Class data grid view
            _classes = await _classRepository.GetAllAsync();
            _bindingSource.DataSource = _classes;
        }

        private async Task LoadDepartmentList()
        {
            // Create a temporary list of buildings
            _departments = await _departmentRepository.GetAllAsync();

            // Populate the building view
            _view.PopulateDepartmentBindingSource(new BindingSource(_departments, null));
        }

        private async void _view_SaveEvent(object? sender, EventArgs e)
        {
            var model = new Class()
            {
                ClassId = _view.ClassId,
                ClassName = _view.ClassName,
                DepartmentId = _view.DepartmentId,
                YearCode = _view.YearCode
            };

            // Check if it is a editing mode
            if (_view.IsEdit)
            {
                // Update the Class
                // TODO: validate model
                await _classRepository.UpdateAsync(model);
                _view.Message = "Class update succesfully";
                _view.IsEdit = false;
            }
            else
            {
                // Add new Class
                _view.Message = "Class add succesfully";
                await _classRepository.CreateAsync(model);

            }
            await LoadClassList();
            _view.ShowMessage(_view.Message);
            _view_CancelEvent(sender, e);
        }


        private void _view_CancelEvent(object? sender, EventArgs e)
        {
            _view.ClassId = "";
            _view.ClassName = "";
            _view.DepartmentId = "";
            _view.YearCode = "";
            _view.IsEdit = false;
        }

        private async void _view_SearchEventAsync(object? sender, EventArgs e)
        {
            var searchValue = _view.SearchValue?.Trim();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                _classes = (await _classRepository.GetAllAsync())
                        .Where(d => d.ClassName.Contains(searchValue));
                _bindingSource.DataSource = _classes;
            }
            else
            {
                await LoadClassList();
            }
        }

        private async void _view_DeleteEventAsync(object? sender, EventArgs e)
        {
            var current = _bindingSource.Current as Class;
            if (current != null)
            {
                try
                {
                    await _classRepository.DeleteAsync(current.ClassId);
                    _view.Message = "Class deleted successfully";
                    await LoadClassList();
                }
                catch (Exception ex)
                {
                    _view.Message = $"Error: {ex.Message}";
                }
            }
            else
            {
                _view.Message = "No Class selected for deletion";
            }

            _view.ShowMessage(_view.Message);
        }

        private void _view_EditEvent(object? sender, EventArgs e)
        {
            var model = (Class)_bindingSource.Current;
            _view.ClassId = model.ClassId;
            _view.ClassName = model.ClassName;
            _view.DepartmentId = model.DepartmentId;
            _view.YearCode = model.YearCode?? "";
            _view.IsEdit = true;
        }

        private void _view_AddNewEvent(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
            _view_CancelEvent(sender, e);
        }
    }
}