namespace lab_2_3
{
    partial class frmFlightReservationDetails
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
            tbPanel = new TableLayoutPanel();
            tbLayoutForm = new TableLayoutPanel();
            label1 = new Label();
            txtTickerNumber = new TextBox();
            lbYears = new Label();
            txtPassengerName = new TextBox();
            txtPassportNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstBoxSource = new ListBox();
            lstBoxDestination = new ListBox();
            dpkerFightDate = new DateTimePicker();
            label5 = new Label();
            cbFlightClass = new ComboBox();
            label6 = new Label();
            chkListServices = new CheckedListBox();
            label7 = new Label();
            tbLayoutBtns = new TableLayoutPanel();
            btnClear = new Button();
            btnVeritfy = new Button();
            tableLayoutPanel1.SuspendLayout();
            tbPanel.SuspendLayout();
            tbLayoutForm.SuspendLayout();
            tbLayoutBtns.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(607, 919);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbHeading
            // 
            lbHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbHeading.Location = new Point(3, 0);
            lbHeading.Name = "lbHeading";
            lbHeading.Size = new Size(601, 89);
            lbHeading.TabIndex = 0;
            lbHeading.Text = "Filght Reservation Details";
            lbHeading.TextAlign = ContentAlignment.MiddleCenter;
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
            tbPanel.Size = new Size(601, 824);
            tbPanel.TabIndex = 1;
            // 
            // tbLayoutForm
            // 
            tbLayoutForm.ColumnCount = 2;
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tbLayoutForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tbLayoutForm.Controls.Add(label1, 0, 0);
            tbLayoutForm.Controls.Add(txtTickerNumber, 1, 0);
            tbLayoutForm.Controls.Add(lbYears, 0, 2);
            tbLayoutForm.Controls.Add(txtPassengerName, 1, 2);
            tbLayoutForm.Controls.Add(txtPassportNumber, 1, 4);
            tbLayoutForm.Controls.Add(label2, 0, 4);
            tbLayoutForm.Controls.Add(label3, 0, 6);
            tbLayoutForm.Controls.Add(label4, 0, 8);
            tbLayoutForm.Controls.Add(lstBoxSource, 1, 6);
            tbLayoutForm.Controls.Add(lstBoxDestination, 1, 8);
            tbLayoutForm.Controls.Add(dpkerFightDate, 1, 10);
            tbLayoutForm.Controls.Add(label5, 0, 10);
            tbLayoutForm.Controls.Add(cbFlightClass, 1, 12);
            tbLayoutForm.Controls.Add(label6, 0, 12);
            tbLayoutForm.Controls.Add(chkListServices, 1, 14);
            tbLayoutForm.Controls.Add(label7, 0, 14);
            tbLayoutForm.Dock = DockStyle.Fill;
            tbLayoutForm.Location = new Point(40, 3);
            tbLayoutForm.Margin = new Padding(40, 3, 40, 3);
            tbLayoutForm.Name = "tbLayoutForm";
            tbLayoutForm.RowCount = 15;
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbLayoutForm.RowStyles.Add(new RowStyle());
            tbLayoutForm.Size = new Size(521, 680);
            tbLayoutForm.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 0;
            label1.Text = "Ticket Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTickerNumber
            // 
            txtTickerNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTickerNumber.Location = new Point(159, 3);
            txtTickerNumber.Name = "txtTickerNumber";
            txtTickerNumber.Size = new Size(289, 30);
            txtTickerNumber.TabIndex = 1;
            // 
            // lbYears
            // 
            lbYears.AutoSize = true;
            lbYears.Location = new Point(3, 56);
            lbYears.Name = "lbYears";
            lbYears.Size = new Size(137, 23);
            lbYears.TabIndex = 2;
            lbYears.Text = "Passenger Name";
            lbYears.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassengerName
            // 
            txtPassengerName.Dock = DockStyle.Fill;
            txtPassengerName.Location = new Point(159, 59);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(359, 30);
            txtPassengerName.TabIndex = 3;
            // 
            // txtPassportNumber
            // 
            txtPassportNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassportNumber.Location = new Point(159, 115);
            txtPassportNumber.Name = "txtPassportNumber";
            txtPassportNumber.Size = new Size(289, 30);
            txtPassportNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Passport number";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 168);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "Source";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 313);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 2;
            label4.Text = "Destination";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstBoxSource
            // 
            lstBoxSource.FormattingEnabled = true;
            lstBoxSource.ItemHeight = 23;
            lstBoxSource.Items.AddRange(new object[] { "Ho Chi Minh City (SGN)", "Hanoi (HAN)", "Da Nang (DAD)", "Nha Trang (CXR)", "Gaza Strip(Palestine)", "New York (JFK, LGA, EWR)", "Los Angeles (LAX)" });
            lstBoxSource.Location = new Point(159, 171);
            lstBoxSource.Name = "lstBoxSource";
            lstBoxSource.SelectionMode = SelectionMode.MultiSimple;
            lstBoxSource.Size = new Size(289, 119);
            lstBoxSource.TabIndex = 4;
            // 
            // lstBoxDestination
            // 
            lstBoxDestination.FormattingEnabled = true;
            lstBoxDestination.ItemHeight = 23;
            lstBoxDestination.Items.AddRange(new object[] { "Ho Chi Minh City (SGN)", "Hanoi (HAN)", "Da Nang (DAD)", "Nha Trang (CXR)", "Gaza Strip(Palestine)", "New York (JFK, LGA, EWR)", "Los Angeles (LAX)" });
            lstBoxDestination.Location = new Point(159, 316);
            lstBoxDestination.Name = "lstBoxDestination";
            lstBoxDestination.SelectionMode = SelectionMode.MultiSimple;
            lstBoxDestination.Size = new Size(289, 119);
            lstBoxDestination.TabIndex = 4;
            // 
            // dpkerFightDate
            // 
            dpkerFightDate.CustomFormat = "dd/MM/yyyy";
            dpkerFightDate.Format = DateTimePickerFormat.Custom;
            dpkerFightDate.Location = new Point(159, 461);
            dpkerFightDate.Name = "dpkerFightDate";
            dpkerFightDate.RightToLeftLayout = true;
            dpkerFightDate.Size = new Size(289, 30);
            dpkerFightDate.TabIndex = 13;
            dpkerFightDate.Value = new DateTime(2023, 12, 28, 11, 59, 38, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 458);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 2;
            label5.Text = "Fight Date";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbFlightClass
            // 
            cbFlightClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlightClass.FormattingEnabled = true;
            cbFlightClass.Items.AddRange(new object[] { "Spectrum Airline", "Economy", "Business", "First Class" });
            cbFlightClass.Location = new Point(159, 517);
            cbFlightClass.Name = "cbFlightClass";
            cbFlightClass.Size = new Size(289, 31);
            cbFlightClass.TabIndex = 14;
            cbFlightClass.SelectedIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 514);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 2;
            label6.Text = "Class";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkListServices
            // 
            chkListServices.FormattingEnabled = true;
            chkListServices.Items.AddRange(new object[] { "Window Seat", "Aisle Seat", "Extra Legroom Seat", "Preferred Seating (specific seat number/location)", "Standard Meal", "Vegetarian Meal", "In-Flight Entertainment (movies, TV shows, music)", "Wi-Fi Access", "Blanket and Pillow", "Travel Kit (earplugs, eye mask, toothbrush)" });
            chkListServices.Location = new Point(159, 574);
            chkListServices.Name = "chkListServices";
            chkListServices.Size = new Size(289, 104);
            chkListServices.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 571);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 2;
            label7.Text = "Services";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbLayoutBtns
            // 
            tbLayoutBtns.ColumnCount = 4;
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbLayoutBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tbLayoutBtns.Controls.Add(btnClear, 2, 1);
            tbLayoutBtns.Controls.Add(btnVeritfy, 1, 1);
            tbLayoutBtns.Dock = DockStyle.Fill;
            tbLayoutBtns.Location = new Point(3, 689);
            tbLayoutBtns.Name = "tbLayoutBtns";
            tbLayoutBtns.RowCount = 3;
            tbLayoutBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayoutBtns.RowStyles.Add(new RowStyle());
            tbLayoutBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbLayoutBtns.Size = new Size(595, 132);
            tbLayoutBtns.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Dock = DockStyle.Top;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(307, 46);
            btnClear.Margin = new Padding(10, 3, 10, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(177, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnVeritfy
            // 
            btnVeritfy.AutoSize = true;
            btnVeritfy.Dock = DockStyle.Top;
            btnVeritfy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVeritfy.Location = new Point(110, 46);
            btnVeritfy.Margin = new Padding(10, 3, 10, 3);
            btnVeritfy.Name = "btnVeritfy";
            btnVeritfy.Size = new Size(177, 40);
            btnVeritfy.TabIndex = 0;
            btnVeritfy.Text = "Veritfy";
            btnVeritfy.UseVisualStyleBackColor = true;
            btnVeritfy.Click += btnVeritfy_Click;
            // 
            // frmFlightReservationDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 919);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(625, 635);
            Name = "frmFlightReservationDetails";
            Text = "Filght Reservation Details";
            tableLayoutPanel1.ResumeLayout(false);
            tbPanel.ResumeLayout(false);
            tbLayoutForm.ResumeLayout(false);
            tbLayoutForm.PerformLayout();
            tbLayoutBtns.ResumeLayout(false);
            tbLayoutBtns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbHeading;
        private TableLayoutPanel tbPanel;
        private TableLayoutPanel tbLayoutForm;
        private Label label1;
        private TextBox txtTickerNumber;
        private Label lbYears;
        private TableLayoutPanel tbLayoutBtns;
        private Button btnClear;
        private Button btnVeritfy;
        private TextBox txtPassengerName;
        private TextBox txtPassportNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstBoxSource;
        private ListBox lstBoxDestination;
        private DateTimePicker dpkerFightDate;
        private Label label5;
        private ComboBox cbFlightClass;
        private Label label6;
        private CheckedListBox chkListServices;
        private Label label7;
    }
}