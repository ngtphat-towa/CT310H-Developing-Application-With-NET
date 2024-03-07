using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Presenter
{
    public class DepartmentPresenter
    {
        private readonly IDepartmentView _view;

        public DepartmentPresenter(IDepartmentView view)
        {
            _view = view;
            _view.AddNewEvent += _view_AddNewEvent;
            _view.EditEvent += _view_EditEvent;
            _view.DeleteEvent += _view_DeleteEvent;
            _view.SearchEvent += _view_SearchEvent;
            _view.SaveEvent += _view_SaveEvent;
            _view.CancelEvent += _view_CancelEvent;
        }

        private void _view_SaveEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_CancelEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_SearchEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_DeleteEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_EditEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_AddNewEvent(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
