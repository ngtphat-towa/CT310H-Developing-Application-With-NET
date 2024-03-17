namespace StudentGradeManagement.Desktop.Subject
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMain = new TableLayoutPanel();
            tbHeading = new TableLayoutPanel();
            label1 = new Label();
            btnClose = new Button();
            gbSubjectList = new GroupBox();
            tbSubjectListFunction = new TableLayoutPanel();
            dgvSubjects = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            gbSubjectDetailModule = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label2 = new Label();
            txtCourseId = new TextBox();
            txtCourseName = new TextBox();
            label3 = new Label();
            lbdDep = new Label();
            cbDepartment = new ComboBox();
            numCourseCredit = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            tbMain.SuspendLayout();
            tbHeading.SuspendLayout();
            gbSubjectList.SuspendLayout();
            tbSubjectListFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            gbSubjectDetailModule.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCourseCredit).BeginInit();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.ColumnCount = 1;
            tbMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbMain.Controls.Add(tbHeading, 0, 0);
            tbMain.Controls.Add(gbSubjectList, 0, 2);
            tbMain.Controls.Add(gbSubjectDetailModule, 0, 1);
            tbMain.Dock = DockStyle.Fill;
            tbMain.Location = new Point(0, 0);
            tbMain.Margin = new Padding(4);
            tbMain.Name = "tbMain";
            tbMain.RowCount = 3;
            tbMain.RowStyles.Add(new RowStyle());
            tbMain.RowStyles.Add(new RowStyle());
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbMain.Size = new Size(1107, 583);
            tbMain.TabIndex = 0;
            // 
            // tbHeading
            // 
            tbHeading.ColumnCount = 2;
            tbHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbHeading.ColumnStyles.Add(new ColumnStyle());
            tbHeading.Controls.Add(label1, 0, 0);
            tbHeading.Controls.Add(btnClose, 1, 0);
            tbHeading.Dock = DockStyle.Top;
            tbHeading.Location = new Point(3, 3);
            tbHeading.Name = "tbHeading";
            tbHeading.RowCount = 1;
            tbHeading.RowStyles.Add(new RowStyle());
            tbHeading.Size = new Size(1101, 47);
            tbHeading.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1029, 41);
            label1.TabIndex = 1;
            label1.Text = "Mangage Course";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1040, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 41);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // gbSubjectList
            // 
            gbSubjectList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSubjectList.AutoSize = true;
            gbSubjectList.Controls.Add(tbSubjectListFunction);
            gbSubjectList.Location = new Point(4, 236);
            gbSubjectList.Margin = new Padding(4);
            gbSubjectList.Name = "gbSubjectList";
            gbSubjectList.Padding = new Padding(4);
            gbSubjectList.Size = new Size(1099, 343);
            gbSubjectList.TabIndex = 2;
            gbSubjectList.TabStop = false;
            gbSubjectList.Text = "Subject List";
            // 
            // tbSubjectListFunction
            // 
            tbSubjectListFunction.AutoSize = true;
            tbSubjectListFunction.ColumnCount = 2;
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.3541641F));
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.645833F));
            tbSubjectListFunction.Controls.Add(dgvSubjects, 0, 0);
            tbSubjectListFunction.Controls.Add(tableLayoutPanel2, 1, 0);
            tbSubjectListFunction.Dock = DockStyle.Fill;
            tbSubjectListFunction.Location = new Point(4, 28);
            tbSubjectListFunction.Margin = new Padding(4);
            tbSubjectListFunction.Name = "tbSubjectListFunction";
            tbSubjectListFunction.RowCount = 1;
            tbSubjectListFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbSubjectListFunction.Size = new Size(1091, 311);
            tbSubjectListFunction.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Dock = DockStyle.Fill;
            dgvSubjects.Location = new Point(4, 4);
            dgvSubjects.Margin = new Padding(4);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.Size = new Size(934, 303);
            dgvSubjects.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 2);
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(946, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(141, 303);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(4, 162);
            btnDelete.Margin = new Padding(4, 4, 4, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.AutoSize = true;
            btnEdit.Location = new Point(4, 83);
            btnEdit.Margin = new Padding(4, 4, 4, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(4, 4);
            btnAdd.Margin = new Padding(4, 4, 4, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbSubjectDetailModule
            // 
            gbSubjectDetailModule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSubjectDetailModule.AutoSize = true;
            gbSubjectDetailModule.Controls.Add(tableLayoutPanel1);
            gbSubjectDetailModule.Location = new Point(4, 57);
            gbSubjectDetailModule.Margin = new Padding(4);
            gbSubjectDetailModule.Name = "gbSubjectDetailModule";
            gbSubjectDetailModule.Padding = new Padding(4);
            gbSubjectDetailModule.Size = new Size(1099, 171);
            gbSubjectDetailModule.TabIndex = 3;
            gbSubjectDetailModule.TabStop = false;
            gbSubjectDetailModule.Text = "Course Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtCourseId, 1, 0);
            tableLayoutPanel1.Controls.Add(txtCourseName, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lbdDep, 2, 0);
            tableLayoutPanel1.Controls.Add(cbDepartment, 3, 0);
            tableLayoutPanel1.Controls.Add(numCourseCredit, 3, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 4, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1091, 139);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 69);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 6;
            label4.Text = "Credit Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 4);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 0;
            label2.Text = "Course ID";
            // 
            // txtCourseId
            // 
            txtCourseId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseId.Location = new Point(131, 4);
            txtCourseId.Margin = new Padding(4);
            txtCourseId.Name = "txtCourseId";
            txtCourseId.Size = new Size(298, 31);
            txtCourseId.TabIndex = 1;
            // 
            // txtCourseName
            // 
            txtCourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseName.Location = new Point(131, 69);
            txtCourseName.Margin = new Padding(4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(298, 31);
            txtCourseName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 69);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 3;
            label3.Text = "Course Name";
            // 
            // lbdDep
            // 
            lbdDep.AutoSize = true;
            lbdDep.Location = new Point(437, 4);
            lbdDep.Margin = new Padding(4);
            lbdDep.Name = "lbdDep";
            lbdDep.Size = new Size(107, 25);
            lbdDep.TabIndex = 4;
            lbdDep.Text = "Department";
            // 
            // cbDepartment
            // 
            cbDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(573, 3);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(300, 33);
            cbDepartment.TabIndex = 5;
            // 
            // numCourseCredit
            // 
            numCourseCredit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numCourseCredit.Location = new Point(573, 68);
            numCourseCredit.Margin = new Padding(3, 3, 3, 40);
            numCourseCredit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCourseCredit.Name = "numCourseCredit";
            numCourseCredit.Size = new Size(300, 31);
            numCourseCredit.TabIndex = 7;
            numCourseCredit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(876, 0);
            btnSave.Margin = new Padding(0, 0, 0, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(876, 65);
            btnCancel.Margin = new Padding(0, 0, 0, 25);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(215, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1107, 583);
            Controls.Add(tbMain);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1125, 630);
            Name = "CourseForm";
            Text = "SubjectForm";
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            tbHeading.ResumeLayout(false);
            gbSubjectList.ResumeLayout(false);
            gbSubjectList.PerformLayout();
            tbSubjectListFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            gbSubjectDetailModule.ResumeLayout(false);
            gbSubjectDetailModule.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCourseCredit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tbMain;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gbSubjectList;
        private GroupBox gbSubjectDetailModule;
        private TableLayoutPanel tbSubjectListFunction;
        private DataGridView dgvSubjects;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Label label2;
        private TextBox txtCourseId;
        private Label label3;
        private TextBox txtCourseName;
        private Label lbdDep;
        private ComboBox cbDepartment;
        private Label label4;
        private NumericUpDown numCourseCredit;
        private Button btnSave;
        private DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sectionsDataGridViewTextBoxColumn;
        private TableLayoutPanel tbHeading;
        private Label label1;
        private Button btnClose;
        private Button btnCancel;
    }
}