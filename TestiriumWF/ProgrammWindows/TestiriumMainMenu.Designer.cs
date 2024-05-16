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
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.promptsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.containerPanel = new System.Windows.Forms.Panel();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTests = new System.Windows.Forms.Button();
            this.userBoxPanel = new TestiriumWF.CustomPanels.UserBoxPanel();
            this.popUserPanel = new TestiriumWF.CustomPanels.PopUserPanel();
            this.topPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
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
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
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
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.optionsPanel.Controls.Add(this.btnReviews);
            this.optionsPanel.Controls.Add(this.btnUsers);
            this.optionsPanel.Controls.Add(this.btnTests);
            this.optionsPanel.Location = new System.Drawing.Point(0, 72);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(64, 528);
            this.optionsPanel.TabIndex = 5;
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.containerPanel.Controls.Add(this.popUserPanel);
            this.containerPanel.Location = new System.Drawing.Point(64, 72);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1000, 528);
            this.containerPanel.TabIndex = 7;
            this.containerPanel.Click += new System.EventHandler(this.containerPanel_Click);
            this.containerPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.containerPanel_ControlAdded);
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
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
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
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // userBoxPanel
            // 
            this.userBoxPanel.Location = new System.Drawing.Point(696, 8);
            this.userBoxPanel.Name = "userBoxPanel";
            this.userBoxPanel.Size = new System.Drawing.Size(358, 56);
            this.userBoxPanel.TabIndex = 1;
            // 
            // popUserPanel
            // 
            this.popUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.popUserPanel.Location = new System.Drawing.Point(632, 8);
            this.popUserPanel.Name = "popUserPanel";
            this.popUserPanel.Size = new System.Drawing.Size(360, 144);
            this.popUserPanel.TabIndex = 0;
            this.popUserPanel.Visible = false;
            // 
            // TestiriumMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.containerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestiriumMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.TestiriumMainMenu_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Panel topPanel;
        private CustomPanels.UserBoxPanel userBoxPanel;
        private System.Windows.Forms.Label lblProgrammTitle;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.ToolTip promptsToolTip;
        private System.Windows.Forms.Panel containerPanel;
        private CustomPanels.PopUserPanel popUserPanel;
    }
}