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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            manageDepartmentToolStripMenuItem = new ToolStripMenuItem();
            manageSubjectToolStripMenuItem = new ToolStripMenuItem();
            mangeScoreToolStripMenuItem = new ToolStripMenuItem();
            manageStudentToolStripMenuItem = new ToolStripMenuItem();
            manageIntructorToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            manageClassToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, manageDepartmentToolStripMenuItem, manageClassToolStripMenuItem, manageSubjectToolStripMenuItem, mangeScoreToolStripMenuItem, manageStudentToolStripMenuItem, manageIntructorToolStripMenuItem, logOutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // manageDepartmentToolStripMenuItem
            // 
            manageDepartmentToolStripMenuItem.Name = "manageDepartmentToolStripMenuItem";
            manageDepartmentToolStripMenuItem.Size = new Size(161, 24);
            manageDepartmentToolStripMenuItem.Text = "Manage Department";
            manageDepartmentToolStripMenuItem.Click += manageDepartmentToolStripMenuItem_Click;
            // 
            // manageSubjectToolStripMenuItem
            // 
            manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            manageSubjectToolStripMenuItem.Size = new Size(130, 24);
            manageSubjectToolStripMenuItem.Text = "Manage Subject";
            // 
            // mangeScoreToolStripMenuItem
            // 
            mangeScoreToolStripMenuItem.Name = "mangeScoreToolStripMenuItem";
            mangeScoreToolStripMenuItem.Size = new Size(110, 24);
            mangeScoreToolStripMenuItem.Text = "Mange Score";
            // 
            // manageStudentToolStripMenuItem
            // 
            manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            manageStudentToolStripMenuItem.Size = new Size(132, 24);
            manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // manageIntructorToolStripMenuItem
            // 
            manageIntructorToolStripMenuItem.Name = "manageIntructorToolStripMenuItem";
            manageIntructorToolStripMenuItem.Size = new Size(137, 24);
            manageIntructorToolStripMenuItem.Text = "Manage Intructor";
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(74, 24);
            logOutToolStripMenuItem1.Text = "Log out";
            logOutToolStripMenuItem1.Click += logOutToolStripMenuItem1_Click_1;
            // 
            // manageClassToolStripMenuItem
            // 
            manageClassToolStripMenuItem.Name = "manageClassToolStripMenuItem";
            manageClassToolStripMenuItem.Size = new Size(114, 24);
            manageClassToolStripMenuItem.Text = "Manage Class";
            manageClassToolStripMenuItem.Click += manageClassToolStripMenuItem_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "GradeManagementForm";
            FormClosing += DashboardForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem logoutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem manageDepartmentToolStripMenuItem;
        private ToolStripMenuItem manageSubjectToolStripMenuItem;
        private ToolStripMenuItem mangeScoreToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
        private ToolStripMenuItem manageIntructorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem manageClassToolStripMenuItem;
    }
}