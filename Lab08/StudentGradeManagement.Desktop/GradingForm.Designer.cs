using System.Drawing;
using System.Windows.Forms;

namespace StudentGradeManagement.Desktop
{
    partial class GradingForm
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.lbHeading = new System.Windows.Forms.Label();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.dgvStudentGradings = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.gbClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGradings)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblMain.Controls.Add(this.lbHeading, 0, 0);
            this.tblMain.Controls.Add(this.dgvStudentGradings, 0, 2);
            this.tblMain.Controls.Add(this.gbClass, 0, 1);
            this.tblMain.Controls.Add(this.gbCourse, 1, 1);
            this.tblMain.Controls.Add(this.btnSave, 2, 1);
            this.tblMain.Controls.Add(this.btnLogout, 2, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(1182, 603);
            this.tblMain.TabIndex = 0;
            // 
            // gbCourse
            // 
            this.gbCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCourse.AutoSize = true;
            this.gbCourse.Controls.Add(this.cbCourses);
            this.gbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCourse.Location = new System.Drawing.Point(403, 65);
            this.gbCourse.Margin = new System.Windows.Forms.Padding(10);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(374, 57);
            this.gbCourse.TabIndex = 2;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Course";
            // 
            // cbCourses
            // 
            this.cbCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(3, 24);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(368, 30);
            this.cbCourses.TabIndex = 0;
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.cbCourses_SelectedIndexChanged);
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(3, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(175, 31);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Grading Form";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbClass
            // 
            this.gbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClass.AutoSize = true;
            this.gbClass.Controls.Add(this.cbClasses);
            this.gbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClass.Location = new System.Drawing.Point(10, 65);
            this.gbClass.Margin = new System.Windows.Forms.Padding(10);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(373, 57);
            this.gbClass.TabIndex = 1;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Class";
            // 
            // cbClasses
            // 
            this.cbClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(3, 24);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(367, 30);
            this.cbClasses.TabIndex = 0;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // dgvStudentGradings
            // 
            this.dgvStudentGradings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentGradings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudentGradings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.dgvStudentGradings, 3);
            this.dgvStudentGradings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentGradings.Location = new System.Drawing.Point(3, 135);
            this.dgvStudentGradings.Name = "dgvStudentGradings";
            this.dgvStudentGradings.RowHeadersWidth = 51;
            this.dgvStudentGradings.RowTemplate.Height = 24;
            this.dgvStudentGradings.Size = new System.Drawing.Size(1176, 465);
            this.dgvStudentGradings.TabIndex = 3;
            this.dgvStudentGradings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentGradings_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(790, 70);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1059, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 15, 3, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // GradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GradingForm";
            this.Text = "Home";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.gbCourse.ResumeLayout(false);
            this.gbClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGradings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lbHeading;
        private GroupBox gbCourse;
        private ComboBox cbCourses;
        private GroupBox gbClass;
        private ComboBox cbClasses;
        private DataGridView dgvStudentGradings;
        private Button btnSave;
        private Button btnLogout;
    }
}