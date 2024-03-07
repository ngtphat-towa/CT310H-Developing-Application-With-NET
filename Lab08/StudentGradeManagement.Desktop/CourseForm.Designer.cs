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
            label1 = new Label();
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
            tbMain.SuspendLayout();
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
            tbMain.Controls.Add(label1, 0, 0);
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
            tbMain.Size = new Size(1075, 583);
            tbMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1067, 41);
            label1.TabIndex = 0;
            label1.Text = "Mangage Course";
            // 
            // gbSubjectList
            // 
            gbSubjectList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSubjectList.AutoSize = true;
            gbSubjectList.Controls.Add(tbSubjectListFunction);
            gbSubjectList.Location = new Point(4, 228);
            gbSubjectList.Margin = new Padding(4);
            gbSubjectList.Name = "gbSubjectList";
            gbSubjectList.Padding = new Padding(4);
            gbSubjectList.Size = new Size(1067, 351);
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
            tbSubjectListFunction.Size = new Size(1059, 319);
            tbSubjectListFunction.TabIndex = 0;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Dock = DockStyle.Fill;
            dgvSubjects.Location = new Point(4, 4);
            dgvSubjects.Margin = new Padding(4);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.Size = new Size(906, 311);
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
            tableLayoutPanel2.Location = new Point(918, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(137, 311);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(4, 162);
            btnDelete.Margin = new Padding(4, 4, 4, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 50);
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
            btnEdit.Size = new Size(129, 50);
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
            btnAdd.Size = new Size(129, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbSubjectDetailModule
            // 
            gbSubjectDetailModule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSubjectDetailModule.AutoSize = true;
            gbSubjectDetailModule.Controls.Add(tableLayoutPanel1);
            gbSubjectDetailModule.Location = new Point(4, 45);
            gbSubjectDetailModule.Margin = new Padding(4);
            gbSubjectDetailModule.Name = "gbSubjectDetailModule";
            gbSubjectDetailModule.Padding = new Padding(4);
            gbSubjectDetailModule.Size = new Size(1067, 175);
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1059, 143);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 6;
            label4.Text = "Credit Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
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
            txtCourseId.Size = new Size(296, 31);
            txtCourseId.TabIndex = 1;
            // 
            // txtCourseName
            // 
            txtCourseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCourseName.Location = new Point(131, 73);
            txtCourseName.Margin = new Padding(4);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(296, 31);
            txtCourseName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 3;
            label3.Text = "Course Name";
            // 
            // lbdDep
            // 
            lbdDep.AutoSize = true;
            lbdDep.Location = new Point(435, 0);
            lbdDep.Margin = new Padding(4, 0, 4, 0);
            lbdDep.Name = "lbdDep";
            lbdDep.Size = new Size(107, 25);
            lbdDep.TabIndex = 4;
            lbdDep.Text = "Department";
            // 
            // cbDepartment
            // 
            cbDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(571, 3);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(298, 33);
            cbDepartment.TabIndex = 5;
            // 
            // numCourseCredit
            // 
            numCourseCredit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numCourseCredit.Location = new Point(571, 72);
            numCourseCredit.Margin = new Padding(3, 3, 3, 40);
            numCourseCredit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCourseCredit.Name = "numCourseCredit";
            numCourseCredit.Size = new Size(298, 31);
            numCourseCredit.TabIndex = 7;
            numCourseCredit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(876, 4);
            btnSave.Margin = new Padding(4, 4, 4, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(179, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1075, 583);
            Controls.Add(tbMain);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CourseForm";
            Text = "SubjectForm";
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
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
        private Label label1;
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
    }
}