using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop.Subject
{
    public partial class CourseForm : Form, ICourseView
    {
        public CourseForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string CourseId { get => txtCourseId.Text; set => txtCourseId.Text = value; }
        public string CourseName { get => txtCourseName.Text; set => txtCourseName.Text = value; }
        public string DepartmentId { get => cbDepartment.SelectedValue?.ToString()!; set => cbDepartment.SelectedValue = value; }
        public int CreditNumber { get => (int)numCourseCredit.Value; set => numCourseCredit.Value = value; }

        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string? Message { get; set; }

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



        public void SetCourseListBindingSource(BindingSource courseList)
        {
            dgvSubjects.DataSource = courseList;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowView()
        {
            this.Show();
        }


        public void PopulateDepartmentListBindingSource(BindingSource departmentList)
        {
            cbDepartment.DataSource = departmentList;
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
        }


        private void AssociateAndRaiseViewEvents()
        {
            btnClose.Click += (s, e) => this.Close();
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (s, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            dgvSubjects.CellContentDoubleClick += (s, e) => EditEvent?.Invoke(this, e);
            btnDelete.Click += (s, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);
        }

    }

}

