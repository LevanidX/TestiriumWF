﻿namespace TestiriumWF.CustomPanels
{
    partial class TestCreatingControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEndCreation = new System.Windows.Forms.Button();
            this.buttonsContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWelcomeScreen = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.questionsContainerPanel = new System.Windows.Forms.Panel();
            this.welcomeScreenPanel = new TestiriumWF.WelcomeScreenPanel();
            this.panel1.SuspendLayout();
            this.buttonsContainerPanel.SuspendLayout();
            this.questionsContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnEndCreation);
            this.panel1.Controls.Add(this.btnDeleteQuestion);
            this.panel1.Controls.Add(this.buttonsContainerPanel);
            this.panel1.Controls.Add(this.btnCreateQuestion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 528);
            this.panel1.TabIndex = 3;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDeleteQuestion.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(8, 56);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(168, 40);
            this.btnDeleteQuestion.TabIndex = 4;
            this.btnDeleteQuestion.Text = "Удалить вопрос";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnEndCreation
            // 
            this.btnEndCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEndCreation.FlatAppearance.BorderSize = 0;
            this.btnEndCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCreation.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndCreation.ForeColor = System.Drawing.Color.White;
            this.btnEndCreation.Location = new System.Drawing.Point(8, 480);
            this.btnEndCreation.Name = "btnEndCreation";
            this.btnEndCreation.Size = new System.Drawing.Size(168, 40);
            this.btnEndCreation.TabIndex = 3;
            this.btnEndCreation.Text = "Завершить создание";
            this.btnEndCreation.UseVisualStyleBackColor = false;
            this.btnEndCreation.Click += new System.EventHandler(this.btnEndCreation_Click);
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
            this.buttonsContainerPanel.Location = new System.Drawing.Point(8, 104);
            this.buttonsContainerPanel.Name = "buttonsContainerPanel";
            this.buttonsContainerPanel.Padding = new System.Windows.Forms.Padding(15);
            this.buttonsContainerPanel.Size = new System.Drawing.Size(168, 368);
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
            this.btnWelcomeScreen.Size = new System.Drawing.Size(134, 40);
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
            this.btnCreateQuestion.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateQuestion.ForeColor = System.Drawing.Color.White;
            this.btnCreateQuestion.Location = new System.Drawing.Point(8, 8);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Size = new System.Drawing.Size(168, 40);
            this.btnCreateQuestion.TabIndex = 1;
            this.btnCreateQuestion.Text = "Добавить вопрос";
            this.btnCreateQuestion.UseVisualStyleBackColor = false;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // questionsContainerPanel
            // 
            this.questionsContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.questionsContainerPanel.Controls.Add(this.welcomeScreenPanel);
            this.questionsContainerPanel.Location = new System.Drawing.Point(184, 0);
            this.questionsContainerPanel.Name = "questionsContainerPanel";
            this.questionsContainerPanel.Size = new System.Drawing.Size(816, 528);
            this.questionsContainerPanel.TabIndex = 5;
            // 
            // welcomeScreenPanel
            // 
            this.welcomeScreenPanel.Location = new System.Drawing.Point(16, 16);
            this.welcomeScreenPanel.Name = "welcomeScreenPanel";
            this.welcomeScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.welcomeScreenPanel.TabIndex = 0;
            // 
            // TestCreatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionsContainerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "TestCreatingControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.panel1.ResumeLayout(false);
            this.buttonsContainerPanel.ResumeLayout(false);
            this.questionsContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnEndCreation;
        private System.Windows.Forms.FlowLayoutPanel buttonsContainerPanel;
        private System.Windows.Forms.Button btnWelcomeScreen;
        private System.Windows.Forms.Button btnCreateQuestion;
        private System.Windows.Forms.Panel questionsContainerPanel;
        private WelcomeScreenPanel welcomeScreenPanel;
    }
}
