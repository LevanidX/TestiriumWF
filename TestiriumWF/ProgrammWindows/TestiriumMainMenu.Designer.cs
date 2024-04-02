namespace TestiriumWF.ProgrammWindows
{
    partial class TestiriumMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblProgrammTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.btnTests = new System.Windows.Forms.Button();
            this.promptsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.coursesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTests = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userBoxPanel = new TestiriumWF.CustomPanels.UserBoxPanel();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.coursesFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.topPanel.Controls.Add(this.userBoxPanel);
            this.topPanel.Controls.Add(this.lblProgrammTitle);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1064, 72);
            this.topPanel.TabIndex = 4;
            // 
            // lblProgrammTitle
            // 
            this.lblProgrammTitle.AutoSize = true;
            this.lblProgrammTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgrammTitle.ForeColor = System.Drawing.Color.White;
            this.lblProgrammTitle.Location = new System.Drawing.Point(16, 16);
            this.lblProgrammTitle.Name = "lblProgrammTitle";
            this.lblProgrammTitle.Size = new System.Drawing.Size(158, 42);
            this.lblProgrammTitle.TabIndex = 0;
            this.lblProgrammTitle.Text = "Тестириум";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnReviews);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnExitProgramm);
            this.panel1.Controls.Add(this.btnTests);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 528);
            this.panel1.TabIndex = 5;
            // 
            // btnReviews
            // 
            this.btnReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnReviews.BackgroundImage = global::TestiriumWF.Properties.Resources.statistic;
            this.btnReviews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Location = new System.Drawing.Point(8, 120);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(48, 48);
            this.btnReviews.TabIndex = 4;
            this.promptsToolTip.SetToolTip(this.btnReviews, "Отчеты");
            this.btnReviews.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnUsers.BackgroundImage = global::TestiriumWF.Properties.Resources.user_group;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(8, 64);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(48, 48);
            this.btnUsers.TabIndex = 3;
            this.promptsToolTip.SetToolTip(this.btnUsers, "Пользователи");
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnExitProgramm.BackgroundImage = global::TestiriumWF.Properties.Resources.delete;
            this.btnExitProgramm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitProgramm.FlatAppearance.BorderSize = 0;
            this.btnExitProgramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgramm.Location = new System.Drawing.Point(8, 472);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(48, 48);
            this.btnExitProgramm.TabIndex = 2;
            this.promptsToolTip.SetToolTip(this.btnExitProgramm, "Выход из программы");
            this.btnExitProgramm.UseVisualStyleBackColor = false;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // btnTests
            // 
            this.btnTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnTests.BackgroundImage = global::TestiriumWF.Properties.Resources.exam;
            this.btnTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTests.FlatAppearance.BorderSize = 0;
            this.btnTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTests.Location = new System.Drawing.Point(8, 8);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(48, 48);
            this.btnTests.TabIndex = 1;
            this.promptsToolTip.SetToolTip(this.btnTests, "Тестирования");
            this.btnTests.UseVisualStyleBackColor = false;
            this.btnTests.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.coursesFlowLayoutPanel);
            this.panel2.Controls.Add(this.lblTests);
            this.panel2.Location = new System.Drawing.Point(64, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 528);
            this.panel2.TabIndex = 6;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCourse.Location = new System.Drawing.Point(8, 472);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(184, 48);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Добавить предмет";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // coursesFlowLayoutPanel
            // 
            this.coursesFlowLayoutPanel.Controls.Add(this.linkLabel1);
            this.coursesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.coursesFlowLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            this.coursesFlowLayoutPanel.Size = new System.Drawing.Size(184, 424);
            this.coursesFlowLayoutPanel.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Алгебра";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTests.Location = new System.Drawing.Point(8, 8);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(143, 25);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Ваши предметы";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel3.Location = new System.Drawing.Point(264, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 528);
            this.panel3.TabIndex = 7;
            // 
            // userBoxPanel
            // 
            this.userBoxPanel.Location = new System.Drawing.Point(696, 8);
            this.userBoxPanel.Name = "userBoxPanel";
            this.userBoxPanel.Size = new System.Drawing.Size(358, 56);
            this.userBoxPanel.TabIndex = 1;
            // 
            // TestiriumMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestiriumMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.TestiriumMainMenu_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.coursesFlowLayoutPanel.ResumeLayout(false);
            this.coursesFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Panel topPanel;
        private CustomPanels.UserBoxPanel userBoxPanel;
        private System.Windows.Forms.Label lblProgrammTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExitProgramm;
        private System.Windows.Forms.ToolTip promptsToolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel coursesFlowLayoutPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAddCourse;
    }
}