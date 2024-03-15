using StudentGradeManagement.Library.View;


namespace StudentGradeManagement.Desktop
{
    public partial class DashboardForm : Form, IDashboardView
    {
        public DashboardForm()
        {
            InitializeComponent();
        }



        public void ShowView()
        {
            this.Show();
        }

        public event EventHandler? LogoutEvent;
        public event EventHandler? ShowDepartmentView;
        public event EventHandler? ShowCourseView;
        public event EventHandler? ShowClassView;

        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCourseView?.Invoke(this, EventArgs.Empty);

        }

        private void mangeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageIntructorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Ask close or logout 
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            LogoutEvent?.Invoke(this, EventArgs.Empty);
        }

        private void manageDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDepartmentView?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void manageClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClassView?.Invoke(this, EventArgs.Empty);
        }
    }
}
