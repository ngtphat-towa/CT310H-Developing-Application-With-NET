namespace Part01.DVDLibraryMnt.Desktop
{
    partial class DVDLibraryForm
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
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDVDCodeNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbSubtitle = new System.Windows.Forms.GroupBox();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.updPrice = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.tlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSubtitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 1;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.lbHeading, 0, 0);
            this.tlMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 5;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.15741F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.84259F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlMain.Size = new System.Drawing.Size(608, 513);
            this.tlMain.TabIndex = 0;
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
            this.lbHeading.Size = new System.Drawing.Size(602, 107);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "DVD Catalog";
            this.lbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLang, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gbSubtitle, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cboLang, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.updPrice, 1, 6);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 110);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 297);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDVDCodeNo
            // 
            this.lblDVDCodeNo.AutoSize = true;
            this.lblDVDCodeNo.Location = new System.Drawing.Point(3, 0);
            this.lblDVDCodeNo.Name = "lblDVDCodeNo";
            this.lblDVDCodeNo.Size = new System.Drawing.Size(116, 22);
            this.lblDVDCodeNo.TabIndex = 0;
            this.lblDVDCodeNo.Text = "DVD Number";
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
            this.lblTitle.Size = new System.Drawing.Size(81, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "DVD title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(194, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(351, 28);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = " ";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(3, 108);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(90, 22);
            this.lblLang.TabIndex = 4;
            this.lblLang.Text = "Language";
            this.lblLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 158);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSubtitle
            // 
            this.gbSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubtitle.Controls.Add(this.tableLayoutPanel3);
            this.gbSubtitle.Location = new System.Drawing.Point(194, 209);
            this.gbSubtitle.Name = "gbSubtitle";
            this.gbSubtitle.Padding = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.gbSubtitle.Size = new System.Drawing.Size(351, 85);
            this.gbSubtitle.TabIndex = 6;
            this.gbSubtitle.TabStop = false;
            this.gbSubtitle.Text = "Subtile";
            // 
            // cboLang
            // 
            this.cboLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "Chinese",
            "Russian"});
            this.cboLang.Location = new System.Drawing.Point(194, 111);
            this.cboLang.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(254, 30);
            this.cboLang.TabIndex = 7;
            // 
            // updPrice
            // 
            this.updPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updPrice.Location = new System.Drawing.Point(194, 161);
            this.updPrice.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.updPrice.Name = "updPrice";
            this.updPrice.Size = new System.Drawing.Size(254, 28);
            this.updPrice.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 435);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 44);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.rbtnYes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rbtnNo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 58);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // rbtnYes
            // 
            this.rbtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(3, 3);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(62, 52);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(127, 3);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(54, 52);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // DVDLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(608, 513);
            this.Controls.Add(this.tlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(626, 560);
            this.Name = "DVDLibraryForm";
            this.Text = "DVD Library";
            this.tlMain.ResumeLayout(false);
            this.tlMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbSubtitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDVDCodeNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbSubtitle;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.NumericUpDown updPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.RadioButton rbtnNo;
    }
}

