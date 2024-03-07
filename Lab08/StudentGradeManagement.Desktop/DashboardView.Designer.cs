namespace StudentGradeManagement.Desktop
{
    partial class DashboardForm
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
            logoutToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            manageSubjectToolStripMenuItem = new ToolStripMenuItem();
            mangeScoreToolStripMenuItem = new ToolStripMenuItem();
            manageStudentToolStripMenuItem = new ToolStripMenuItem();
            manageIntructorToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            mainPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(menuStrip1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1262, 673);
            mainPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, manageSubjectToolStripMenuItem, mangeScoreToolStripMenuItem, manageStudentToolStripMenuItem, manageIntructorToolStripMenuItem, logOutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // manageSubjectToolStripMenuItem
            // 
            manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            manageSubjectToolStripMenuItem.Size = new Size(130, 24);
            manageSubjectToolStripMenuItem.Text = "Manage Subject";
            manageSubjectToolStripMenuItem.Click += manageSubjectToolStripMenuItem_Click;
            // 
            // mangeScoreToolStripMenuItem
            // 
            mangeScoreToolStripMenuItem.Name = "mangeScoreToolStripMenuItem";
            mangeScoreToolStripMenuItem.Size = new Size(110, 24);
            mangeScoreToolStripMenuItem.Text = "Mange Score";
            mangeScoreToolStripMenuItem.Click += mangeScoreToolStripMenuItem_Click;
            // 
            // manageStudentToolStripMenuItem
            // 
            manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            manageStudentToolStripMenuItem.Size = new Size(132, 24);
            manageStudentToolStripMenuItem.Text = "Manage Student";
            manageStudentToolStripMenuItem.Click += manageStudentToolStripMenuItem_Click;
            // 
            // manageIntructorToolStripMenuItem
            // 
            manageIntructorToolStripMenuItem.Name = "manageIntructorToolStripMenuItem";
            manageIntructorToolStripMenuItem.Size = new Size(137, 24);
            manageIntructorToolStripMenuItem.Text = "Manage Intructor";
            manageIntructorToolStripMenuItem.Click += manageIntructorToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(74, 24);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "GradeManagementForm";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel mainPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem manageSubjectToolStripMenuItem;
        private ToolStripMenuItem mangeScoreToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
        private ToolStripMenuItem manageIntructorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
    }
}