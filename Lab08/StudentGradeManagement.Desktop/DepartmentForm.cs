using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop
{
    public partial class DepartmentForm : Form, IDepartmentView
    {
        public DepartmentForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string DepartmentId { get => txtDepartmentId.Text; set => txtDepartmentId.Text = value; }
        public string DepartmentName { get => txtDepartmentName.Text; set => txtDepartmentName.Text = value; }
        public string? Building { get => cbBuilding.SelectedValue?.ToString(); set => cbBuilding.SelectedValue = value; }
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

        public void PopulateBuildingBindingSource(BindingSource buildings)
        {
            cbBuilding.DataSource = buildings;
            cbBuilding.DisplayMember = "Name";
            cbBuilding.ValueMember = "Name";
        }

        public void SetDepartmentListBindingSource(BindingSource departments)
        {
            dgvDepartment.DataSource = departments;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowView()
        {
            this.Show();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnClose.Click += (s, e) => this.Close();
            btnSave.Click += (s, e) => SaveEvent?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelEvent?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditEvent?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (s, e) => AddNewEvent?.Invoke(this, EventArgs.Empty);
            dgvDepartment.CellContentDoubleClick +=  (s, e) => EditEvent?.Invoke(this, e);
            btnDelete.Click += (s, e) => DeleteEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
