namespace TestiriumWF
{
    partial class TestCreating
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
            this.lblProgrammTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonsContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWelcomeScreen = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.questionsContainerPanel = new System.Windows.Forms.Panel();
            this.welcomeScreenPanel1 = new TestiriumWF.WelcomeScreenPanel();
            this.panel1.SuspendLayout();
            this.buttonsContainerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.questionsContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProgrammTitle
            // 
            this.lblProgrammTitle.AutoSize = true;
            this.lblProgrammTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgrammTitle.ForeColor = System.Drawing.Color.White;
            this.lblProgrammTitle.Location = new System.Drawing.Point(12, 18);
            this.lblProgrammTitle.Name = "lblProgrammTitle";
            this.lblProgrammTitle.Size = new System.Drawing.Size(158, 42);
            this.lblProgrammTitle.TabIndex = 0;
            this.lblProgrammTitle.Text = "Тестириум";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.buttonsContainerPanel);
            this.panel1.Controls.Add(this.btnCreateQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 557);
            this.panel1.TabIndex = 2;
            // 
            // buttonsContainerPanel
            // 
            this.buttonsContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsContainerPanel.AutoScroll = true;
            this.buttonsContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonsContainerPanel.Controls.Add(this.btnWelcomeScreen);
            this.buttonsContainerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsContainerPanel.Location = new System.Drawing.Point(13, 85);
            this.buttonsContainerPanel.Name = "buttonsContainerPanel";
            this.buttonsContainerPanel.Padding = new System.Windows.Forms.Padding(15);
            this.buttonsContainerPanel.Size = new System.Drawing.Size(221, 452);
            this.buttonsContainerPanel.TabIndex = 2;
            this.buttonsContainerPanel.WrapContents = false;
            // 
            // btnWelcomeScreen
            // 
            this.btnWelcomeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnWelcomeScreen.FlatAppearance.BorderSize = 0;
            this.btnWelcomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcomeScreen.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWelcomeScreen.ForeColor = System.Drawing.Color.White;
            this.btnWelcomeScreen.Location = new System.Drawing.Point(18, 18);
            this.btnWelcomeScreen.Name = "btnWelcomeScreen";
            this.btnWelcomeScreen.Size = new System.Drawing.Size(174, 40);
            this.btnWelcomeScreen.TabIndex = 3;
            this.btnWelcomeScreen.Text = "Титульный экран";
            this.btnWelcomeScreen.UseVisualStyleBackColor = false;
            this.btnWelcomeScreen.Click += new System.EventHandler(this.btnWelcomeScreen_Click);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCreateQuestion.FlatAppearance.BorderSize = 0;
            this.btnCreateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQuestion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateQuestion.ForeColor = System.Drawing.Color.White;
            this.btnCreateQuestion.Location = new System.Drawing.Point(12, 19);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Size = new System.Drawing.Size(222, 50);
            this.btnCreateQuestion.TabIndex = 1;
            this.btnCreateQuestion.Text = "Добавить вопрос";
            this.btnCreateQuestion.UseVisualStyleBackColor = false;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.lblProgrammTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 77);
            this.panel2.TabIndex = 3;
            // 
            // questionsContainerPanel
            // 
            this.questionsContainerPanel.Controls.Add(this.welcomeScreenPanel1);
            this.questionsContainerPanel.Location = new System.Drawing.Point(246, 77);
            this.questionsContainerPanel.Name = "questionsContainerPanel";
            this.questionsContainerPanel.Size = new System.Drawing.Size(838, 554);
            this.questionsContainerPanel.TabIndex = 4;
            // 
            // welcomeScreenPanel1
            // 
            this.welcomeScreenPanel1.Location = new System.Drawing.Point(18, 18);
            this.welcomeScreenPanel1.Name = "welcomeScreenPanel1";
            this.welcomeScreenPanel1.Size = new System.Drawing.Size(800, 520);
            this.welcomeScreenPanel1.TabIndex = 0;
            // 
            // TestCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1084, 632);
            this.Controls.Add(this.questionsContainerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCreating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestCreating";
            this.panel1.ResumeLayout(false);
            this.buttonsContainerPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.questionsContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProgrammTitle;
        private System.Windows.Forms.Button btnCreateQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWelcomeScreen;
        private System.Windows.Forms.FlowLayoutPanel buttonsContainerPanel;
        private System.Windows.Forms.Panel questionsContainerPanel;
        private WelcomeScreenPanel welcomeScreenPanel1;
    }
}