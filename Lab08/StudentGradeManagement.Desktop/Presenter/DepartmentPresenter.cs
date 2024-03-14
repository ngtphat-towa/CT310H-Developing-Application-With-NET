using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentGradeManagement.Library.Model;
using StudentGradeManagement.Library.Repositories;
using StudentGradeManagement.Library.Repositories.Contracts;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Presenter
{
    public class DepartmentPresenter
    {
        // View - Services
        private readonly IDepartmentView _view;
        private readonly IBaseRepository<Department> _repository;
        // State values
        private readonly BindingSource _bindingSource;
        private IEnumerable<Department>? _departments;

        public DepartmentPresenter(IDepartmentView view,
                                   IBaseRepository<Department> repository)
        {
            // DI
            _repository = repository;
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
            _view.SetDepartmentListBindingSource(_bindingSource);

            _ = initView();
        }

        private async Task initView()
        {
            LoadBuildingList();

            await LoadDepartmentList();

        }

        private async Task LoadDepartmentList()
        {
            // Populate the department data grid view
            _departments = await _repository.GetAllAsync();
            _bindingSource.DataSource = _departments;
        }

        private void LoadBuildingList()
        {
            // Create a temporary list of buildings
            var buildings = new List<dynamic>
            {
                new  { Id = 0, Name = "" },
                new  { Id = 1, Name = "Building A" },
                new { Id = 2, Name = "Building B" },
                new { Id = 3, Name = "Building C" },
                new { Id = 4, Name = "Main Building" }
            };

            // Populate the building view
            _view.PopulateBuildingBindingSource(new BindingSource(buildings, null));
        }

        private async void _view_SaveEvent(object? sender, EventArgs e)
        {
            var model = new Department()
            {
                DepartmentId = _view.DepartmentId,
                DepartmentName = _view.DepartmentName,
                Building = _view.Building
            };

            // Check if it is a editing mode
            if (_view.IsEdit)
            {
                // Update the department
                // TODO: validate model
                await _repository.UpdateAsync(model);
                _view.Message = "Department update succesfully";
                _view.IsEdit = false;
            }
            else
            {
                // Add new department
                _view.Message = "Department add succesfully";
                await _repository.CreateAsync(model);

            }
            await LoadDepartmentList();
            _view.ShowMessage(_view.Message);
            _view_CancelEvent(sender, e);
        }


        private void _view_CancelEvent(object? sender, EventArgs e)
        {
            _view.DepartmentId = "";
            _view.DepartmentName = "";
            _view.Building = "";
            _view.IsEdit = false;
        }

        private async void _view_SearchEventAsync(object? sender, EventArgs e)
        {
            var searchValue = _view.SearchValue?.Trim();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                _departments = (await _repository.GetAllAsync())
                        .Where(d => d.DepartmentName.Contains(searchValue));
                _bindingSource.DataSource = _departments;
            }
            else
            {
                await LoadDepartmentList();
            }
        }

        private async void _view_DeleteEventAsync(object? sender, EventArgs e)
        {
            var department = _bindingSource.Current as Department;
            if (department != null)
            {
                try
                {
                    await _repository.DeleteAsync(department.DepartmentId);
                    _view.Message = "Department deleted successfully";
                    await LoadDepartmentList();
                }
                catch (Exception ex)
                {
                    _view.Message = $"Error: {ex.Message}";
                }
            }
            else
            {
                _view.Message = "No department selected for deletion";
            }

            _view.ShowMessage(_view.Message);
        }

        private void _view_EditEvent(object? sender, EventArgs e)
        {
            var model = (Department)_bindingSource.Current;
            _view.DepartmentId = model.DepartmentId;
            _view.DepartmentName = model.DepartmentName;
            _view.Building = model.Building;
            _view.IsEdit = true;
        }

        private void _view_AddNewEvent(object? sender, EventArgs e)
        {
            _view.IsEdit = false;
            _view_CancelEvent(sender, e);
        }
    }
}