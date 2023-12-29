namespace Lab03
{
    partial class BookSaleForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuBtnCalculate = new ToolStripMenuItem();
            menuBtnSummary = new ToolStripMenuItem();
            menuBtnClear = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tbLayoutMain = new TableLayoutPanel();
            gbBookInfo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbIsStudent = new CheckBox();
            label2 = new Label();
            lbDiscount = new Label();
            txtTitle = new TextBox();
            lbTitle = new Label();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            lbPrice = new Label();
            lbTotal = new Label();
            txtExtendedPrice = new TextBox();
            cbIsNormalDiscount = new CheckBox();
            txtDiscount = new TextBox();
            txtNetDue = new TextBox();
            menuStrip1.SuspendLayout();
            tbLayoutMain.SuspendLayout();
            gbBookInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(772, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuBtnCalculate, menuBtnSummary, menuBtnClear, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // menuBtnCalculate
            // 
            menuBtnCalculate.Name = "menuBtnCalculate";
            menuBtnCalculate.Size = new Size(154, 26);
            menuBtnCalculate.Text = "Calculate";
            menuBtnCalculate.Click += menuBtnCalculate_Click;
            // 
            // menuBtnSummary
            // 
            menuBtnSummary.Name = "menuBtnSummary";
            menuBtnSummary.Size = new Size(154, 26);
            menuBtnSummary.Text = "Summary";
            menuBtnSummary.Click += menuBtnSummary_Click;
            // 
            // menuBtnClear
            // 
            menuBtnClear.Name = "menuBtnClear";
            menuBtnClear.Size = new Size(154, 26);
            menuBtnClear.Text = "Clear";
            menuBtnClear.Click += menuBtnClear_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(154, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tbLayoutMain
            // 
            tbLayoutMain.ColumnCount = 1;
            tbLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbLayoutMain.Controls.Add(gbBookInfo, 0, 0);
            tbLayoutMain.Dock = DockStyle.Fill;
            tbLayoutMain.Location = new Point(0, 28);
            tbLayoutMain.Margin = new Padding(4);
            tbLayoutMain.Name = "tbLayoutMain";
            tbLayoutMain.RowCount = 1;
            tbLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tbLayoutMain.Size = new Size(772, 495);
            tbLayoutMain.TabIndex = 1;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(tableLayoutPanel1);
            gbBookInfo.Dock = DockStyle.Fill;
            gbBookInfo.ForeColor = SystemColors.Highlight;
            gbBookInfo.Location = new Point(24, 24);
            gbBookInfo.Margin = new Padding(24);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(4);
            gbBookInfo.Size = new Size(724, 447);
            gbBookInfo.TabIndex = 0;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "Book Information";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(cbIsStudent, 1, 9);
            tableLayoutPanel1.Controls.Add(label2, 0, 10);
            tableLayoutPanel1.Controls.Add(lbDiscount, 0, 8);
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lbTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lbQuantity, 0, 2);
            tableLayoutPanel1.Controls.Add(txtQuantity, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 4);
            tableLayoutPanel1.Controls.Add(lbPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(lbTotal, 0, 6);
            tableLayoutPanel1.Controls.Add(txtExtendedPrice, 1, 6);
            tableLayoutPanel1.Controls.Add(cbIsNormalDiscount, 1, 7);
            tableLayoutPanel1.Controls.Add(txtDiscount, 1, 8);
            tableLayoutPanel1.Controls.Add(txtNetDue, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.ForeColor = SystemColors.WindowText;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(716, 415);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cbIsStudent
            // 
            cbIsStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbIsStudent.AutoSize = true;
            cbIsStudent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbIsStudent.Location = new Point(557, 329);
            cbIsStudent.Name = "cbIsStudent";
            cbIsStudent.Size = new Size(136, 20);
            cbIsStudent.TabIndex = 9;
            cbIsStudent.Text = "Distinct Student";
            cbIsStudent.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(23, 352);
            label2.Name = "label2";
            label2.Size = new Size(77, 40);
            label2.TabIndex = 11;
            label2.Text = "Net Due";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Dock = DockStyle.Left;
            lbDiscount.Location = new Point(23, 286);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(82, 40);
            lbDiscount.TabIndex = 9;
            lbDiscount.Text = "Discount";
            lbDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Top;
            txtTitle.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(226, 24);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(466, 34);
            txtTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Dock = DockStyle.Left;
            lbTitle.Location = new Point(24, 20);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(44, 42);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Dock = DockStyle.Left;
            lbQuantity.Location = new Point(23, 88);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(80, 40);
            lbQuantity.TabIndex = 2;
            lbQuantity.Text = "Quantity";
            lbQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Top;
            txtQuantity.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(225, 91);
            txtQuantity.Margin = new Padding(3, 3, 210, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(261, 34);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Top;
            txtPrice.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(225, 157);
            txtPrice.Margin = new Padding(3, 3, 210, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(261, 34);
            txtPrice.TabIndex = 4;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Dock = DockStyle.Left;
            lbPrice.Location = new Point(23, 154);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 40);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Dock = DockStyle.Left;
            lbTotal.Location = new Point(23, 220);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(127, 40);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Extended Price";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtExtendedPrice
            // 
            txtExtendedPrice.Dock = DockStyle.Top;
            txtExtendedPrice.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtendedPrice.Location = new Point(225, 223);
            txtExtendedPrice.Margin = new Padding(3, 3, 210, 3);
            txtExtendedPrice.Name = "txtExtendedPrice";
            txtExtendedPrice.ReadOnly = true;
            txtExtendedPrice.Size = new Size(261, 34);
            txtExtendedPrice.TabIndex = 7;
            // 
            // cbIsNormalDiscount
            // 
            cbIsNormalDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbIsNormalDiscount.AutoSize = true;
            cbIsNormalDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbIsNormalDiscount.Location = new Point(550, 263);
            cbIsNormalDiscount.Name = "cbIsNormalDiscount";
            cbIsNormalDiscount.Size = new Size(143, 20);
            cbIsNormalDiscount.TabIndex = 8;
            cbIsNormalDiscount.Text = "Normal Discount";
            cbIsNormalDiscount.UseVisualStyleBackColor = true;
            cbIsNormalDiscount.CheckedChanged += cbIsNormalDiscount_CheckedChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.Dock = DockStyle.Top;
            txtDiscount.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiscount.Location = new Point(225, 289);
            txtDiscount.Margin = new Padding(3, 3, 210, 3);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(261, 34);
            txtDiscount.TabIndex = 10;
            // 
            // txtNetDue
            // 
            txtNetDue.Dock = DockStyle.Top;
            txtNetDue.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNetDue.Location = new Point(225, 355);
            txtNetDue.Margin = new Padding(3, 3, 210, 3);
            txtNetDue.Name = "txtNetDue";
            txtNetDue.ReadOnly = true;
            txtNetDue.Size = new Size(261, 34);
            txtNetDue.TabIndex = 12;
            // 
            // BookSaleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(772, 523);
            Controls.Add(tbLayoutMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(790, 570);
            Name = "BookSaleForm";
            Text = "Book sales";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbLayoutMain.ResumeLayout(false);
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TableLayoutPanel tbLayoutMain;
        private GroupBox gbBookInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTitle;
        private Label lbTitle;
        private TextBox txtPrice;
        private Label lbPrice;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private Label lbTotal;
        private TextBox txtExtendedPrice;
        private ToolStripMenuItem menuBtnCalculate;
        private ToolStripMenuItem menuBtnClear;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuBtnSummary;
        private Label lbDiscount;
        private CheckBox cbIsNormalDiscount;
        private Label label2;
        private TextBox txtDiscount;
        private TextBox txtNetDue;
        private CheckBox cbIsStudent;
    }
}