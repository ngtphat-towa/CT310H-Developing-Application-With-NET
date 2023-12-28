namespace lab_2
{
    partial class frmStudentDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lbHeading = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbLayoutForm = new TableLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            lbYears = new Label();
            txtYear = new TextBox();
            cboDiv = new ComboBox();
            lstClass = new ListBox();
            lbDevision = new Label();
            lstHob = new CheckedListBox();
            lbHob = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnConfirm = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tbLayoutForm.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbHeading, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(607, 613);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbHeading
            // 
            lbHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbHeading.Location = new Point(3, 0);
            lbHeading.Name = "lbHeading";
            lbHeading.Size = new Size(601, 89);
            lbHeading.TabIndex = 0;
            lbHeading.Text = "Student's Class Details";
            lbHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tbLayoutForm, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 92);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(601, 518);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tbLayoutForm
            // 
            tbLayoutForm.ColumnCount = 2;
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tbLayoutForm.Controls.Add(label3, 0, 4);
            tbLayoutForm.Controls.Add(label1, 0, 0);
            tbLayoutForm.Controls.Add(txtName, 1, 0);
            tbLayoutForm.Controls.Add(lbYears, 0, 2);
            tbLayoutForm.Controls.Add(txtYear, 1, 2);
            tbLayoutForm.Controls.Add(cboDiv, 1, 6);
            tbLayoutForm.Controls.Add(lstClass, 1, 4);
            tbLayoutForm.Controls.Add(lbDevision, 0, 6);
            tbLayoutForm.Controls.Add(lstHob, 1, 8);
            tbLayoutForm.Controls.Add(lbHob, 0, 8);
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
            tbLayoutForm.Size = new Size(521, 416);
            tbLayoutForm.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 120);
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
            label1.Size = new Size(120, 36);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(159, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(359, 30);
            txtName.TabIndex = 1;
            // 
            // lbYears
            // 
            lbYears.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbYears.AutoSize = true;
            lbYears.Location = new Point(3, 60);
            lbYears.Name = "lbYears";
            lbYears.Size = new Size(110, 36);
            lbYears.TabIndex = 2;
            lbYears.Text = "Years of birth";
            lbYears.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            txtYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(159, 63);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(283, 30);
            txtYear.TabIndex = 3;
            // 
            // cboDiv
            // 
            cboDiv.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiv.FormattingEnabled = true;
            cboDiv.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboDiv.Location = new Point(159, 249);
            cboDiv.Name = "cboDiv";
            cboDiv.Size = new Size(283, 31);
            cboDiv.SelectedIndex = 0;
            cboDiv.TabIndex = 6;
            // 
            // lstClass
            // 
            lstClass.FormattingEnabled = true;
            lstClass.ItemHeight = 23;
            lstClass.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
            lstClass.Location = new Point(159, 123);
            lstClass.Name = "lstClass";
            lstClass.ScrollAlwaysVisible = true;
            lstClass.Size = new Size(283, 96);
            lstClass.TabIndex = 7;
            // 
            // lbDevision
            // 
            lbDevision.AutoSize = true;
            lbDevision.Location = new Point(3, 246);
            lbDevision.Name = "lbDevision";
            lbDevision.Size = new Size(65, 23);
            lbDevision.TabIndex = 8;
            lbDevision.Text = "Divsion";
            // 
            // lstHob
            // 
            lstHob.CheckOnClick = true;
            lstHob.FormattingEnabled = true;
            lstHob.Items.AddRange(new object[] { "Singing", "Dancing", "Swimming", "Reading", "Travelling" });
            lstHob.Location = new Point(159, 307);
            lstHob.Name = "lstHob";
            lstHob.Size = new Size(283, 104);
            lstHob.TabIndex = 9;
            // 
            // lbHob
            // 
            lbHob.AutoSize = true;
            lbHob.Location = new Point(3, 304);
            lbHob.Name = "lbHob";
            lbHob.Size = new Size(72, 23);
            lbHob.TabIndex = 10;
            lbHob.Text = "Hobbies";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.93266F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.06734F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Controls.Add(btnConfirm, 1, 1);
            tableLayoutPanel4.Controls.Add(btnClear, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 425);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(595, 90);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirm.AutoSize = true;
            btnConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(118, 22);
            btnConfirm.Margin = new Padding(3, 3, 15, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(215, 45);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm Student Details";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(363, 22);
            btnClear.Margin = new Padding(15, 3, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 613);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(625, 660);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tbLayoutForm.ResumeLayout(false);
            tbLayoutForm.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tbLayoutForm;
        private Label label3;
        private Label label1;
        private TextBox txtName;
        private Label lbYears;
        private TextBox txtYear;
        private ComboBox cboDiv;
        private ListBox lstClass;
        private Label lbDevision;
        private CheckedListBox lstHob;
        private Label lbHob;
        private Label lbHeading;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnConfirm;
        private Button btnClear;
    }
}