namespace TestiriumWF.CustomPanels
{
    partial class TestCompletingControl
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
            this.questionsContainerPanel = new System.Windows.Forms.Panel();
            this.testWelcomeScreen = new TestiriumWF.CustomPanels.DeserializedQuestionPanels.TestWelcomeScreen();
            this.allCoursesPanel = new System.Windows.Forms.Panel();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.questionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTests = new System.Windows.Forms.Label();
            this.questionsContainerPanel.SuspendLayout();
            this.allCoursesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionsContainerPanel
            // 
            this.questionsContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.questionsContainerPanel.Controls.Add(this.testWelcomeScreen);
            this.questionsContainerPanel.Location = new System.Drawing.Point(184, 0);
            this.questionsContainerPanel.Name = "questionsContainerPanel";
            this.questionsContainerPanel.Size = new System.Drawing.Size(816, 528);
            this.questionsContainerPanel.TabIndex = 7;
            // 
            // testWelcomeScreen
            // 
            this.testWelcomeScreen.Location = new System.Drawing.Point(16, 16);
            this.testWelcomeScreen.Name = "testWelcomeScreen";
            this.testWelcomeScreen.Size = new System.Drawing.Size(784, 496);
            this.testWelcomeScreen.TabIndex = 0;
            // 
            // allCoursesPanel
            // 
            this.allCoursesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allCoursesPanel.Controls.Add(this.btnStartTest);
            this.allCoursesPanel.Controls.Add(this.questionsFlowLayoutPanel);
            this.allCoursesPanel.Controls.Add(this.lblTests);
            this.allCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.allCoursesPanel.Name = "allCoursesPanel";
            this.allCoursesPanel.Size = new System.Drawing.Size(184, 528);
            this.allCoursesPanel.TabIndex = 9;
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnStartTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartTest.FlatAppearance.BorderSize = 0;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartTest.Location = new System.Drawing.Point(8, 472);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(168, 48);
            this.btnStartTest.TabIndex = 5;
            this.btnStartTest.Text = "Запустить тестирование";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // questionsFlowLayoutPanel
            // 
            this.questionsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionsFlowLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.questionsFlowLayoutPanel.Name = "questionsFlowLayoutPanel";
            this.questionsFlowLayoutPanel.Size = new System.Drawing.Size(168, 424);
            this.questionsFlowLayoutPanel.TabIndex = 1;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTests.Location = new System.Drawing.Point(8, 8);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(85, 25);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Вопросы";
            // 
            // TestCompletingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allCoursesPanel);
            this.Controls.Add(this.questionsContainerPanel);
            this.Name = "TestCompletingControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.Load += new System.EventHandler(this.TestCompletingControl_Load);
            this.questionsContainerPanel.ResumeLayout(false);
            this.allCoursesPanel.ResumeLayout(false);
            this.allCoursesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionsContainerPanel;
        private DeserializedQuestionPanels.TestWelcomeScreen testWelcomeScreen;
        private System.Windows.Forms.Panel allCoursesPanel;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.FlowLayoutPanel questionsFlowLayoutPanel;
        private System.Windows.Forms.Label lblTests;
    }
}
