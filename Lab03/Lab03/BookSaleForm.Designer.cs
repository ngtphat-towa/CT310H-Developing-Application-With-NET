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
            menuBtnClear = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tbLayoutMain = new TableLayoutPanel();
            gbBookInfo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTitle = new TextBox();
            lbTitle = new Label();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            lbPrice = new Label();
            lbTotal = new Label();
            txtTotal = new TextBox();
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
            menuStrip1.Size = new Size(702, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuBtnCalculate, menuBtnClear, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // menuBtnCalculate
            // 
            menuBtnCalculate.Name = "menuBtnCalculate";
            menuBtnCalculate.Size = new Size(224, 26);
            menuBtnCalculate.Text = "Calculate";
            menuBtnCalculate.Click += menuBtnCalculate_Click;
            // 
            // menuBtnClear
            // 
            menuBtnClear.Name = "menuBtnClear";
            menuBtnClear.Size = new Size(224, 26);
            menuBtnClear.Text = "Clear";
            menuBtnClear.Click += menuBtnClear_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
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
            tbLayoutMain.Size = new Size(702, 325);
            tbLayoutMain.TabIndex = 1;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(tableLayoutPanel1);
            gbBookInfo.Dock = DockStyle.Fill;
            gbBookInfo.ForeColor = SystemColors.Highlight;
            gbBookInfo.Location = new Point(20, 20);
            gbBookInfo.Margin = new Padding(20);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(4);
            gbBookInfo.Size = new Size(662, 285);
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
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lbTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lbQuantity, 0, 2);
            tableLayoutPanel1.Controls.Add(txtQuantity, 1, 2);
            tableLayoutPanel1.Controls.Add(txtPrice, 1, 4);
            tableLayoutPanel1.Controls.Add(lbPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(lbTotal, 0, 6);
            tableLayoutPanel1.Controls.Add(txtTotal, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.ForeColor = SystemColors.WindowText;
            tableLayoutPanel1.Location = new Point(4, 28);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(654, 253);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Top;
            txtTitle.Location = new Point(208, 24);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(422, 31);
            txtTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Dock = DockStyle.Left;
            lbTitle.Location = new Point(24, 20);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(44, 39);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Dock = DockStyle.Left;
            lbQuantity.Location = new Point(23, 80);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(80, 37);
            lbQuantity.TabIndex = 2;
            lbQuantity.Text = "Quantity";
            lbQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(207, 83);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(290, 31);
            txtQuantity.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(207, 141);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(290, 31);
            txtPrice.TabIndex = 4;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Dock = DockStyle.Left;
            lbPrice.Location = new Point(23, 138);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 37);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            lbPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Dock = DockStyle.Left;
            lbTotal.Location = new Point(23, 196);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(91, 37);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Total Price";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(207, 199);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(290, 31);
            txtTotal.TabIndex = 7;
            // 
            // BookSaleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(702, 353);
            Controls.Add(tbLayoutMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(720, 400);
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
        private TextBox txtTotal;
        private ToolStripMenuItem menuBtnCalculate;
        private ToolStripMenuItem menuBtnClear;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}