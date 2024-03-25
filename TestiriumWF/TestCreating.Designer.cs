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
            this.panel2 = new System.Windows.Forms.Panel();
            this.questionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWelcomeScreen = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.btnOneQuestionAnswer = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.welcomeScreenPanel1 = new TestiriumWF.WelcomeScreenPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.questionsFlowLayoutPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
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
            this.panel1.Controls.Add(this.questionsFlowLayoutPanel);
            this.panel1.Controls.Add(this.btnCreateQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 557);
            this.panel1.TabIndex = 2;
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
            // questionsFlowLayoutPanel
            // 
            this.questionsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsFlowLayoutPanel.AutoScroll = true;
            this.questionsFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.questionsFlowLayoutPanel.Controls.Add(this.btnWelcomeScreen);
            this.questionsFlowLayoutPanel.Controls.Add(this.btnOneQuestionAnswer);
            this.questionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionsFlowLayoutPanel.Location = new System.Drawing.Point(13, 85);
            this.questionsFlowLayoutPanel.Name = "questionsFlowLayoutPanel";
            this.questionsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.questionsFlowLayoutPanel.Size = new System.Drawing.Size(221, 452);
            this.questionsFlowLayoutPanel.TabIndex = 2;
            this.questionsFlowLayoutPanel.WrapContents = false;
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
            this.btnWelcomeScreen.Size = new System.Drawing.Size(165, 40);
            this.btnWelcomeScreen.TabIndex = 3;
            this.btnWelcomeScreen.Text = "Титульный экран";
            this.btnWelcomeScreen.UseVisualStyleBackColor = false;
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
            // btnOneQuestionAnswer
            // 
            this.btnOneQuestionAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnOneQuestionAnswer.FlatAppearance.BorderSize = 0;
            this.btnOneQuestionAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneQuestionAnswer.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOneQuestionAnswer.ForeColor = System.Drawing.Color.White;
            this.btnOneQuestionAnswer.Location = new System.Drawing.Point(18, 64);
            this.btnOneQuestionAnswer.Name = "btnOneQuestionAnswer";
            this.btnOneQuestionAnswer.Size = new System.Drawing.Size(165, 40);
            this.btnOneQuestionAnswer.TabIndex = 4;
            this.btnOneQuestionAnswer.Text = "Вопрос с одним ответом";
            this.btnOneQuestionAnswer.UseVisualStyleBackColor = false;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.welcomeScreenPanel1);
            this.containerPanel.Location = new System.Drawing.Point(246, 77);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(838, 554);
            this.containerPanel.TabIndex = 4;
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
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCreating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestCreating";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.questionsFlowLayoutPanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProgrammTitle;
        private System.Windows.Forms.Button btnCreateQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWelcomeScreen;
        private System.Windows.Forms.FlowLayoutPanel questionsFlowLayoutPanel;
        private System.Windows.Forms.Button btnOneQuestionAnswer;
        private System.Windows.Forms.Panel containerPanel;
        private WelcomeScreenPanel welcomeScreenPanel1;
    }
}