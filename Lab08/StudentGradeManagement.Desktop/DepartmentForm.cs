using StudentGradeManagement.Library.View;

namespace StudentGradeManagement.Desktop
{
    public partial class DepartmentForm : Form, IDepartmentView
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        public string DepartmentId { get => txtDepartmentId.Text; set => txtDepartmentId.Text = value; }
        public string DepartmentName { get => txtDepartmentName.Text; set => txtDepartmentName.Text = value; }
        public string? Building { get => cbBuilding.SelectedText; set => cbBuilding.SelectedText = value; }

        public event EventHandler? SearchEvent;
        public event EventHandler? AddNewEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

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
