namespace lab_2_2
{
    partial class frmEmployeeDetails
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
            tbLayoutBtns = new TableLayoutPanel();
            btnClear = new Button();
            btnSave = new Button();
            btnExit = new Button();
            label3 = new Label();
            label1 = new Label();
            txtFullName = new TextBox();
            lbYears = new Label();
            tbPanel = new TableLayoutPanel();
            tbLayoutForm = new TableLayoutPanel();
            cboEducation = new ComboBox();
            lbDevision = new Label();
            lbHob = new Label();
            txtAddress = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            cboDepartment = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbHeading = new Label();
            tbLayoutBtns.SuspendLayout();
            tbPanel.SuspendLayout();
            tbLayoutForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbLayoutBtns
            // 
            tbLayoutBtns.ColumnCount = 5;
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tbLayoutBtns.Controls.Add(btnClear, 2, 1);
            tbLayoutBtns.Controls.Add(btnSave, 1, 1);
            tbLayoutBtns.Controls.Add(btnExit, 3, 1);
            tbLayoutBtns.Dock = DockStyle.Fill;
            tbLayoutBtns.Location = new Point(3, 413);
            tbLayoutBtns.Name = "tbLayoutBtns";
            tbLayoutBtns.RowCount = 3;
            tbLayoutBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayoutBtns.RowStyles.Add(new RowStyle());
            tbLayoutBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayoutBtns.Size = new Size(595, 77);
            tbLayoutBtns.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Dock = DockStyle.Top;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(229, 18);
            btnClear.Margin = new Padding(10, 3, 10, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Top;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(75, 18);
            btnSave.Margin = new Padding(10, 3, 10, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Dock = DockStyle.Top;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(383, 18);
            btnExit.Margin = new Padding(10, 3, 10, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 230);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 4;
            label3.Text = "Student Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 36);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(159, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(359, 30);
            txtFullName.TabIndex = 1;
            // 
            // lbYears
            // 
            lbYears.AutoSize = true;
            lbYears.Location = new Point(3, 70);
            lbYears.Name = "lbYears";
            lbYears.Size = new Size(149, 23);
            lbYears.TabIndex = 2;
            lbYears.Text = "Employee Address";
            lbYears.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPanel
            // 
            tbPanel.ColumnCount = 1;
            tbPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbPanel.Controls.Add(tbLayoutForm, 0, 0);
            tbPanel.Controls.Add(tbLayoutBtns, 0, 1);
            tbPanel.Dock = DockStyle.Fill;
            tbPanel.Location = new Point(3, 92);
            tbPanel.Name = "tbPanel";
            tbPanel.RowCount = 2;
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tbPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tbPanel.Size = new Size(601, 493);
            tbPanel.TabIndex = 1;
            // 
            // tbLayoutForm
            // 
            tbLayoutForm.ColumnCount = 2;
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tbLayoutForm.Controls.Add(label3, 0, 4);
            tbLayoutForm.Controls.Add(label1, 0, 0);
            tbLayoutForm.Controls.Add(txtFullName, 1, 0);
            tbLayoutForm.Controls.Add(lbYears, 0, 2);
            tbLayoutForm.Controls.Add(cboEducation, 1, 6);
            tbLayoutForm.Controls.Add(lbDevision, 0, 6);
            tbLayoutForm.Controls.Add(lbHob, 0, 8);
            tbLayoutForm.Controls.Add(txtAddress, 1, 2);
            tbLayoutForm.Controls.Add(dateTimePicker1, 1, 4);
            tbLayoutForm.Controls.Add(cboDepartment, 1, 8);
            tbLayoutForm.Dock = DockStyle.Fill;
            tbLayoutForm.Location = new Point(40, 3);
            tbLayoutForm.Margin = new Padding(40, 3, 40, 3);
            tbLayoutForm.Name = "tbLayoutForm";
            tbLayoutForm.RowCount = 9;
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.Size = new Size(521, 404);
            tbLayoutForm.TabIndex = 2;
            // 
            // cboEducation
            // 
            cboEducation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEducation.FormattingEnabled = true;
            cboEducation.Items.AddRange(new object[] { "UnderGraduate", "PostGraduat" });
            cboEducation.Location = new Point(159, 303);
            cboEducation.Name = "cboEducation";
            cboEducation.Size = new Size(250, 31);
            cboEducation.TabIndex = 6;
            // 
            // lbDevision
            // 
            lbDevision.AutoSize = true;
            lbDevision.Location = new Point(3, 300);
            lbDevision.Name = "lbDevision";
            lbDevision.Size = new Size(91, 23);
            lbDevision.TabIndex = 8;
            lbDevision.Text = "Education ";
            lbDevision.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbHob
            // 
            lbHob.AutoSize = true;
            lbHob.Location = new Point(3, 368);
            lbHob.Name = "lbHob";
            lbHob.Size = new Size(102, 23);
            lbHob.TabIndex = 10;
            lbHob.Text = "Department";
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(159, 73);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(359, 120);
            txtAddress.TabIndex = 11;
            txtAddress.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(159, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeftLayout = true;
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2023, 12, 28, 11, 59, 38, 0);
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Items.AddRange(new object[] { "Human Resource", "Marketing", "R&D" });
            cboDepartment.Location = new Point(159, 371);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(250, 31);
            cboDepartment.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbHeading, 0, 0);
            tableLayoutPanel1.Controls.Add(tbPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(607, 588);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbHeading
            // 
            lbHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbHeading.Location = new Point(3, 0);
            lbHeading.Name = "lbHeading";
            lbHeading.Size = new Size(601, 89);
            lbHeading.TabIndex = 0;
            lbHeading.Text = "Employee Details";
            lbHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 588);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(625, 635);
            Name = "frmEmployeeDetails";
            Text = "frmEmployeeDetails";
            tbLayoutBtns.ResumeLayout(false);
            tbLayoutBtns.PerformLayout();
            tbPanel.ResumeLayout(false);
            tbLayoutForm.ResumeLayout(false);
            tbLayoutForm.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tbLayoutBtns;
        private Button btnSave;
        private Label label3;
        private Label label1;
        private TextBox txtFullName;
        private Label lbYears;
        private TableLayoutPanel tbPanel;
        private TableLayoutPanel tbLayoutForm;
        private ComboBox cboEducation;
        private Label lbDevision;
        private Label lbHob;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbHeading;
        private RichTextBox txtAddress;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboDepartment;
        private Button btnClear;
        private Button btnExit;
    }
}