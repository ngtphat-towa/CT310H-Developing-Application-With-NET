
using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop
{
    public partial class ClassForm : Form, IClassView
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        public string ClassId { get => txtClassId.Text; set => txtClassId.Text = value; }
        public string ClassName { get => txtClassName.Text; set => txtClassName.Text = value; }
        public string DepartmentId { get => cbDepartment.SelectedValue?.ToString()!; set => cbDepartment.SelectedValue = value; }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string? Message { get; set; }
        public string YearCode { get => this.txtYearCode.Text; set => this.txtYearCode.Text = value; }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddNewEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        public void PopulateDepartmentBindingSource(BindingSource buildings)
        {
            cbDepartment.DataSource = buildings;
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
        }

        public void SetClassListBindingSource(BindingSource Classs)
        {
            dgvClass.DataSource = Classs;
        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowView()
        {
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEvent?.Invoke(this, e);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewEvent?.Invoke(this, e);
        }

        private void dgvClass_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditEvent?.Invoke(this, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent?.Invoke(this, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, e);
        }
    }
}
