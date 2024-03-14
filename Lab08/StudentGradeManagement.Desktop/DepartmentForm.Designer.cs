namespace StudentGradeManagement.Desktop
{
    partial class DepartmentForm
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
            label2 = new Label();
            txtDepartmentId = new TextBox();
            txtDepartmentName = new TextBox();
            label3 = new Label();
            lbdDep = new Label();
            cbBuilding = new ComboBox();
            btnSave = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvDepartment = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbSubjectListFunction = new TableLayoutPanel();
            gbSubjectList = new GroupBox();
            tbMain = new TableLayoutPanel();
            gbSubjectDetailModule = new GroupBox();
            tbHeading = new TableLayoutPanel();
            btnClose = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tbSubjectListFunction.SuspendLayout();
            gbSubjectList.SuspendLayout();
            tbMain.SuspendLayout();
            gbSubjectDetailModule.SuspendLayout();
            tbHeading.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 4);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 0;
            label2.Text = "Department ID";
            // 
            // txtDepartmentId
            // 
            txtDepartmentId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartmentId.Location = new Point(171, 4);
            txtDepartmentId.Margin = new Padding(4);
            txtDepartmentId.Name = "txtDepartmentId";
            txtDepartmentId.Size = new Size(328, 31);
            txtDepartmentId.TabIndex = 1;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDepartmentName.Location = new Point(171, 69);
            txtDepartmentName.Margin = new Padding(4);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(328, 31);
            txtDepartmentName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 69);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 3;
            label3.Text = "Department Name";
            // 
            // lbdDep
            // 
            lbdDep.AutoSize = true;
            lbdDep.Location = new Point(507, 4);
            lbdDep.Margin = new Padding(4);
            lbdDep.Name = "lbdDep";
            lbdDep.Size = new Size(76, 25);
            lbdDep.TabIndex = 4;
            lbdDep.Text = "Building";
            // 
            // cbBuilding
            // 
            cbBuilding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(590, 3);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(330, 33);
            cbBuilding.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(923, 0);
            btnSave.Margin = new Padding(0, 0, 0, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            tableLayoutPanel1.Controls.Add(txtDepartmentId, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDepartmentName, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(lbdDep, 2, 0);
            tableLayoutPanel1.Controls.Add(cbBuilding, 3, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 4, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1121, 130);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(923, 65);
            btnCancel.Margin = new Padding(0, 0, 0, 25);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(4, 162);
            btnDelete.Margin = new Padding(4, 4, 4, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 50);
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
            btnEdit.Size = new Size(137, 50);
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
            btnAdd.Size = new Size(137, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToAddRows = false;
            dgvDepartment.AllowUserToDeleteRows = false;
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Dock = DockStyle.Fill;
            dgvDepartment.Location = new Point(4, 4);
            dgvDepartment.Margin = new Padding(4);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDepartment.Size = new Size(960, 312);
            dgvDepartment.TabIndex = 2;
            dgvDepartment.CellContentDoubleClick += dgvDepartment_CellContentDoubleClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 2);
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(972, 4);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(145, 312);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tbSubjectListFunction
            // 
            tbSubjectListFunction.AutoSize = true;
            tbSubjectListFunction.ColumnCount = 2;
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.3541641F));
            tbSubjectListFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.645833F));
            tbSubjectListFunction.Controls.Add(dgvDepartment, 0, 0);
            tbSubjectListFunction.Controls.Add(tableLayoutPanel2, 1, 0);
            tbSubjectListFunction.Dock = DockStyle.Fill;
            tbSubjectListFunction.Location = new Point(4, 28);
            tbSubjectListFunction.Margin = new Padding(4);
            tbSubjectListFunction.Name = "tbSubjectListFunction";
            tbSubjectListFunction.RowCount = 1;
            tbSubjectListFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbSubjectListFunction.Size = new Size(1121, 320);
            tbSubjectListFunction.TabIndex = 0;
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
            gbSubjectList.Size = new Size(1129, 352);
            gbSubjectList.TabIndex = 2;
            gbSubjectList.TabStop = false;
            gbSubjectList.Text = "Department List";
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
            tbMain.TabIndex = 1;
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
            gbSubjectDetailModule.Size = new Size(1129, 162);
            gbSubjectDetailModule.TabIndex = 3;
            gbSubjectDetailModule.TabStop = false;
            gbSubjectDetailModule.Text = "Department Details";
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
            tbHeading.Size = new Size(1131, 47);
            tbHeading.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = SystemColors.ButtonFace;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1070, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 41);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 41);
            label1.TabIndex = 1;
            label1.Text = "Mangage Department";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1107, 583);
            Controls.Add(tbMain);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            MinimumSize = new Size(1125, 630);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tbSubjectListFunction.ResumeLayout(false);
            gbSubjectList.ResumeLayout(false);
            gbSubjectList.PerformLayout();
            tbMain.ResumeLayout(false);
            tbMain.PerformLayout();
            gbSubjectDetailModule.ResumeLayout(false);
            gbSubjectDetailModule.PerformLayout();
            tbHeading.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtDepartmentId;
        private TextBox txtDepartmentName;
        private Label label3;
        private Label lbdDep;
        private ComboBox cbBuilding;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvDepartment;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tbSubjectListFunction;
        private GroupBox gbSubjectList;
        private TableLayoutPanel tbMain;
        private GroupBox gbSubjectDetailModule;
        private Button btnCancel;
        private TableLayoutPanel tbHeading;
        private Label label1;
        private Button btnClose;
    }
}