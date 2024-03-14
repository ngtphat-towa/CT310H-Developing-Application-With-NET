﻿using StudentGradeManagement.Desktop.Presenter;
using StudentGradeManagement.Desktop.Providers;
using StudentGradeManagement.Library.Repositories;
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Library.Presenter
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;

        public DashboardPresenter(IDashboardView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.LogoutEvent += _view_LogoutEvent;
            _view.ShowDepartmentView += _view_ShowDepartmentView;

        }


        private void _view_ShowDepartmentView(object? sender, EventArgs e)
        {
            var view = ViewProvider.GetDepartmentView((Form?)_view);
            var repository = new DepartmentRepository();
            _ = new DepartmentPresenter(view, repository);
            view!.Show();
        }

        private void _view_LogoutEvent(object? sender, EventArgs e)
        {
            ViewProvider.GetLoginView().Show();
            ((Form)_view).Close();
        }

        public void ShowView()
        {
            _view.ShowView();
        }
        
    }
}