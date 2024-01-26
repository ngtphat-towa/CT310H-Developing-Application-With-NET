namespace Part02.StaffManagement.Desktop
{
    partial class FormStaffInfo
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDVDCodeNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblLectureHours = new System.Windows.Forms.Label();
            this.cboStaffPosition = new System.Windows.Forms.ComboBox();
            this.updLectureHours = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upCostPerHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbHeading = new System.Windows.Forms.Label();
            this.ckbVietnamese = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLectureHours)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upCostPerHour)).BeginInit();
            this.tlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(80, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(386, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 375);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(233, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDVDCodeNo
            // 
            this.lblDVDCodeNo.AutoSize = true;
            this.lblDVDCodeNo.Location = new System.Drawing.Point(3, 0);
            this.lblDVDCodeNo.Name = "lblDVDCodeNo";
            this.lblDVDCodeNo.Size = new System.Drawing.Size(112, 22);
            this.lblDVDCodeNo.TabIndex = 0;
            this.lblDVDCodeNo.Text = "Staff number";
            this.lblDVDCodeNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNo.Location = new System.Drawing.Point(194, 3);
            this.txtNo.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(254, 28);
            this.txtNo.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Full name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStaffName.Location = new System.Drawing.Point(194, 57);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(351, 28);
            this.txtStaffName.TabIndex = 3;
            this.txtStaffName.Text = " ";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(3, 108);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(114, 22);
            this.lblLang.TabIndex = 4;
            this.lblLang.Text = "Staff position";
            this.lblLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLectureHours
            // 
            this.lblLectureHours.AutoSize = true;
            this.lblLectureHours.Location = new System.Drawing.Point(3, 164);
            this.lblLectureHours.Name = "lblLectureHours";
            this.lblLectureHours.Size = new System.Drawing.Size(123, 22);
            this.lblLectureHours.TabIndex = 5;
            this.lblLectureHours.Text = "Lecture Hours";
            this.lblLectureHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStaffPosition
            // 
            this.cboStaffPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStaffPosition.FormattingEnabled = true;
            this.cboStaffPosition.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "Chinese",
            "Russian"});
            this.cboStaffPosition.Location = new System.Drawing.Point(194, 111);
            this.cboStaffPosition.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.cboStaffPosition.Name = "cboStaffPosition";
            this.cboStaffPosition.Size = new System.Drawing.Size(254, 30);
            this.cboStaffPosition.TabIndex = 7;
            // 
            // updLectureHours
            // 
            this.updLectureHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updLectureHours.Location = new System.Drawing.Point(194, 167);
            this.updLectureHours.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.updLectureHours.Name = "updLectureHours";
            this.updLectureHours.Size = new System.Drawing.Size(254, 28);
            this.updLectureHours.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lblDVDCodeNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStaffName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLang, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLectureHours, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cboStaffPosition, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.updLectureHours, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.upCostPerHour, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 253);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // upCostPerHour
            // 
            this.upCostPerHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upCostPerHour.Location = new System.Drawing.Point(194, 221);
            this.upCostPerHour.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.upCostPerHour.Name = "upCostPerHour";
            this.upCostPerHour.Size = new System.Drawing.Size(254, 28);
            this.upCostPerHour.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost per hour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.lbHeading, 0, 0);
            this.tlMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tlMain.Controls.Add(this.ckbVietnamese, 0, 4);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 5;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.15741F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.84259F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlMain.Size = new System.Drawing.Size(608, 453);
            this.tlMain.TabIndex = 1;
            // 
            // lbHeading
            // 
            this.lbHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.Location = new System.Drawing.Point(3, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(602, 91);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Staff Information";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbVietnamese
            // 
            this.ckbVietnamese.AutoSize = true;
            this.ckbVietnamese.Location = new System.Drawing.Point(3, 425);
            this.ckbVietnamese.Name = "ckbVietnamese";
            this.ckbVietnamese.Size = new System.Drawing.Size(94, 24);
            this.ckbVietnamese.TabIndex = 3;
            this.ckbVietnamese.Text = "VN label";
            this.ckbVietnamese.UseVisualStyleBackColor = true;
            // 
            // FormStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 453);
            this.Controls.Add(this.tlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(626, 500);
            this.Name = "FormStaffInfo";
            this.Text = "Univeristy Staff";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updLectureHours)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upCostPerHour)).EndInit();
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDVDCodeNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblLectureHours;
        private System.Windows.Forms.ComboBox cboStaffPosition;
        private System.Windows.Forms.NumericUpDown updLectureHours;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.NumericUpDown upCostPerHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbVietnamese;
    }
}

