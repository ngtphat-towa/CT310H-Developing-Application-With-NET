using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Subject
{
    public partial class CourseForm : Form, ISubjectView
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        public string CourseId { get => txtCourseId.Text; set => txtCourseId.Text = value; }
        public string CourseName { get => txtCourseName.Text; set => txtCourseName.Text = value; }
        public string DepartmentId { get => cbDepartment.SelectedValue?.ToString()!; set => cbDepartment.SelectedValue = value; }
        public int CreditNumber { get => (int)numCourseCredit.Value; set => numCourseCredit.Value = value; }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddNewEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        public void CloseView()
        {
            this.Close();
        }

        public void PopulateCourseListBindingSource(BindingSource departmentList)
        {
            cbDepartment.DataSource = departmentList;
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
        }

        public void SetCourseListBindingSource(BindingSource courseList)
        {
            dgvSubjects.DataSource = courseList;
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowView()
        {
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
