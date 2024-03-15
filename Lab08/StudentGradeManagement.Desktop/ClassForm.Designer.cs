
namespace StudentGradeManagement.Desktop
{
    partial class ClassForm
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
            label1 = new Label();
            gbSubjectDetailModule = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            txtClassId = new TextBox();
            txtClassName = new TextBox();
            label3 = new Label();
            lbdDep = new Label();
            cbDepartment = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            label4 = new Label();
            txtYearCode = new TextBox();
            tbHeading = new TableLayoutPanel();
            btnClose = new Button();
            tbMain = new TableLayoutPanel();
            gbSubjectList = new GroupBox();
            tbSubjectListFunction = new TableLayoutPanel();
            dgvClass = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            gbSubjectDetailModule.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbHeading.SuspendLayout();
            tbMain.SuspendLayout();
            gbSubjectList.SuspendLayout();
            tbSubjectListFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1081, 41);
            label1.TabIndex = 1;
            label1.Text = "Mangage Class ";
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
            gbSubjectDetailModule.Size = new Size(1151, 162);
            gbSubjectDetailModule.TabIndex = 3;
            gbSubjectDetailModule.TabStop = false;
            gbSubjectDetailModule.Text = "Class Details";
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
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtClassId, 1, 0);
            tableLayoutPanel1.Controls.Add(txtClassName, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lbdDep, 2, 0);
            tableLayoutPanel1.Controls.Add(cbDepartment, 3, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(txtYearCode, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1143, 130);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 4);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 0;
            label2.Text = "Class ID";
            // 
            // txtClassId
            // 
            txtClassId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClassId.Location = new Point(116, 4);
            txtClassId.Margin = new Padding(4);
            txtClassId.Name = "txtClassId";
            txtClassId.Size = new Size(346, 31);
            txtClassId.TabIndex = 1;
            // 
            // txtClassName
            // 
            txtClassName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClassName.Location = new Point(116, 69);
            txtClassName.Margin = new Padding(4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(346, 31);
            txtClassName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 69);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 3;
            label3.Text = "Class Name";
            // 
            // lbdDep
            // 
            lbdDep.AutoSize = true;
            lbdDep.Location = new Point(470, 4);
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
            cbDepartment.Location = new Point(584, 3);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(348, 33);
            cbDepartment.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(935, 65);
            btnCancel.Margin = new Padding(0, 0, 0, 25);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(208, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(935, 0);
            btnSave.Margin = new Padding(0, 0, 0, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 69);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Year code";
            // 
            // txtYearCode
            // 
            txtYearCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYearCode.Location = new Point(585, 69);
            txtYearCode.Margin = new Padding(4);
            txtYearCode.Name = "txtYearCode";
            txtYearCode.Size = new Size(346, 31);
            txtYearCode.TabIndex = 2;
            // 
            // tbHeading
            // 
            tbHeading.ColumnCount = 2;
            tbHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbHeading.ColumnStyles.Add(new ColumnStyle());
            tbHeading.Controls.Add(btnClose, 0, 0);
            tbHeading.Controls.Add(label1, 0, 0);
            tbHeading.Dock = DockStyle.Top;
            tbHeading.Location = new Point(3, 3);
            tbHeading.Name = "tbHeading";
            tbHeading.RowCount = 1;
            tbHeading.RowStyles.Add(new RowStyle());
            tbHeading.Size = new Size(1153, 47);
            tbHeading.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1092, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 41);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tbMain
            // 
            tbMain.ColumnCount = 1;
            tbMain.ColumnStyles.Add(new ColumnStyle());
            tbMain.Controls.Add(gbSubjectList, 0, 2);
            tbMain.Controls.Add(gbSubjectDetailModule, 0, 1);
            tbMain.Controls.Add(tbHeading, 0, 0);
            tbMain.Dock = DockStyle.Fill;
            tbMain.Location = new Point(0, 0);
            tbMain.Margin = new Padding(4);
            tbMain.Name = "tbMain";
            tbMain.RowCount = 3;
            tbMain.RowStyles.Add(new RowStyle());
            tbMain.RowStyles.Add(new RowStyle());
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbMain.Size = new Size(1107, 583);
            tbMain.TabIndex = 2;
            // 
            // gbSubjectList
            // 
            gbSubjectList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSubjectList.AutoSize = true;
            gbSubjectList.Controls.Add(tbSubjectListFunction);
            gbSubjectList.Location = new Point(4, 227);
            gbSubjectList.Margin = new Padding(4);
            gbSubjectList.Name = "gbSubjectList";
            gbSubjectList.Padding = new Padding(4);
            gbSubjectList.Size = new Size(1151, 352);
            gbSubjectList.TabIndex = 2;
            gbSubjectList.TabStop = false;
            gbSubjectList.Text = "Class List";
            // 
            // tbSubjectListFunction
            // 
            tbSubjectListFunction.AutoSize = true;
            tbSubjectListFunction.ColumnCount = 2;
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.3541641F));
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.645833F));
            tbSubjectListFunction.Controls.Add(dgvClass, 0, 0);
            tbSubjectListFunction.Controls.Add(tableLayoutPanel2, 1, 0);
            tbSubjectListFunction.Dock = DockStyle.Fill;
            tbSubjectListFunction.Location = new Point(4, 28);
            tbSubjectListFunction.Margin = new Padding(4);
            tbSubjectListFunction.Name = "tbSubjectListFunction";
            tbSubjectListFunction.RowCount = 1;
            tbSubjectListFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbSubjectListFunction.Size = new Size(1143, 320);
            tbSubjectListFunction.TabIndex = 0;
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Dock = DockStyle.Fill;
            dgvClass.Location = new Point(4, 4);
            dgvClass.Margin = new Padding(4);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersWidth = 51;
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.Size = new Size(979, 312);
            dgvClass.TabIndex = 2;
            dgvClass.CellContentDoubleClick += dgvClass_CellContentDoubleClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 2);
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(991, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(148, 312);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(4, 162);
            btnDelete.Margin = new Padding(4, 4, 4, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.AutoSize = true;
            btnEdit.Location = new Point(4, 83);
            btnEdit.Margin = new Padding(4, 4, 4, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(4, 4);
            btnAdd.Margin = new Padding(4, 4, 4, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ClassForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 583);
            Controls.Add(tbMain);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            MinimumSize = new Size(1125, 630);
            Name = "ClassForm";
            Text = "ClassForm";
            gbSubjectDetailModule.ResumeLayout(false);
            gbSubjectDetailModule.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tbHeading.ResumeLayout(false);
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            gbSubjectList.ResumeLayout(false);
            gbSubjectList.PerformLayout();
            tbSubjectListFunction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private GroupBox gbSubjectDetailModule;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox txtClassId;
        private TextBox txtClassName;
        private Label label3;
        private Label lbdDep;
        private ComboBox cbDepartment;
        private Button btnCancel;
        private Button btnSave;
        private TableLayoutPanel tbHeading;
        private Button btnClose;
        private TableLayoutPanel tbMain;
        private GroupBox gbSubjectList;
        private TableLayoutPanel tbSubjectListFunction;
        private DataGridView dgvClass;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label4;
        private TextBox txtYearCode;
    }
}