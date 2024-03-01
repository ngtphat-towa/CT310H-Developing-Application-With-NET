namespace StudentGradeManagement.Desktop
{
    partial class LoginForm
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
            tbMain = new TableLayoutPanel();
            lbHeading = new Label();
            tbLoginForm = new TableLayoutPanel();
            txtInstructorId = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLogin = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            tbMain.SuspendLayout();
            tbLoginForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMain.ColumnCount = 2;
            tbMain.ColumnStyles.Add(new ColumnStyle());
            tbMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tbMain.Controls.Add(lbHeading, 0, 0);
            tbMain.Controls.Add(tbLoginForm, 1, 1);
            tbMain.Controls.Add(pictureBox1, 0, 1);
            tbMain.Location = new Point(30, 0);
            tbMain.Margin = new Padding(30, 0, 30, 0);
            tbMain.Name = "tbMain";
            tbMain.RowCount = 2;
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4549351F));
            tbMain.RowStyles.Add(new RowStyle(SizeType.Percent, 81.54507F));
            tbMain.Size = new Size(563, 233);
            tbMain.TabIndex = 0;
            // 
            // lbHeading
            // 
            lbHeading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMain.SetColumnSpan(lbHeading, 2);
            lbHeading.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeading.ImageAlign = ContentAlignment.TopCenter;
            lbHeading.Location = new Point(3, 0);
            lbHeading.Name = "lbHeading";
            lbHeading.Size = new Size(557, 43);
            lbHeading.TabIndex = 0;
            lbHeading.Text = "Login Form";
            // 
            // tbLoginForm
            // 
            tbLoginForm.ColumnCount = 2;
            tbLoginForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1804F));
            tbLoginForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.8195953F));
            tbLoginForm.Controls.Add(txtInstructorId, 1, 0);
            tbLoginForm.Controls.Add(txtPassword, 1, 1);
            tbLoginForm.Controls.Add(label1, 0, 0);
            tbLoginForm.Controls.Add(label2, 0, 1);
            tbLoginForm.Controls.Add(tableLayoutPanel1, 1, 2);
            tbLoginForm.Dock = DockStyle.Fill;
            tbLoginForm.Location = new Point(134, 46);
            tbLoginForm.Name = "tbLoginForm";
            tbLoginForm.RowCount = 3;
            tbLoginForm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLoginForm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLoginForm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tbLoginForm.Size = new Size(426, 184);
            tbLoginForm.TabIndex = 1;
            // 
            // txtInstructorId
            // 
            txtInstructorId.Dock = DockStyle.Top;
            txtInstructorId.Location = new Point(135, 3);
            txtInstructorId.Name = "txtInstructorId";
            txtInstructorId.Size = new Size(288, 34);
            txtInstructorId.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(135, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(288, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 2;
            label1.Text = "InstructoreID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(135, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(288, 56);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.Location = new Point(156, 0);
            btnLogin.Margin = new Padding(12, 0, 12, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 44);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Top;
            btnClear.Location = new Point(12, 0);
            btnClear.Margin = new Padding(12, 0, 12, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 44);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 184);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 233);
            Controls.Add(tbMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(650, 280);
            MinimumSize = new Size(650, 280);
            Name = "LoginForm";
            Text = "Authentication";
            tbMain.ResumeLayout(false);
            tbLoginForm.ResumeLayout(false);
            tbLoginForm.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tbMain;
        private Label lbHeading;
        private TableLayoutPanel tbLoginForm;
        private TextBox txtInstructorId;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLogin;
        private Button btnClear;
        private PictureBox pictureBox1;
    }
}
